using back_end.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections.Generic;

namespace back_end.Data
{
    public class PolizaContexto : DbContext
    {

        public PolizaContexto(DbContextOptions<PolizaContexto> options) : base(options)
        {
        }



        public DbSet<Poliza> Poliza { get; set; }

    }
}