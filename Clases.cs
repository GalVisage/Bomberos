using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Data.SqlClient;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    internal class Clases
    {
        public static frm_bombero FormBomb = new frm_bombero();
        public static frm_administrador FormAdm = new frm_administrador();

        public class Instante()
        {
            ConexionConBD conectar = new ConexionConBD();
            public int Idfechamomento { get; private set; }


            public void Instante2()
            {
                conectar = new ConexionConBD();
                MomentoInstante();

            }
            public void MomentoInstante()
            {
                Clases.Fecha = DateTime.Now;
                string fechaFormateada = Clases.Fecha.ToString("dd-MM-yyyy HH-mm-ss");
                bool alta = conectar.ABM("INSERT INTO Fecha DEFAULT VALUES;");

                if (!alta)
                {
                    Console.WriteLine("Error: No se pudo insertar en la tabla Fecha.");

                    return; // Detenemos la ejecución si la inserción falla
                }
                MessageBox.Show("el valor de la fecha es " + fechaFormateada);


                SqlDataReader lector = conectar.Leer("SELECT MAX(ID_fecha) FROM Fecha;");

                if (lector != null && lector.Read()) // Verificamos que el lector no sea nulo y tenga datos
                {
                    Idfechamomento = lector.GetInt32(0); // Asignamos el valor de la primera columna como Idfechamomento
                }
                else
                {
                    Console.WriteLine("Error: No se obtuvo un ID de fecha válido.");
                }

                // Cierra el lector y desconecta la base de datos
                lector?.Close();
                conectar.Desconectar();
            }
        }
        public class Datos
        {
            public static string VariableX { get; set; }

            public static string VariableY { get; set; }
        }

        public static DateTime Fecha;
        public static int IDBombero;

      


        public static BotonColorManager botonmanager = new BotonColorManager(Color.Black);
        public class Bombero
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Jerarquia { get; set; }
            public string Area { get; set; }
            public string ID { get; set; }
        }
        public class BomberoDataAccess
        {
            private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CuartelBomberosNoviembre2;Trusted_Connection=true";

            public Bombero ObtenerDatosBomberoPorCodigo(int codBombero)
            {
                Bombero bombero = null;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT b.Nombre_bombero, b.Apellido_bombero, j.Nombre_jerarquia, a.Nombre_area, b.ID_bombero
                             FROM Bombero b
                             INNER JOIN Jerarquia j ON b.ID_jerarquia = j.ID_jerarquia
                             INNER JOIN Area a ON b.ID_area = a.ID_area
                             WHERE b.Cod_bombero = @Cod_bombero";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cod_bombero", codBombero);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bombero = new Bombero
                                {
                                    Nombre = reader["Nombre_bombero"].ToString(),
                                    Apellido = reader["Apellido_bombero"].ToString(),
                                    Jerarquia = reader["Nombre_jerarquia"].ToString(),
                                    Area = reader["Nombre_area"].ToString(),
                                    ID = reader["ID_bombero"].ToString(),

                                };
                            }
                        }
                    }
                }
                return bombero;
            }
        }

        public class BordesRedondeados
        {
            // Método para aplicar bordes redondeados a un control, como un botón o panel
            public static void Aplicar(Control control, int radio, PaintEventArgs e)
            {
                // Crear una ruta de gráficos con bordes redondeados
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radio, radio, 180, 90);
                path.AddArc(control.Width - radio, 0, radio, radio, 270, 90);
                path.AddArc(control.Width - radio, control.Height - radio, radio, radio, 0, 90);
                path.AddArc(0, control.Height - radio, radio, radio, 90, 90);
                path.CloseFigure();

                // Aplica la región al control
                control.Region = new Region(path);
            }
        }

        public class RoundedTextBox : TextBox
        {
            // Constructor
            public RoundedTextBox()
            {
                // Remover bordes por defecto
                this.BorderStyle = BorderStyle.None;
            }

            // Sobrescribir OnPaint para dibujar el borde redondeado
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                // Crear un pincel y una ruta gráfica con bordes redondeados
                Graphics graphics = e.Graphics;
                using (GraphicsPath path = new GraphicsPath())
                {
                    // Definir el radio de redondeo
                    int radius = 15;

                    // Dibujar los bordes redondeados
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    // Aplicar la región al control
                    this.Region = new Region(path);

                    // Dibujar borde
                    using (Pen pen = new Pen(Color.Gray, 2))
                    {
                        graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        public class GestorFormularios
        {
            // Método genérico para cargar formularios en un panel
            public static void CargarFormularioEnPanel<T>(Panel panelDestino) where T : Form, new()
            {

                foreach (Control control in panelDestino.Controls)// Limpiar controles anteriores del panel
                {
                    control.Dispose();
                }
                panelDestino.Controls.Clear();

                T form = new T// Para crear una nueva instancia del formulario siempre
                {
                    TopLevel = false,// Configurar el formulario para que no sea de nivel superior y ajustar estilo
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                panelDestino.Controls.Add(form); // Agregar el formulario al panel y mostrarlo
                panelDestino.Tag = form;
                form.Show();
            }
        }

        public class BotonColorManager
        {
            private Button botonActivo; // Botón que está actualmente presionado
            private Color colorOriginal; // Color original del botón
            private Color colorPresionado; // Color que se le asigna al presionar

            // Constructor, define el color presionado
            public BotonColorManager(Color colorPresionado)
            {
                this.colorPresionado = colorPresionado;
            }

            // Método para registrar botones, recorre los controles del formulario o panel
            public void RegistrarTodosLosBotones(Control parent)
            {
                foreach (Control control in parent.Controls)
                {
                    // Si el control es un botón, lo registra
                    if (control is Button)
                    {
                        ((Button)control).Click += Boton_Click; // Asocia el evento click a cada botón
                    }

                    // Si el control tiene otros controles hijos (como paneles), se llama recursivamente
                    if (control.HasChildren)
                    {
                        RegistrarTodosLosBotones(control);
                    }
                }
            }

            // Evento click del botón
            private void Boton_Click(object sender, EventArgs e)
            {
                Button botonPresionado = sender as Button;

                // Si el botón actual no es el mismo que el presionado
                if (botonActivo != botonPresionado)
                {
                    // Restablecer el color del botón previamente presionado
                    if (botonActivo != null)
                    {
                        botonActivo.BackColor = colorOriginal;
                    }

                    // Guardar el botón presionado como activo y cambiar su color
                    botonActivo = botonPresionado;
                    colorOriginal = botonActivo.BackColor; // Guardar el color original del botón presionado
                    botonActivo.BackColor = colorPresionado;
                }
            }
        }

        public class ConexionConBD
        {
            static private SqlConnection Conexion;
            static private SqlCommand Orden;

            public static string strConexion = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=CuartelBomberosNoviembre2; Trusted_Connection=True;";

            public SqlDataReader Leer(string Consulta)
            {
                SqlDataReader Lector;

                Conexion = new SqlConnection(strConexion);
                Orden = new SqlCommand(Consulta, Conexion);

                try
                {
                    Conexion.Open();
                    Lector = Orden.ExecuteReader();
                    return Lector;
                }
                catch
                {
                    Lector = null;
                    return Lector;
                }
            }

            public void Desconectar()
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
            }

            // Método ABM modificado para aceptar parámetros
            public bool ABM(string Consulta, Dictionary<string, object> parametros = null)
            {
                bool Resultado = false;

                Conexion = new SqlConnection(strConexion);
                Orden = new SqlCommand(Consulta, Conexion);

                // Agregar parámetros si se proporcionan
                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        Orden.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }

                try
                {
                    Conexion.Open();
                    Orden.ExecuteNonQuery();
                    Resultado = true;
                }
                catch (Exception ex)
                {
                    Resultado = false;
                    MessageBox.Show("Error al insertar el registro: " + ex.Message);
                }
                Desconectar();
                return Resultado;
            }
        }

        public void InsertarEmergencia(DateTime horaInicio, DateTime horaFin, string observaciones, DataGridView dgv_emergencia)
        {
            string insertEmergenciaQuery = @"INSERT INTO Emergencia (Emergencia_inicio, Emergencia_fin, Detalle_emergencia) 
                                   VALUES (@Horainicio, @HoraFin, @Observaciones);
                                   SELECT SCOPE_IDENTITY();";

            string insertEmergenciaBomberoQuery = @"INSERT INTO Emergencia_bombero (ID_emergencia, ID_bombero) 
                                           VALUES (@ID_emergencia, @ID_bombero);";

            using (SqlConnection connection = new SqlConnection(ConexionConBD.strConexion))
            {
                SqlCommand insertEmergenciaCommand = new SqlCommand(insertEmergenciaQuery, connection);
                insertEmergenciaCommand.Parameters.AddWithValue("@HoraInicio", horaInicio);
                insertEmergenciaCommand.Parameters.AddWithValue("@HoraFin", horaFin);
                insertEmergenciaCommand.Parameters.AddWithValue("@Observaciones", observaciones);

                try
                {
                    connection.Open();

                    // Insertar en la tabla emergencia y obtener el ID de emergencia
                    int idEmergencia = Convert.ToInt32(insertEmergenciaCommand.ExecuteScalar()); //Por aca hay error

                    // Insertar cada bombero de dgv_emergencia en Emergencia_bombero
                    foreach (DataGridViewRow row in dgv_emergencia.Rows)
                    {
                        if (row.Cells["Cod_bombero"].Value != null)
                        {
                            string codigoBombero = row.Cells["Cod_bombero"].Value.ToString();

                            // Verificar el ID de bombero en la tabla Bombero antes de la inserción
                            SqlCommand getBomberoIDCommand = new SqlCommand("SELECT ID_bombero FROM Bombero WHERE Cod_bombero = @codigoBombero", connection);
                            getBomberoIDCommand.Parameters.AddWithValue("@codigoBombero", codigoBombero);

                            object result = getBomberoIDCommand.ExecuteScalar();

                            if (result == null)
                            {
                                MessageBox.Show("El bombero con código " + codigoBombero + " no existe en la base de datos.");
                                continue; // Omitir este bombero si no existe
                            }

                            int idBombero = Convert.ToInt32(result);

                            // Ahora inserta en Emergencia_bombero con el ID_bombero real
                            SqlCommand insertEmergenciaBomberoCommand = new SqlCommand(insertEmergenciaBomberoQuery, connection);
                            insertEmergenciaBomberoCommand.Parameters.AddWithValue("@ID_emergencia", idEmergencia);
                            insertEmergenciaBomberoCommand.Parameters.AddWithValue("@ID_bombero", idBombero);

                            insertEmergenciaBomberoCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Emergencia y bomberos guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los datos: " + ex.Message);
                }
            }

        }
        public void InsertarReunion(DateTime fechareunion, string observaciones, DataGridView dgv_reunionesbomb)
        {
            string insertReunionQuery = @"INSERT INTO Reuniones (Detalle_reunion,Reunion_fecha) 
                                   VALUES (@Observaciones, @Fecha);
                                   SELECT SCOPE_IDENTITY();";

            string insertReunionBomberoQuery = @"INSERT INTO reunion_bombero (ID_reunion, ID_bombero) 
                                           VALUES (@ID_reunion, @ID_bombero);";

            using (SqlConnection connection = new SqlConnection(ConexionConBD.strConexion))
            {
                SqlCommand insertReunionCommand = new SqlCommand(insertReunionQuery, connection);
                insertReunionCommand.Parameters.AddWithValue("@Observaciones", observaciones);
                insertReunionCommand.Parameters.AddWithValue("@Fecha", fechareunion);

                try
                {
                    connection.Open();

                    // Insertar en la tabla emergencia y obtener el ID de emergencia
                    int idreunion = Convert.ToInt32(insertReunionCommand.ExecuteScalar()); //Por aca hay error

                    // Insertar cada bombero de dgv_emergencia en Emergencia_bombero
                    foreach (DataGridViewRow row in dgv_reunionesbomb.Rows)
                    {
                        if (row.Cells["Cod_bombero"].Value != null)
                        {
                            string codigoBombero = row.Cells["Cod_bombero"].Value.ToString();

                            // Verificar el ID de bombero en la tabla Bombero antes de la inserción
                            SqlCommand getBomberoIDCommand = new SqlCommand("SELECT ID_bombero FROM Bombero WHERE Cod_bombero = @codigoBombero", connection);
                            getBomberoIDCommand.Parameters.AddWithValue("@codigoBombero", codigoBombero);

                            object result = getBomberoIDCommand.ExecuteScalar();

                            if (result == null)
                            {
                                MessageBox.Show("El bombero con código " + codigoBombero + " no existe en la base de datos.");
                                continue; // Omitir este bombero si no existe
                            }

                            int idBombero = Convert.ToInt32(result);

                            // Ahora inserta en Emergencia_bombero con el ID_bombero real
                            SqlCommand insertEmergenciaBomberoCommand = new SqlCommand(insertReunionBomberoQuery, connection);
                            insertEmergenciaBomberoCommand.Parameters.AddWithValue("@ID_reunion", idreunion);
                            insertEmergenciaBomberoCommand.Parameters.AddWithValue("@ID_bombero", idBombero);

                            insertEmergenciaBomberoCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Emergencia y bomberos guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los datos: " + ex.Message);
                }
            }

        }
        //CONEXION BD JUAN
        public class BomberoABM
        {
            public DataTable ObtenerBomberos()
            {
                using (SqlConnection con = new Conexion().GetConnection())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT b.ID_bombero AS ID, " +
                    "b.Apellido_bombero AS Apellido, " +
                    "b.Nombre_bombero AS Nombre, " +
                    "b.Documento_bombero AS DNI, " +
                    "j.Nombre_jerarquia AS Jerarquia, " +
                    "a.Nombre_area AS Area, " +
                    "b.Cod_bombero AS [Numero bombero], " +
                    "b.Permiso_bombero AS Administrador, " +
                    "b.Estado_bombero AS Activo, b.Contrasena_bombero  " +
                    "FROM Bombero b " +
                    "JOIN Area a ON b.ID_area = a.ID_area " +
                    "JOIN Jerarquia j ON b.ID_jerarquia = j.ID_jerarquia", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dt.Columns.Remove("Contrasena_bombero");
                    return dt;
                }
            }
            public bool CodBomberoExists(int codBombero)
            {
                using (SqlConnection con = new Conexion().GetConnection())
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Bombero WHERE Cod_bombero = @Cod_bombero";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Cod_bombero", codBombero);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            public void AgregarBombero(string apellido, string nombre, string dni, int codBombero, int idJerarquia, int idArea, bool permisoAdmin, string contrasena, bool estadoActivo)
            {
                using (SqlConnection con = new Conexion().GetConnection())
                {
                    con.Open();
                    if (CodBomberoExists(codBombero))
                    {
                        MessageBox.Show("El código de bombero ya existe. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string query = "INSERT INTO Bombero (Apellido_bombero, Nombre_bombero, Documento_bombero, Cod_bombero, ID_jerarquia, ID_area, Estado_bombero, Permiso_bombero, Contrasena_bombero) " +
                                   "VALUES (@Apellido_bombero, @Nombre_bombero, @Documento_bombero, @Cod_bombero, @ID_jerarquia, @ID_area, @Estado_bombero, @Permiso_bombero, @Contrasena_bombero)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Apellido_bombero", apellido);
                    cmd.Parameters.AddWithValue("@Nombre_bombero", nombre);
                    cmd.Parameters.AddWithValue("@Documento_bombero", dni);
                    cmd.Parameters.AddWithValue("@Cod_bombero", codBombero);
                    cmd.Parameters.AddWithValue("@ID_jerarquia", idJerarquia);
                    cmd.Parameters.AddWithValue("@ID_area", idArea);
                    cmd.Parameters.AddWithValue("@Permiso_bombero", permisoAdmin ? 1 : 0);
                    if (permisoAdmin)
                    {
                        cmd.Parameters.AddWithValue("@Contrasena_bombero", contrasena);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Contrasena_bombero", DBNull.Value);
                    }

                    // Estado de bombero activo o inactivo
                    cmd.Parameters.AddWithValue("@Estado_bombero", estadoActivo ? 1 : 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            public int ObtenerCodBomberoPorID(int idBombero)
            {
                using (SqlConnection con = new Conexion().GetConnection())
                {
                    con.Open();
                    string query = "SELECT Cod_bombero FROM Bombero WHERE ID_bombero = @ID_bombero";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID_bombero", idBombero);
                    return (int)cmd.ExecuteScalar();
                }
            }
            public void ModificarBombero(int idBombero, string apellido, string nombre, string dni, int codBombero, int idJerarquia, int idArea, bool permisoAdmin, string contrasena, bool estadoActivo)
            {
                using (SqlConnection con = new Conexion().GetConnection())
                {
                    con.Open();
                    if (CodBomberoExists(codBombero) && codBombero != ObtenerCodBomberoPorID(idBombero))
                    {
                        MessageBox.Show("El código de bombero ya existe. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string query = "UPDATE Bombero SET Apellido_bombero = @Apellido_bombero, " +
                                   "Nombre_bombero = @Nombre_bombero, " +
                                   "Cod_bombero = @Cod_bombero, " +
                                   "Documento_bombero = @Documento_bombero, " +
                                   "ID_jerarquia = @ID_jerarquia, " +
                                   "ID_area = @ID_area, " +
                                   "Permiso_bombero = @Permiso_bombero, " +
                                   "Contrasena_bombero = @Contrasena_bombero, " +
                                   "Estado_bombero = @Estado_bombero " +
                                   "WHERE ID_bombero = @ID_bombero";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID_bombero", idBombero);
                    cmd.Parameters.AddWithValue("@Apellido_bombero", apellido);
                    cmd.Parameters.AddWithValue("@Nombre_bombero", nombre);
                    cmd.Parameters.AddWithValue("@Documento_bombero", dni);
                    cmd.Parameters.AddWithValue("@Cod_bombero", codBombero);
                    cmd.Parameters.AddWithValue("@ID_jerarquia", idJerarquia);
                    cmd.Parameters.AddWithValue("@ID_area", idArea);
                    cmd.Parameters.AddWithValue("@Permiso_bombero", permisoAdmin ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Contrasena_bombero", permisoAdmin ? contrasena : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Estado_bombero", estadoActivo ? 1 : 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro modificado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            public void EliminarBombero(int idBombero)
            {
                using (SqlConnection con = new Conexion().GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM Bombero WHERE ID_bombero = @ID_bombero";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID_bombero", idBombero);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
