using Microsoft.EntityFrameworkCore;

namespace Turnos.Models
{
    public class TurnosContext : DbContext
    {
        public TurnosContext(DbContext<TurnosContext> opciones)
        : base(opciones)
        {

        }
        public DbSet<Especialidad> Especialidad { get; set; }
    }
}