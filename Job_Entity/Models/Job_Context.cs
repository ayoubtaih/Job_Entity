using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Job_Entity.Models
{
    public class Job_Context:DbContext
    {
        public Job_Context() : base("JobFjib")
        {

        }
        public DbSet<Utilisateur> Utilisateurs{ get; set; }
        public DbSet<Personne> Personnes{ get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Categorie> Categories{ get; set; }

        //Supperimer la Letter 'S' a la fin de le nom de tableua 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}