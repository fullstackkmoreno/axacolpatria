using back_end.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections.Generic;

namespace back_end.Data
{
    public class ParametroContexto : DbContext
    {

        public ParametroContexto(DbContextOptions<ParametroContexto> options) : base(options)
        {
        }



        public DbSet<Parametro> Parametro { get; set; } = null;

    }
}