using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    public partial class frm_administrador : Form
    {
        Clases.ConexionConBD conectar = new Clases.ConexionConBD();
        DataTable tabla = new DataTable();
        Clases.BotonColorManager botonmanager = new BotonColorManager(Color.FromArgb(2, 21, 38));

        frm_tareaspendientes FormTareasp = new frm_tareaspendientes();
        frm_planillas FormPlanis = new frm_planillas();

        public frm_administrador()
        {
            InitializeComponent();
            customizeDesign();
            GestorFormularios.CargarFormularioEnPanel<frm_ingresosalida>(pnl_navegadorpestañasF4);

            // Inicializamos el gestor de botones con el color que queremos asignar cuando se presionan


            // Registramos todos los botones del formulario
            botonmanager.RegistrarTodosLosBotones(this);
        }

        private void CrearBotonesDinamicosEnPanel()
        {
            using (SqlConnection con = new Conexion().GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT ID_area, Nombre_area FROM Area";
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader reader = command.ExecuteReader();
                    for (int i = pnl_contenedorareas.Controls.Count - 1; i >= 0; i--)
                    {
                        Control control = pnl_contenedorareas.Controls[i];
                        if (control is System.Windows.Forms.Button && control.Name.StartsWith("btnArea"))
                        {
                            pnl_contenedorareas.Controls.Remove(control);
                            control.Dispose();
                        }
                    }
                    pnl_contenedorareas.Controls.Clear();
                    int buttonHeight = 30;
                    int buttonCount = 0;
                    while (reader.Read())
                    {
                        int idArea = reader.GetInt32(0);
                        string nombreArea = reader.GetString(1);

                        System.Windows.Forms.Button btnArea = new System.Windows.Forms.Button
                        {
                            Name = "btnArea" + idArea,
                            Text = "   " + nombreArea.ToUpper(),
                            Tag = (idArea, nombreArea),
                            Size = new Size(192, buttonHeight),
                            FlatStyle = FlatStyle.Flat,
                            Font = new Font("Sitka Small", 8.25F, FontStyle.Bold),
                            BackColor = Color.FromArgb(50, 55, 60),
                            ForeColor = Color.White,
                            Dock = DockStyle.Top,
                            TextAlign = ContentAlignment.MiddleLeft
                        };
                        btnArea.FlatAppearance.BorderSize = 0;
                        btnArea.Click += BtnArea_Click;
                        pnl_contenedorareas.Controls.Add(btnArea);
                        buttonCount++;
                    }
                    reader.Close();
                    pnl_contenedorareas.Height = buttonCount * buttonHeight;

                    pnl_contenedorareas.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar áreas: " + ex.Message);
                }
            }
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btnClicked = sender as System.Windows.Forms.Button;
            if (btnClicked != null)
            {
                var (idArea, nombreArea) = ((int, string))btnClicked.Tag;
                VariablesGlobales.IdArea = idArea;
                VariablesGlobales.NombreArea = nombreArea;
                frm_planillas formPlanillas = new frm_planillas();
                GestorFormularios.CargarFormularioEnPanel<frm_tareaspendientes>(pnl_navegadorpestañasF4);
            }
        }
        private void customizeDesign()
        {
            pnl_contendedortareas.Visible = false;
            pnl_contenedorareas.Visible = false;
            pnl_contenedorplanillas.Visible = false;
            pnl_contenedorgestion.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnl_contendedortareas.Visible == true)
                pnl_contendedortareas.Visible = false;

            if (pnl_contenedorareas.Visible == true)
                pnl_contenedorareas.Visible = false;

            if (pnl_contenedorplanillas.Visible == true)
                pnl_contenedorplanillas.Visible = false;

            if (pnl_contenedorgestion.Visible == true)
                pnl_contenedorgestion.Visible = false;
        }

        private void ShowSubMenu(Panel pnl_submenu)
        {
            if (pnl_submenu.Visible == false)
            {
                HideSubMenu();
                pnl_submenu.Visible = true;
            }
            else
                pnl_submenu.Visible = false;
        }

        //Menu de Registros-----------------------------------------------------------------------------

        private void btn_registrosformadm_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_contendedortareas);
        }

        private void btn_entradasalidaformadm_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_ingresosalida>(pnl_navegadorpestañasF4);
        }

        private void btn_regtareaformadm_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_tareas>(pnl_navegadorpestañasF4);
        }

        private void btn_emergenciaformadm_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_emergencia>(pnl_navegadorpestañasF4);
        }
        private void btn_reunionesformadm_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_reuniones>(pnl_navegadorpestañasF4);
        }
        //MENU DE AREAS------------------------------------------------------------------------------------

        //Boton desplegable--------------------------------------------------------------------------------
        private void btn_tareasareaformadm_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_contenedorareas);
        }
        //-------------------------------------------------------------------------------------------------
        private void btn_automotoresformadm_Click(object sender, EventArgs e)
        {
            FormTareasp?.Close();
            FormTareasp = new frm_tareaspendientes();

            Datos.VariableX = "SELECT Area.Nombre_area, Bombero.Apellido_bombero, Bombero.Nombre_bombero, Tarea.Descripcion_tarea, Tarea.Fecha_tarea, Tarea.Estado_tarea, Tarea.Punto_tarea, Tarea.Colaboracion_tarea, Jerarquia.Nombre_jerarquia, Asistencia_area.Puntaje FROM Area INNER JOIN Bombero ON Area.ID_area = Bombero.ID_area INNER JOIN Asistencia_area ON Bombero.ID_bombero = Asistencia_area.ID_bombero INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia INNER JOIN Tarea ON Area.ID_area = Tarea.ID_area where Area.ID_area = 5;";

            FormTareasp.Actualizar();

            GestorFormularios.CargarFormularioEnPanel<frm_tareaspendientes>(pnl_navegadorpestañasF4);

            Datos.VariableX = string.Empty;
        }
        private void btn_edificioformadm_Click(object sender, EventArgs e)
        {
            FormTareasp?.Close();

            FormTareasp = new frm_tareaspendientes();

            Datos.VariableX = "SELECT Area.Nombre_area, Bombero.Apellido_bombero, Bombero.Nombre_bombero, Tarea.Descripcion_tarea, Tarea.Fecha_tarea, Tarea.Punto_tarea, Tarea.Colaboracion_tarea, Jerarquia.Nombre_jerarquia, Asistencia_area.Puntaje FROM Area INNER JOIN Bombero ON Area.ID_area = Bombero.ID_area INNER JOIN Asistencia_area ON Bombero.ID_bombero = Asistencia_area.ID_bombero INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia INNER JOIN Tarea ON Area.ID_area = Tarea.ID_area where Area.ID_area = 1;";

            FormTareasp.Actualizar();

            GestorFormularios.CargarFormularioEnPanel<frm_tareaspendientes>(pnl_navegadorpestañasF4);

            Datos.VariableX = string.Empty;

        }

        private void btn_roperiaformadm_Click(object sender, EventArgs e)
        {
            FormTareasp?.Close();

            FormTareasp = new frm_tareaspendientes();

            Datos.VariableX = "SELECT Area.Nombre_area, Bombero.Apellido_bombero, Bombero.Nombre_bombero, Tarea.Descripcion_tarea, Tarea.Fecha_tarea, Tarea.Punto_tarea, Tarea.Colaboracion_tarea, Jerarquia.Nombre_jerarquia, Asistencia_area.Puntaje FROM Area INNER JOIN Bombero ON Area.ID_area = Bombero.ID_area INNER JOIN Asistencia_area ON Bombero.ID_bombero = Asistencia_area.ID_bombero INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia INNER JOIN Tarea ON Area.ID_area = Tarea.ID_area where Area.ID_area = 2;";

            FormTareasp.Actualizar();

            GestorFormularios.CargarFormularioEnPanel<frm_tareaspendientes>(pnl_navegadorpestañasF4);

            Datos.VariableX = string.Empty;
        }

        private void btn_capacitacionformadm_Click(object sender, EventArgs e)
        {
            FormTareasp?.Close();

            FormTareasp = new frm_tareaspendientes();

            Datos.VariableX = "SELECT Area.Nombre_area, Bombero.Apellido_bombero, Bombero.Nombre_bombero, Tarea.Descripcion_tarea, Tarea.Fecha_tarea, Tarea.Punto_tarea, Tarea.Colaboracion_tarea, Jerarquia.Nombre_jerarquia, Asistencia_area.Puntaje FROM Area INNER JOIN Bombero ON Area.ID_area = Bombero.ID_area INNER JOIN Asistencia_area ON Bombero.ID_bombero = Asistencia_area.ID_bombero INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia INNER JOIN Tarea ON Area.ID_area = Tarea.ID_area where Area.ID_area = 3;";

            FormTareasp.Actualizar();

            GestorFormularios.CargarFormularioEnPanel<frm_tareaspendientes>(pnl_navegadorpestañasF4);

            Datos.VariableX = string.Empty;
        }

        private void btn_tallerformadm_Click(object sender, EventArgs e)
        {
            FormTareasp?.Close();

            FormTareasp = new frm_tareaspendientes();

            Datos.VariableX = "SELECT Area.Nombre_area, Bombero.Apellido_bombero, Bombero.Nombre_bombero, Tarea.Descripcion_tarea, Tarea.Fecha_tarea, Tarea.Punto_tarea, Tarea.Colaboracion_tarea, Jerarquia.Nombre_jerarquia, Asistencia_area.Puntaje FROM Area INNER JOIN Bombero ON Area.ID_area = Bombero.ID_area INNER JOIN Asistencia_area ON Bombero.ID_bombero = Asistencia_area.ID_bombero INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia INNER JOIN Tarea ON Area.ID_area = Tarea.ID_area where Area.ID_area = 4;";

            FormTareasp.Actualizar();

            GestorFormularios.CargarFormularioEnPanel<frm_tareaspendientes>(pnl_navegadorpestañasF4);

            Datos.VariableX = string.Empty;
        }

        private void btn_furrielesformadm_Click(object sender, EventArgs e)
        {
            FormTareasp?.Close();

            FormTareasp = new frm_tareaspendientes();

            Datos.VariableX = "SELECT Area.Nombre_area AS Area, Bombero.Apellido_bombero AS Apellido, Bombero.Nombre_bombero AS Nombre, Tarea.Descripcion_tarea AS 'Descripción de tarea', " +
                "Tarea.Fecha_tarea as 'Fecha de la tarea', Tarea.Punto_tarea AS Punto, Tarea.Colaboracion_tarea AS Colaboración, Jerarquia.Nombre_jerarquia AS Jerarquia, Asistencia_area.Puntaje AS Puntaje " +
                "FROM Area INNER JOIN Bombero ON Area.ID_area = Bombero.ID_area INNER JOIN Asistencia_area ON Bombero.ID_bombero = Asistencia_area.ID_bombero INNER JOIN Jerarquia " +
                "ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia INNER JOIN Tarea ON Area.ID_area = Tarea.ID_area where Area.ID_area = 6;";

            FormTareasp.Actualizar();

            GestorFormularios.CargarFormularioEnPanel<frm_tareaspendientes>(pnl_navegadorpestañasF4);

            Datos.VariableX = string.Empty;
        }
        private void btn_cargaguardiasadm_Click(object sender, EventArgs e)
        {
            FormTareasp?.Close();

            FormTareasp = new frm_tareaspendientes();

            Datos.VariableX = "SELECT Area.Nombre_area, Bombero.Apellido_bombero, Bombero.Nombre_bombero, Tarea.Descripcion_tarea, Tarea.Fecha_tarea, Tarea.Punto_tarea, Tarea.Colaboracion_tarea, Jerarquia.Nombre_jerarquia, Asistencia_area.Puntaje FROM Area INNER JOIN Bombero ON Area.ID_area = Bombero.ID_area INNER JOIN Asistencia_area ON Bombero.ID_bombero = Asistencia_area.ID_bombero INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia INNER JOIN Tarea ON Area.ID_area = Tarea.ID_area where Area.ID_area = 7;";

            FormTareasp.Actualizar();

            GestorFormularios.CargarFormularioEnPanel<frm_tareaspendientes>(pnl_navegadorpestañasF4);

            Datos.VariableX = string.Empty;
        }

        //MENU DE PLANILLAS-------------------------------------------------------------------------

        //Boton desplegable-------------------------------------------------------------------------
        private void btn_planillasformadm_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_contenedorplanillas);
        }
        //------------------------------------------------------------------------------------------
        private void btn_cargaemergencias_Click(object sender, EventArgs e)
        {
            FormPlanis?.Close();

            FormPlanis = new frm_planillas();

            Datos.VariableY = "SELECT Emergencia.Detalle_emergencia, Emergencia.Emergencia_inicio, Emergencia.Emergencia_fin, Bombero.Apellido_bombero, Bombero.Nombre_bombero, Jerarquia.Nombre_jerarquia FROM  Bombero INNER JOIN  Emergencia_bombero ON Bombero.ID_bombero = Emergencia_bombero.ID_bombero INNER JOIN  Emergencia ON Emergencia_bombero.ID_emergencia = Emergencia.ID_emergencia INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia";

            FormPlanis.ActualizarPlanilla();

            GestorFormularios.CargarFormularioEnPanel<frm_planillas>(pnl_navegadorpestañasF4);

            Datos.VariableY = string.Empty;
        }

        private void btn_reunionesadm_Click(object sender, EventArgs e)
        {
            FormPlanis?.Close();

            FormPlanis = new frm_planillas();

            Datos.VariableY = "SELECT Bombero.Apellido_bombero, Bombero.Nombre_bombero, Reuniones.Detalle_reunion, Reuniones.Reunion_fecha, Jerarquia.Nombre_jerarquia FROM reunion_bombero INNER JOIN  Reuniones ON reunion_bombero.ID_reunion = Reuniones.ID_reunion INNER JOIN Bombero ON reunion_bombero.ID_bombero = Bombero.ID_bombero INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia";

            FormPlanis.ActualizarPlanilla();

            GestorFormularios.CargarFormularioEnPanel<frm_planillas>(pnl_navegadorpestañasF4);

            Datos.VariableY = string.Empty;
        }

        private void btn_asisintsformadm_Click(object sender, EventArgs e)
        {
            FormPlanis?.Close();

            FormPlanis = new frm_planillas();

            Datos.VariableY = "SELECT Asistencia_institucion.Puntaje, Jerarquia.Nombre_jerarquia, Bombero.Apellido_bombero, Bombero.Nombre_bombero, Fecha.Fecha_actual FROM Asistencia_institucion INNER JOIN Bombero ON Asistencia_institucion.ID_bombero = Bombero.ID_bombero INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia INNER JOIN Fecha ON Asistencia_institucion.ID_fecha = Fecha.ID_fecha order by Fecha_actual desc;";

            FormPlanis.ActualizarPlanilla();

            GestorFormularios.CargarFormularioEnPanel<frm_planillas>(pnl_navegadorpestañasF4);

            Datos.VariableY = string.Empty;
        }

        private void btn_asisareaformadm_Click(object sender, EventArgs e)
        {
            FormPlanis?.Close();

            FormPlanis = new frm_planillas();

            Datos.VariableY = " SELECT Area.Nombre_area, Bombero.Apellido_bombero, Bombero.Nombre_bombero, Jerarquia.Nombre_jerarquia, Asistencia_area.Puntaje, Tarea.Fecha_tarea, Tarea.Punto_tarea FROM Area INNER JOIN Bombero ON Area.ID_area = Bombero.ID_area INNER JOIN Asistencia_area ON Bombero.ID_bombero = Asistencia_area.ID_bombero INNER JOIN Fecha ON Asistencia_area.ID_fecha = Fecha.ID_fecha INNER JOIN Jerarquia ON Bombero.ID_jerarquia = Jerarquia.ID_jerarquia INNER JOIN Tarea ON Area.ID_area = Tarea.ID_area order by Fecha_tarea desc;";

            FormPlanis.ActualizarPlanilla();

            GestorFormularios.CargarFormularioEnPanel<frm_planillas>(pnl_navegadorpestañasF4);

            Datos.VariableY = string.Empty;
        }
        //Menu Gestion------------------------------------------------------------------------------------------------

        //Boton Desplegable-------------------------------------------------------------------------------------------
        private void btn_admpersonalformadm_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_contenedorgestion);
        }

        private void btn_ABMformadm_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_ABMbomberos>(pnl_navegadorpestañasF4);
        }

        private void pnl_navegadorpestañasF4_Paint(object sender, PaintEventArgs e)
        {
            Clases.BordesRedondeados.Aplicar(pnl_navegadorpestañasF4, 30, e);
            Clases.BordesRedondeados.Aplicar(pnl_nombreformadm, 30, e);
            Clases.BordesRedondeados.Aplicar(pnl_codyareaF4, 30, e);
            Clases.BordesRedondeados.Aplicar(pnl_horaformadm, 30, e);
            Clases.BordesRedondeados.Aplicar(pnl_sectoradm, 30, e);
        }

        private void frm_administrador_Load(object sender, EventArgs e)
        {
            // Mostrar la fecha actual en el label de fecha
            lbl_fechaformadm.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer_horaadm.Start();
        }
        private void timer_horaadm_Tick(object sender, EventArgs e)
        {
            lbl_horaformadm.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_cerrarsesionadm_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (DialogResult == DialogResult.Yes)
                this.Close();
        }

        private void btn_ABMareas_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_ABMareas>(pnl_navegadorpestañasF4);
        }
    }
}