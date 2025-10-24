using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaEntidad;
using CapaNegocio;

namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class VisorReporteV : Form
    {
        public VisorReporteV()
        {
            InitializeComponent();
        }

        private void VisorReporteV_Load(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Today;
            DateTime fin = DateTime.Now;

            // Configura el ReportEmbeddedResource aquí una sola vez, si no lo haces en el diseñador
            // Esto asegura que el ReportViewer sepa qué archivo RDLC usar.
            reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Ventas_Inventario_Papeleria.Reportes.ReporteVentas.rdlc";

            ObtenerReporteVentas(inicio, fin);
        }

        // ✅ Método principal para obtener y mostrar el reporte
        private void ObtenerReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                CN_ReporteVentas cnReporte = new CN_ReporteVentas();
                List<ReporteVentas> lista = cnReporte.ObtenerReporteVentas(fechaInicio, fechaFin);

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas en el rango seleccionado.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    // Limpiamos cualquier DataSource previo
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Ventas_Inventario_Papeleria.Reportes.ReporteVentas.rdlc";


                    ReportDataSource fuente = new ReportDataSource("reporteVentas", lista);

                   
                    reportViewer1.LocalReport.DataSources.Add(fuente);

                reportViewer1.RefreshReport();

                ReportParameter[] parametros = new ReportParameter[]
                {
                    new ReportParameter("pFechaInicio", fechaInicio.ToShortDateString()),
                    new ReportParameter("pFechaFin", fechaFin.ToShortDateString()),
                    new ReportParameter("pFechaGeneracion", DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                };
                reportViewer1.LocalReport.SetParameters(parametros);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Botón hoy
        private void btn_hoy_Click(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Today;
            DateTime fin = DateTime.Now;
            ObtenerReporteVentas(inicio, fin);
        }

        // ✅ Botón últimos 7 días
        private void btn_7dias_Click(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Today.AddDays(-7);
            DateTime fin = DateTime.Now;
            ObtenerReporteVentas(inicio, fin);
        }

        // ✅ Botón este mes
        private void btn_mes_Click(object sender, EventArgs e)
        {
            DateTime inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fin = DateTime.Now;
            ObtenerReporteVentas(inicio, fin);
        }

        // ✅ Botón este año
        private void btn_año_Click(object sender, EventArgs e)
        {
            DateTime inicio = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime fin = DateTime.Now;
            ObtenerReporteVentas(inicio, fin);
        }

        // ✅ Botón personalizado
        private void btn_personalizar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dateTimePickerFrm.Value.Date;
            DateTime fin = dateTimePickerFrm2.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            ObtenerReporteVentas(inicio, fin);
        }

        // ✅ Botón guardar (si quieres exportar o guardar PDF)
        private void btn_guardarRV_Click(object sender, EventArgs e)
        {
            // Ejemplo simple: exportar a PDF
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "ReporteVentas.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                byte[] bytes = reportViewer1.LocalReport.Render(format: "PDF");
                System.IO.File.WriteAllBytes(sfd.FileName, bytes);
                MessageBox.Show("Reporte guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
