using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaCursosContext: DbContext
    {
        private const string connectionString = @"Data Source=192.168.1.100; Database=CursoOnline; User ID=sa;Password=Yemago83";

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ){
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Precio> Precio { get; set; }
        // public DbSet<Comentario> Comentario { get; set; }
    }
}