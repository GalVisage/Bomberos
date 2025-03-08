using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi.Clases;
using static System.Windows.Forms.DataFormats;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    public partial class frm_bombero : Form
    {
        Clases.ConexionConBD conectar = new Clases.ConexionConBD();
        Clases.BotonColorManager botonmanager = new BotonColorManager(Color.FromArgb(2, 21, 38));
        public frm_bombero()
        {
            InitializeComponent();
            lbl_fechabomb.Text = DateTime.Now.ToString("dd/MM/yyyy");

            this.pnl_nombreformbomb.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_nombrebombF2_Paint);
            this.pnl_codyareaformbomb.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_nombrebombF2_Paint);
            this.pnl_horaformbomb.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_nombrebombF2_Paint);
            this.pnl_cargaform.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_nombrebombF2_Paint);
            botonmanager.RegistrarTodosLosBotones(pnl_listabomb);
        }
        private void btn_regtarea_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_tareas>(pnl_cargaform);
        }

        private void pnl_nombrebombF2_Paint(object? sender, PaintEventArgs e)
        {
            Clases.BordesRedondeados.Aplicar(pnl_nombreformbomb, 30, e);
            Clases.BordesRedondeados.Aplicar(pnl_codyareaformbomb, 30, e);
            Clases.BordesRedondeados.Aplicar(pnl_horaformbomb, 30, e);
            Clases.BordesRedondeados.Aplicar(pnl_cargaform, 30, e);
        }

        private void btn_entradaF2_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_ingresosalida>(pnl_cargaform);
        }

        private void btn_modoemergencia_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_emergencia>(pnl_cargaform);
        }

        private void btn_regreunionesbomb_Click(object sender, EventArgs e)
        {
            GestorFormularios.CargarFormularioEnPanel<frm_reuniones>(pnl_cargaform);
        }

        private void frm_bombero_Load(object sender, EventArgs e)
        {
            timer_fechahorabomb.Start();

        }

        private void timer_fechahorabomb_Tick(object sender, EventArgs e)
        {
            lbl_horabomb.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_adminstrador_Click(object sender, EventArgs e)
        {
            if (pnl_contenedoradm.Visible == true)
                pnl_contenedoradm.Visible = false;
            else
                pnl_contenedoradm.Visible = true;
        }

        private void btn_aceptarcontr_Click(object sender, EventArgs e)
        {
            BomberoDataAccess bomberoDataAccess = new BomberoDataAccess();
            Bombero bombero = bomberoDataAccess.ObtenerDatosBomberoPorCodigo(Convert.ToInt32(this.txt_codbombero.Text));
            if (txt_contraseñadm.Text.Length > 0 && txt_contraseñadm.Text == "12")
            {
                frm_administrador FormAdm = new frm_administrador();
                FormAdm.lbl_cargobomberoformadm.Text = bombero.Jerarquia;
                FormAdm.lbl_nombreFA.Text = bombero.Nombre + ", " + bombero.Apellido;
                FormAdm.lbl_areaFA.Text = bombero.Area;
                FormAdm.Show();
            }
        }

        private void btn_aceptarcod_Click(object sender, EventArgs e)
        {
            // Intentar convertir el texto a int y verificar la longitud del texto
            if (int.TryParse(txt_codbombero.Text.Trim(), out int codBombero) && txt_codbombero.Text.Trim().Length == 3)
            {
                // Crear una instancia para acceder a los datos del bombero
                BomberoDataAccess bomberoDataAccess = new BomberoDataAccess();
                Bombero bombero = bomberoDataAccess.ObtenerDatosBomberoPorCodigo(codBombero);
                
                if (bombero != null)
                {
                    lbl_nombrebomberoF2.Text = bombero.Nombre + ", " + bombero.Apellido;
                    lbl_cargobomberoF2.Text = bombero.Jerarquia;
                    lbl_areatrabajoF2.Text = bombero.Area;
                    IDBombero = Convert.ToInt32(bombero.ID);

                    lbl_bienvenidobomberoF2.Visible = true;
                    lbl_areaactual.Visible = true;
                    btn_entradasalida.Visible = true;
                    btn_regtarea.Visible = true;
                    btn_regreunionesbomb.Visible = true;
                    btn_modoemergencia.Visible = true;
                    btn_adminstrador.Visible = true;
                    GestorFormularios.CargarFormularioEnPanel<frm_ingresosalida>(pnl_cargaform);
                }
                else
                {
                    MessageBox.Show("No existe el codigo ingresado");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código válido.");
            }
        }
    }
}
