using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Job_Entity.Models
{
    public class Profession
    {
        [Key]
        public int IDProfession{ get; set; }
        public string Libbele_Proffession { get; set; }
        public string Spesialite { get; set; }

        
        public virtual Categorie Categorie { get; set; }

        public virtual ICollection<Personne> Personnes { set; get; }

    }
}