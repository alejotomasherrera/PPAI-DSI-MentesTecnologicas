using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PPAI_DSI.Entidades;

namespace PPAI_DSI
{
    public class ApplicationDbContext : DbContext

    {

        public DbSet<Llamada> Llamadas { get; set; }
        public DbSet<Encuesta> Encuestas { get; set; }
        public DbSet<Pregunta> Pregunta { get; set; }

        public DbSet<RespuestaDeCliente> RespuestaDeCliente { get; set; }

        public DbSet<RespuestaPosible> RespuestaPosible { get; set; }

        public DbSet<Estado> Estado { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<CambioEstado> CambiosEstado { get; set; }
        // Otras DbSet para las demás entidades
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Agregar la ruta de mi base de datos "ppai.db"
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\matias\\Desktop\\PPAI-DSI-MentesTecnologicas\\PPAI_DSI\\ppai.db"); // Cambia el nombre de la base de datos según tus necesidades
        }
    }

}
