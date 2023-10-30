using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Persistencia
{
    using Microsoft.EntityFrameworkCore;
    using PPAI_DSI.Entidades;
    using System;
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Estado> Estados { get; set; }
        // Otras DbSet para las demás entidades

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ppai.db"); // Cambia el nombre de la base de datos según tus necesidades
        }
    }

}
