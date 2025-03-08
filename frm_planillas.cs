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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;

namespace ProyectoBVSV_Visgarra_Godino_Da_Silva_Diaz_Orlandi
{
    public partial class frm_planillas : Form
    {
        Clases.ConexionConBD conectar = new Clases.ConexionConBD();
        public frm_planillas()
        {
            InitializeComponent();
        }

        public void ActualizarPlanilla()
        {
            dgv_planillas.DataSource = null;
            dgv_planillas.Rows.Clear();

            DataTable tabla = new DataTable();

            string consultaplani = Datos.VariableY;
            if (string.IsNullOrEmpty(consultaplani))
            {
                MessageBox.Show("La consulta está vacía. Verifique el valor de Datos.VariableY.");
                return;
            }
            try
            {
                tabla.Load(conectar.Leer(consultaplani));
                //MessageBox.Show($"Filas cargadas: {tabla.Rows.Count}");// esto es para chequear funcionalidad
                dgv_planillas.DataSource = tabla;
                dgv_planillas.Refresh();
                dgv_planillas.ClearSelection();
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
        private void btn_atrasplanillas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_planillas_Load(object sender, EventArgs e)
        {
            ActualizarPlanilla();
        }

        //private void ExportarAHTML(DataGridView dataGridView)
        //{
        //    // Configuración del diálogo para guardar el archivo
        //    SaveFileDialog saveFileDialog = new SaveFileDialog
        //    {
        //        Filter = "HTML files (*.html)|*.html",
        //        FileName = "Reporte_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".html"
        //    };

        //    if (saveFileDialog.ShowDialog() != DialogResult.OK)
        //        return;

        //    // Creación del HTML
        //    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
        //    {
        //        writer.WriteLine("<html>");
        //        writer.WriteLine("<head>");
        //        writer.WriteLine("<style>");
        //        writer.WriteLine("table { width: 100%; border-collapse: collapse; }");
        //        writer.WriteLine("th, td { border: 1px solid black; padding: 8px; text-align: center; }");
        //        writer.WriteLine("th { background-color: #f2f2f2; }");
        //        writer.WriteLine("</style>");
        //        writer.WriteLine("</head>");
        //        writer.WriteLine("<body>");
        //        writer.WriteLine("<h2 style='text-align:center;'>Reporte de Datos</h2>");
        //        writer.WriteLine("<table>");
        //        writer.WriteLine("<tr>");

        //        // Agregar encabezados de columna
        //        foreach (DataGridViewColumn column in dataGridView.Columns)
        //        {
        //            writer.WriteLine($"<th>{column.HeaderText}</th>");
        //        }
        //        writer.WriteLine("</tr>");

        //        // Agregar las filas de datos
        //        foreach (DataGridViewRow row in dataGridView.Rows)
        //        {
        //            if (!row.IsNewRow)
        //            {
        //                writer.WriteLine("<tr>");
        //                foreach (DataGridViewCell cell in row.Cells)
        //                {
        //                    writer.WriteLine($"<td>{cell.Value?.ToString() ?? ""}</td>");
        //                }
        //                writer.WriteLine("</tr>");
        //            }
        //        }

        //        writer.WriteLine("</table>");
        //        writer.WriteLine("</body>");
        //        writer.WriteLine("</html>");
        //    }

        //    MessageBox.Show("Archivo HTML generado correctamente en " + saveFileDialog.FileName);

        //    // Abrir el archivo HTML en el navegador predeterminado
        //    try
        //    {
        //        System.Diagnostics.Process.Start("explorer", saveFileDialog.FileName);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo abrir el archivo HTML en el navegador: " + ex.Message);
        //    }
        //}

        private void ExportarAPDF(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "Reporte_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            Document pdfDoc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);

            try
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Título del documento
                    Paragraph title = new Paragraph("Reporte de Datos", FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD));
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    // Espacio después del título
                    pdfDoc.Add(new Paragraph(" "));

                    // Crear una tabla en el PDF con el mismo número de columnas que el DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                    // Estilo para el encabezado de la tabla
                    iTextSharp.text.Font headerFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD);
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, headerFont))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240),
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            Padding = 5
                        };
                        pdfTable.AddCell(headerCell);
                    }

                    // Estilo para las celdas de datos
                    iTextSharp.text.Font cellFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell dataCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", cellFont))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    Padding = 5
                                };
                                pdfTable.AddCell(dataCell);
                            }
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF generado correctamente en " + saveFileDialog.FileName);

                // Abrir el PDF para visualización
                System.Diagnostics.Process.Start("explorer", saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }
        private void btn_descarplanilla_Click(object sender, EventArgs e)
        {
            ExportarAPDF(dgv_planillas);
        }
    }
}
