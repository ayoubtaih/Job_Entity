using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Entity.Models
{
    public class Personne
    {
        [Key]
        public int IDPersonne { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Genre { get; set; }
        public string Competence { get; set; }


        public virtual Utilisateur Utilisateur { get; set; }


        public virtual ICollection<Profession> Professions { set; get; }



    }
}