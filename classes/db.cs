using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_hotelier.classes
{
    public class db : DbContext
    {
        public db() : 
            base("name=cnx1") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //throw new UnintentionalCodeFirstException();
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Chaine>().ToTable("chaine");
            modelBuilder.Entity<Categorie>().ToTable("categorie");
            modelBuilder.Entity<Chambre>().ToTable("chambre");
            modelBuilder.Entity<Nom>().ToTable("nom");
            modelBuilder.Entity<Client>().ToTable("client");
            modelBuilder.Entity<Reservation>().ToTable("reservation");
            modelBuilder.Entity<Service>().ToTable("service");
            modelBuilder.Entity<Archive>().ToTable("archive");



        }
        // void Add(Chambre chambres);


        public DbSet<Chaine> chaines { get; set; }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Chambre> chambres { get; set; }
        public DbSet<Nom> nom { get; set; }

        public DbSet<Client> clients { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Service> services{ get; set; }

        public DbSet<Archive> archives { get; set; }




    }
}
