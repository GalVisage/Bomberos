using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi.Clases;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    public partial class frm_ingresosalida : Form
    {
        Clases.ConexionConBD conectar = new Clases.ConexionConBD();
        public frm_ingresosalida()
        {
            InitializeComponent();
        }

        public void Reiniciar()
        {
            foreach (Form frm_administrador in Application.OpenForms)
            {
                if (FormAdm == frm_administrador) // Compara el nombre del formulario
                {
                    FormAdm.Close(); // Cierra el formulario si está abierto
                    break; // Sale del bucle una vez encontrado y cerrado
                }
            }
            FormBomb.Close();
            FormBomb.Refresh();
        }
        private void btn_ingresobomb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Clases.IDBombero.ToString()))
            {
                MessageBox.Show("La consulta está vacía. Verifique el valor de Datos.VariableCod.");
                return;
            }
            try
            {
                Instante instante = new Instante();
                instante.MomentoInstante();
                int idFecha = instante.Idfechamomento;
                if (idFecha > 0)
                {

                    bool alta = conectar.ABM("INSERT INTO Asistencia_institucion (Puntaje, ID_bombero, ID_fecha, Minutos) VALUES ('0', " + Clases.IDBombero + ", " + idFecha + ", " + (int)Clases.Fecha.TimeOfDay.TotalMinutes + ");");
                    if (alta == true)
                    {
                        MessageBox.Show("Registro insertado correctamente.");
                        Reiniciar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el registro.Vuelva a internarlo correctamente.");
                        Reiniciar();
                    }
                }
                else
                {
                    MessageBox.Show("No se obtuvo un ID de fecha válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                // lbl_confirmacioningsal.Text = "Se registro correctamente tu entrada";
                conectar.Desconectar();
            }
        }

        private void pnl_btn_ing_sal_Paint(object sender, PaintEventArgs e)
        {
            Clases.BordesRedondeados.Aplicar(pnl_btn_ing_sal, 30, e);
        }

        private void btn__salidabomb_Click(object sender, EventArgs e)
        {
            DateTime fechaingreso = DateTime.MinValue; // Inicializar con un valor predeterminado
            DateTime fechasalida = DateTime.Now; // Asegúrate de que esta variable también esté inicializada
            SqlDataReader Ultimafecha = null;

            if (string.IsNullOrEmpty(Clases.IDBombero.ToString()))
            {
                MessageBox.Show("La consulta está vacía. Verifique el valor de Datos.VariableCod.");
                return;
            }

            try
            {
                //--------------- Obtener fecha inicial ------------------------
                string consulta = "SELECT TOP 1 Minutos, Fecha.Fecha_actual " +
                                  "FROM asistencia_institucion " +
                                  "INNER JOIN Fecha ON asistencia_institucion.ID_fecha = Fecha.ID_fecha " +
                                  "WHERE ID_bombero = " + Clases.IDBombero + " " +
                                  "ORDER BY Fecha_actual DESC;";

                try
                {
                    // Ejecutar la consulta y leer el resultado
                    Ultimafecha = conectar.Leer(consulta);

                    if (Ultimafecha != null && Ultimafecha.Read())
                    {
                        // Leer los valores de las columnas
                        fechaingreso = Ultimafecha.GetDateTime(Ultimafecha.GetOrdinal("Fecha_actual"));
                        int minutos = Ultimafecha.GetInt32(Ultimafecha.GetOrdinal("Minutos"));

                        // Mostrar los resultados
                        Console.WriteLine("Última fecha de ingreso: " + fechaingreso);
                        Console.WriteLine("Minutos: " + minutos);
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron registros para el ID de bombero especificado.");
                        return; // Salir si no se encuentran registros
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer los datos: " + ex.Message);
                    return; // Salir en caso de error
                }

                //-------------- Obtener punto  o los minutos ------------
                TimeSpan diferencia = fechasalida - fechaingreso;

                // Mostrar la diferencia para depuración
                int diferenciavalor = Convert.ToInt32(diferencia.TotalMinutes);
                Console.WriteLine("Diferencia en minutos: " + diferencia.TotalMinutes);

                if ( diferenciavalor > 59)
                {
                    bool alta = conectar.ABM("UPDATE Asistencia_institucion SET Puntaje = '1' WHERE ID_bombero = " + Clases.IDBombero + ";");
                    alta = conectar.ABM("UPDATE Asistencia_institucion SET Minutos = '0' WHERE ID_bombero = " + Clases.IDBombero + "; ");
                    MessageBox.Show("Registro insertado correctamente.");
                    Reiniciar();
                }

                else if (diferenciavalor < 60 && diferenciavalor > 0)
                {
                    bool alta = conectar.ABM("UPDATE Asistencia_institucion SET Puntaje = '0' WHERE ID_bombero = " + Clases.IDBombero + ";");
                    alta = conectar.ABM("UPDATE Asistencia_institucion SET Minutos = 0 WHERE ID_bombero = " + Clases.IDBombero + ";");
                    MessageBox.Show("Registro insertado correctamente.");//"No se pudo insertar el registro.Vuelva a intentarlo correctamente.");
                    Reiniciar();
                }
                //else if (diferencia.TotalMinutes == 0)
                //{
                //    bool alta = conectar.ABM("UPDATE Asistencia_institucion set (Puntaje = 'A', Minutos = 0) where Cod_bombero = " + Clases.IDBombero.ToString() + ";");
                //    MessageBox.Show("Registro insertado correctamente.");
                //    Reiniciar() ;
                //}
                else { MessageBox.Show("No se pudo insertar el registro.Vuelva a intentarlo correctamente."); Reiniciar(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                // Cerrar SqlDataReader y desconectar
                if (Ultimafecha != null && !Ultimafecha.IsClosed)
                    Ultimafecha.Close();
                conectar.Desconectar();
            }
        }

        private void btn_atrasingresosalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
