using Microsoft.EntityFrameworkCore;

namespace GestionNote.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Etudiant> Etudiant { get; set; }
        public DbSet<Matieres> Matieres { get; set; }
        public DbSet<Notes> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opbuilder)
        {
            opbuilder.UseSqlServer("Data Source=PC06\\SQLEXPRESS;Initial Catalog=GestionNote;Integrated Security=True; Encrypt=False");
        }
    }


}
