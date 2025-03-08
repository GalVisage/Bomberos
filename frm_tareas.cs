using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    public partial class frm_tareas : Form
    {
        Clases.ConexionConBD conectar = new Clases.ConexionConBD();
        DataTable tabla = new DataTable();
        frm_bombero Bomb = new frm_bombero();

        public frm_tareas()
        {
            InitializeComponent();
            Actualizar();
        }

        public void Limpiar()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = 0;
                if (c is System.Windows.Forms.CheckBox)
                    ((System.Windows.Forms.CheckBox)c).Checked = false;
            }
        }
        public void Actualizar()
        {
            tabla.Clear();
            tabla.Load(conectar.Leer(
                "SELECT Tarea.Descripcion_tarea AS Descripción, Tarea.Fecha_tarea AS Fecha, Tarea.Colaboracion_tarea AS '¿Colaboración?', Bombero.Apellido_bombero AS 'Apellido de Bombero', " +
                "Bombero.Nombre_bombero AS 'Nombre de Bombero', Area.Nombre_area AS 'Nombre de area' FROM Tarea INNER JOIN Bombero ON Tarea.ID_bombero = Bombero.ID_bombero INNER JOIN Area " +
                "ON Bombero.ID_area = Area.ID_area ORDER BY Tarea.Fecha_tarea;"
                ));

            dgv_tareasagregadas.DataSource = tabla;
            dgv_tareasagregadas.ClearSelection();
            conectar.Desconectar();
        }
        private void btn_enviartarea_Click(object sender, EventArgs e)
        {
            if (cmbox_selecarea.SelectedItem != null && !string.IsNullOrEmpty(txt_obstarea.Text))
            {
                try
                {
                    bool Alta = conectar.ABM(@"INSERT INTO Tarea(Descripcion_tarea, ID_area, Fecha_tarea, Punto_tarea, ID_bombero, " +
                    "Colaboracion_tarea) VALUES (@Descripcion, @IDArea, @Fecha, DEFAULT, @IDBombero, @Colaboracion)",
                    new Dictionary<string, object>
                    {
                        { "@Descripcion", txt_obstarea.Text.ToString() },
                        { "@IDArea", cmbox_selecarea.SelectedIndex },
                        { "@Fecha", Clases.Fecha },
                        { "@IDBombero", Clases.IDBombero},
                        { "@Colaboracion", chkbox_colaboracionF8.Checked ? 1 : 0 }
                    });

                    if (Alta == true)
                    {
                        MessageBox.Show("Registro insertado correctamente.");
                        Limpiar();
                        Actualizar();
                    }
                    else
                        MessageBox.Show("No se pudo insertar el registro.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el registro: " + ex.Message);
                }
            }
        }
        private void btn_cancelartarea_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
