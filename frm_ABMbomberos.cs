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

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    public partial class frm_ABMbomberos : Form
    {
        public frm_ABMbomberos()
        {
            InitializeComponent();
            Actualizar();
            CargarComboBoxJerarquia();
            CargarComboBoxArea();
        }
        private void Actualizar()
        {
            Clases.BomberoABM bomberoABM = new Clases.BomberoABM();
            DataTable dt = bomberoABM.ObtenerBomberos();
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
            dgv_cuerpobomberosF5.DataSource = dt;
            dgv_cuerpobomberosF5.AutoGenerateColumns = true;
            string[] columnas10Porciento = { "ID", "Numero bombero", "Administrador", "Activo" };
            int totalColumns = dgv_cuerpobomberosF5.Columns.Count;
            foreach (DataGridViewColumn column in dgv_cuerpobomberosF5.Columns)
            {
                if (Array.Exists(columnas10Porciento, col => col == column.HeaderText))
                {
                    column.Width = (int)(dgv_cuerpobomberosF5.Width * 0.10);
                }
                else
                {
                    column.Width = (int)(dgv_cuerpobomberosF5.Width * 0.124);
                }

            }
        }
        private void Limpiar()
        {
            txt_IdentificacionF5.Clear();
            txt_nombrebomberoF5.Clear();
            txt_apellidobomberoF5.Clear();
            txt_dniF5.Clear();
            txt_codigobomberoF5.Clear();
            txt_Contraseña.Clear();
            txt_codigobomberoF5.Clear();
            btn_agregarbomberoF5.Enabled = true;
            btn_editarbomberoF5.Enabled = false;
            btn_eliminarbomberoF5.Enabled = false;
            cmb_jerarquiabomberosF5.SelectedValue = 0;
            cmb_AreaBomberosF5.SelectedValue = 0;
            chbox_Admin.Checked = false;
            chkbox_activo.Checked = false;
        }
        private bool ValidarCampos()
        {
            var controlesValidar = new Dictionary<Control, string>
            {
                { txt_nombrebomberoF5, "El campo nombre es obligatorio y solo puede contener letras y espacios." },
                { txt_apellidobomberoF5, "El campo apellido es obligatorio y solo puede contener letras y espacios." },
                { txt_dniF5, "El campo DNI es obligatorio y debe ser un número que no supere los 12 caracteres." }
            };
            string soloLetrasEspacios = @"^[a-zA-ZáéíóúÁÉÍÓÚ\s]+$";

            foreach (var control in controlesValidar)
            {
                if (string.IsNullOrWhiteSpace(control.Key.Text))
                {
                    MessageBox.Show(control.Value, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (control.Key == txt_nombrebomberoF5 || control.Key == txt_apellidobomberoF5)
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(control.Key.Text, soloLetrasEspacios))
                    {
                        MessageBox.Show(control.Value, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                if (control.Key == txt_dniF5)
                {
                    if (!int.TryParse(control.Key.Text, out int dni))
                    {
                        MessageBox.Show(control.Value, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (control.Key.Text.Length >= 12)
                    {
                        MessageBox.Show("El campo DNI no debe superar los 12 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            if (!int.TryParse(txt_codigobomberoF5.Text, out int codBombero))
            {
                MessageBox.Show("El campo Número bombero debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (codBombero < 100 || codBombero > 999)
            {
                MessageBox.Show("El campo Número bombero debe estar entre 100 y 999.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar contraseña si es administrador
            if (chbox_Admin.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_Contraseña.Text))
                {
                    MessageBox.Show("El campo Contraseña es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void CargarComboBoxJerarquia()
        {
            using (SqlConnection con = new Conexion().GetConnection())
            {
                con.Open();
                string query = "SELECT ID_jerarquia, Nombre_jerarquia FROM Jerarquia";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_jerarquiabomberosF5.DataSource = dt;
                cmb_jerarquiabomberosF5.DisplayMember = "Nombre_jerarquia";
                cmb_jerarquiabomberosF5.ValueMember = "ID_jerarquia";
            }
        }
        private void CargarComboBoxArea()
        {
            using (SqlConnection con = new Conexion().GetConnection())
            {
                con.Open();
                string query = "SELECT ID_area, Nombre_area FROM Area";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_AreaBomberosF5.DataSource = null;
                cmb_AreaBomberosF5.DataSource = dt;
                cmb_AreaBomberosF5.DisplayMember = "Nombre_area";
                cmb_AreaBomberosF5.ValueMember = "ID_area";
            }
        }

        private string ObtenerContrasena(int idBombero)
        {
            using (SqlConnection con = new Conexion().GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Contrasena_bombero FROM Bombero WHERE ID_bombero = @ID_bombero", con);
                cmd.Parameters.AddWithValue("@ID_bombero", idBombero);

                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? result.ToString() : string.Empty;
            }
        }
        private void btn_atrasABM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_cuerpobomberosF5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_cuerpobomberosF5.Rows[e.RowIndex];
                txt_IdentificacionF5.Text = row.Cells["ID"].Value.ToString().Trim();
                txt_apellidobomberoF5.Text = row.Cells["Apellido"].Value?.ToString().Trim() ?? string.Empty;
                txt_nombrebomberoF5.Text = row.Cells["Nombre"].Value?.ToString().Trim() ?? string.Empty;
                txt_dniF5.Text = row.Cells["DNI"].Value?.ToString().Trim() ?? string.Empty;
                txt_codigobomberoF5.Text = row.Cells["Numero bombero"].Value.ToString().Trim();
                cmb_AreaBomberosF5.Text = row.Cells["area"].Value.ToString().Trim();
                cmb_jerarquiabomberosF5.Text = row.Cells["jerarquia"].Value.ToString().Trim();
                chbox_Admin.Checked = Convert.ToBoolean(row.Cells["Administrador"].Value);
                chkbox_activo.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);
                int idBombero = Convert.ToInt32(row.Cells["ID"].Value);
                txt_Contraseña.Text = ObtenerContrasena(idBombero).Trim();
                btn_agregarbomberoF5.Enabled = false;
                btn_editarbomberoF5.Enabled = true;
                btn_eliminarbomberoF5.Enabled = true;
                btn_atrasABM.Enabled = true;
            }
        }

        private void btn_agregarbomberoF5_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    Clases.BomberoABM bomberoABM = new Clases.BomberoABM();
                    bomberoABM.AgregarBombero(txt_apellidobomberoF5.Text, txt_nombrebomberoF5.Text, txt_dniF5.Text, int.Parse(txt_codigobomberoF5.Text), (int)cmb_jerarquiabomberosF5.SelectedValue, (int)cmb_AreaBomberosF5.SelectedValue, chbox_Admin.Checked, txt_Contraseña.Text, chkbox_activo.Checked);

                }
                catch (Exception ex)
                {
                }
                Actualizar();
                Limpiar();
            }
        }

        private void btn_editarbomberoF5_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    Clases.BomberoABM bomberoABM = new Clases.BomberoABM();
                    bomberoABM.ModificarBombero(int.Parse(txt_IdentificacionF5.Text), txt_apellidobomberoF5.Text, txt_nombrebomberoF5.Text, txt_dniF5.Text, int.Parse(txt_codigobomberoF5.Text), (int)cmb_jerarquiabomberosF5.SelectedValue, (int)cmb_AreaBomberosF5.SelectedValue, chbox_Admin.Checked, txt_Contraseña.Text, chkbox_activo.Checked);
                    Actualizar();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_eliminarbomberoF5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Clases.BomberoABM bomberoABM = new Clases.BomberoABM();
                bomberoABM.EliminarBombero(int.Parse(txt_IdentificacionF5.Text));
            }
        }

        private void btn_cancelarbomberoF5_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgv_cuerpobomberosF5_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelected = dgv_cuerpobomberosF5.SelectedRows.Count > 0;
            btn_editarbomberoF5.Enabled = isSelected;
            btn_eliminarbomberoF5.Enabled = isSelected;

            if (!isSelected)
            {
                btn_agregarbomberoF5.Enabled = true;
            }
        }

        private void chbox_Admin_CheckedChanged(object sender, EventArgs e)
        {
            txt_Contraseña.Enabled = chbox_Admin.Checked;
        }

        private void cmb_AreaBomberosF5_DropDown(object sender, EventArgs e)
        {
            CargarComboBoxArea();
        }
    }
}