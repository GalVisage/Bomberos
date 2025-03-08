using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    public partial class frm_tareaspendientes : Form
    {
        Clases.ConexionConBD conectar = new Clases.ConexionConBD();
        DataTable tabla = new DataTable();
        public frm_tareaspendientes()
        {
            InitializeComponent();
        }
        public frm_tareaspendientes(DataTable tabla)
        {
            InitializeComponent();
            this.tabla = tabla; // Guardamos el DataTable para usarlo más tarde
        }
        public void Actualizar()
        {
            dgv_tareascargadas.DataSource = null;
            dgv_tareascargadas.Rows.Clear();

            DataTable tabla = new DataTable();

            string consulta = Datos.VariableX;
            if (string.IsNullOrEmpty(consulta))
            {
                MessageBox.Show("La consulta está vacía. Verifique el valor de Datos.VariableX.");
                return;
            }
            try
            {
                tabla.Load(conectar.Leer(consulta));
                // MessageBox.Show($"Filas cargadas: {tabla.Rows.Count}");
                dgv_tareascargadas.DataSource = tabla;
                dgv_tareascargadas.Refresh();
                dgv_tareascargadas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                conectar.Desconectar();
            }
        }

        public void CerrarForm()
        {
            this.Close();
        }
        public DataGridView DgvTareasCargadas
        {
            get { return dgv_tareascargadas; }
        }
        private void btn_atrastareaspendientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmarFTP_Click(object sender, EventArgs e)
        {
            if (dgv_tareascargadas.SelectedRows.Count > 0)
            {
                // Obtén el ID del registro seleccionado
                int id = Convert.ToInt32(dgv_tareascargadas.SelectedRows[0].Cells["ID_tarea"].Value);
                DialogResult resultado = MessageBox.Show("¿Seguro que quiere eliminar la tarea seleccionada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    conectar.ABM(@"DELETE FROM Tarea WHERE ID_tarea =" + id);
                    MessageBox.Show("Se elimino el registro exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Actualizar();
                }
                else
                    Actualizar();
            }
        }

        private void frm_tareaspendientes_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
