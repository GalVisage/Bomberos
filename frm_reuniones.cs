using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi.Clases;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    public partial class frm_reuniones : Form
    {
        private Clases funciones = new Clases();
        public frm_reuniones()
        {
            InitializeComponent();
        }
        public void CargarBomberoPorCodigo(string codigoBombero, DataGridView dgv_reunionesbomb)
        {
            string query = "SELECT Bombero.Nombre_bombero,Bombero.Apellido_bombero, Bombero.Cod_bombero FROM Bombero WHERE Cod_bombero = @Cod_bombero";
            using (SqlConnection connection = new SqlConnection(ConexionConBD.strConexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cod_bombero", codigoBombero);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Verificar si el DataGridView tiene un DataSource existente o crear uno nuevo
                        if (dgv_reunionesbomb.DataSource == null)
                        {
                            dgv_reunionesbomb.DataSource = dt;
                            dgv_reunionesbomb.Columns["Apellido_bombero"].HeaderText = "Apellido";
                            dgv_reunionesbomb.Columns["Nombre_bombero"].HeaderText = "Nombre";
                            dgv_reunionesbomb.Columns["Cod_bombero"].HeaderText = "Codigo";
                        }
                        else
                        {
                            // Si ya hay un DataTable vinculado, agregamos las nuevas filas
                            DataTable currentDt = (DataTable)dgv_reunionesbomb.DataSource;

                            foreach (DataRow row in dt.Rows)
                            {
                                // Comprobar si el bombero ya está en el DataGridView
                                bool exists = currentDt.AsEnumerable().Any(r => r["Cod_bombero"].ToString() == row["Cod_bombero"].ToString());

                                if (!exists)
                                {
                                    currentDt.ImportRow(row); // Añadir solo si no existe
                                }
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("No se encontraron bomberos con el código ingresado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del bombero: " + ex.Message);
                }
            }
        }
        private void btn_cancelarreuniones_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardarreuniones_Click(object sender, EventArgs e)
        {
            if (dgv_reunionesbomb.Rows.Count > 0)
            {
                // Obtener los valores de los DateTimePicker
                DateTime fechareunion = dtp_fechareuniones.Value;
                string observaciones = txt_obsreunionF6.Text;

                // Insertar la emergencia y asociar los bomberos cargados en el DataGridView
                funciones.InsertarReunion(fechareunion, observaciones, dgv_reunionesbomb);
                this.Close();

            }
            else
            {
                MessageBox.Show("Debe cargar al menos un bombero antes de guardar la emergencia.");
            }
            this.Close();
        }

        private void pnl_listareuniones_Paint(object sender, PaintEventArgs e)
        {
            Clases.BordesRedondeados.Aplicar(pnl_listareuniones, 30, e);
            Clases.BordesRedondeados.Aplicar(pnl_datosreuniones, 30, e);
            Clases.BordesRedondeados.Aplicar(pnl_obsreuniones, 30, e);
        }

        private void btn_cargaparticipantereunion_Click(object sender, EventArgs e)
        {
            CargarBomberoPorCodigo(txt_participantereunion.Text, dgv_reunionesbomb);
        }

        private void btn_bajaparticipantesReu_Click(object sender, EventArgs e)
        {
            string codigoBombero = txt_bajaparticipantereuniones.Text.Trim();

            if (string.IsNullOrEmpty(codigoBombero))
            {
                MessageBox.Show("Por favor, ingrese un código de bombero para eliminar.");
                return;
            }

            bool encontrado = false;
            foreach (DataGridViewRow row in dgv_reunionesbomb.Rows)
            {
                if (row.Cells["Cod_bombero"].Value != null && row.Cells["Cod_bombero"].Value.ToString() == codigoBombero)
                {
                    dgv_reunionesbomb.Rows.Remove(row);
                    encontrado = true;
                    MessageBox.Show("Bombero eliminado del listado.");
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró un bombero con el código ingresado.");
            }

            txt_bajaparticipantereuniones.Clear();
        }
    }
}
