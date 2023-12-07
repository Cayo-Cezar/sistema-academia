using Microsoft.EntityFrameworkCore;
using WillFit_System.Models;

namespace WillFit_System.Data
{
    internal class GMYContext :DbContext
    {
        public DbSet<Alunos> Alunos { get; set; }

        //public DbSet<Address> Addresses { get; set; }

        public DbSet<Professores> Professores { get; set; }

        public DbSet<Treino> Treinos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=academiadb;User Id=sa;Password=1q2w3e4r!@#;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Treino>().HasKey(t => t.Id_treino);
        }
    }
}
