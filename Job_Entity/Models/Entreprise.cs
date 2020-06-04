using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Job_Entity.Models
{
    public class Entreprise
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string adresse { get; set; }

        public string ville { get; set; }

        public string pays { get; set; }

        public int tel { get; set; }

        [ForeignKey("Categorie")]
        public int idCat { get; set; }

    }
}