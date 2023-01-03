using System;
using System.ComponentModel.DataAnnotations;
using back_end.Data;
using Microsoft.EntityFrameworkCore;

namespace back_end.Models
{
    public class Poliza
    {
        [Key]
        public int IdPoliza { get; set; }
        public string DatosTomador { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaVencimientoPolizaActual { get; set; }
        public string PlacaAutomotor { get; set; } = string.Empty;
        public string CiudadVenta { get; set; } = string.Empty;

       
    }
}
