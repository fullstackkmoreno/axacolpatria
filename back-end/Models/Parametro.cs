using System;
using System.ComponentModel.DataAnnotations;
using back_end.Data;
using Microsoft.EntityFrameworkCore;

namespace back_end.Models
{
    public class Parametro
    {
        [Key]
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;

       
    }
}
