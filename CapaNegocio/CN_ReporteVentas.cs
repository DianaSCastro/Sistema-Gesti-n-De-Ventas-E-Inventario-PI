using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ReporteVentas
    {
        private CD_ReporteVentas objCDReporte = new CD_ReporteVentas();

        public List<ReporteVentas> ObtenerReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                var lista = objCDReporte.ObtenerReporteVentas(fechaInicio, fechaFin); // trae ventas filtradas por rango

                // Asignar fechas a cada registro para el RDLC
                foreach (var item in lista)
                {
                   item.FechaInicioPeriodo = fechaInicio;
                    item.FechaFinPeriodo = fechaFin;
                    item.FechaReporte = DateTime.Now;
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al obtener el reporte de ventas: " + ex.Message);
            }
        }

    }
}