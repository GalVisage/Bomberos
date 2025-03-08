using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    public partial class frm_ABMareas : Form
    {
        public frm_ABMareas()
        {
            InitializeComponent();
            Actualizar();
            dgv_planillaareasABM.ClearSelection();
        }
        private void Actualizar()
        {
            AreaABM areaABM = new AreaABM();
            DataTable dt = areaABM.ObtenerAreas();
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (row[i] is string)
                    {
                        row[i] = row[i].ToString().Trim();
                    }
                }
            }
            dgv_planillaareasABM.DataSource = dt;
            string[] columnasAnchoEspecifico = { "ID area" };
            int totalAncho = dgv_planillaareasABM.Width;
            foreach (DataGridViewColumn column in dgv_planillaareasABM.Columns)
            {
                if (Array.Exists(columnasAnchoEspecifico, col => col == column.HeaderText))
                {

                    column.Width = (int)(totalAncho * 0.10);
                }
                else
                {
                    column.Width = (int)(totalAncho * 0.92);
                }
            }
        }
        private void Limpiar()
        {
            txt_nombreareaABM.Clear();
            txt_IDarea.Clear();
            btn_editarareaABM.Enabled = false;
            btn_eliminarareaABM.Enabled = false;
            btn_agregaareaABM.Enabled = true;
        }
        private bool ValidarCampos()
        {
            var controlesValidar = new Dictionary<Control, string>
{
{ txt_nombreareaABM, "El campo nombre de area es obligatorio y solo puede contener letras y espacios." },
};
            string soloLetrasEspacios = @"^[a-zA-ZáéíóúÁÉÍÓÚ\s]+$";

            foreach (var control in controlesValidar)
            {
                if (string.IsNullOrWhiteSpace(control.Key.Text))
                {
                    MessageBox.Show(control.Value, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (control.Key == txt_nombreareaABM)
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(control.Key.Text, soloLetrasEspacios))
                    {
                        MessageBox.Show(control.Value, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private void btn_agregaareaABM_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    AreaABM areaABM = new AreaABM();
                    areaABM.Agregararea(txt_nombreareaABM.Text);
                    Actualizar();
                    Limpiar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al agregar el area: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_editarareaABM_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    AreaABM areaABM = new AreaABM();
                    int idArea = Convert.ToInt32(txt_IDarea.Text);
                    string Nombrearea = txt_nombreareaABM.Text;
                    areaABM.Modificararea(idArea, Nombrearea);
                    Actualizar();
                    Limpiar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al modificar el area: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_eliminarareaABM_Click(object sender, EventArgs e)
        {
            var Confirmar = MessageBox.Show("¿Está seguro de que desea eliminar esta área?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Confirmar == DialogResult.Yes)
            {
                int idArea = Convert.ToInt32(txt_IDarea.Text);
                AreaABM areaABM = new AreaABM();
                areaABM.Eliminararea(idArea);
                Actualizar();
                Limpiar();
            }
        }

        private void dgv_planillaareasABM_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelected = dgv_planillaareasABM.SelectedRows.Count > 0;
            btn_editarareaABM.Enabled = isSelected;
            btn_eliminarareaABM.Enabled = isSelected;
            btn_agregaareaABM.Enabled = !isSelected;

            if (isSelected)
            {
                DataGridViewRow row = dgv_planillaareasABM.SelectedRows[0];
                txt_IDarea.Text = row.Cells["ID area"].Value.ToString();
                txt_nombreareaABM.Text = row.Cells["Nombre area"].Value?.ToString().Trim() ?? string.Empty;
            }
            else
            {
                txt_IDarea.Clear();
                txt_nombreareaABM.Clear();
            }
        }

        private void dgv_planillaareasABM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_planillaareasABM.Rows[e.RowIndex];

                txt_IDarea.Text = row.Cells["ID area"].Value.ToString();
                txt_nombreareaABM.Text = row.Cells["Nombre area"].Value?.ToString().Trim() ?? string.Empty;

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ABMareas_Load(object sender, EventArgs e)
        {
            dgv_planillaareasABM.ClearSelection();
        }
    }
}
