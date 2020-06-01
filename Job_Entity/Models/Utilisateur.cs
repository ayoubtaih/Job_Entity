using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Job_Entity.Models
{
    public class Utilisateur
    {
        [Key]
        [ForeignKey("Personne")]
        public int IDUtilisateur{ get; set; }
        public string Login { get; set; }
        public string MotPasse{ get; set; }
        public DateTime DernierVisit { get; set; }

       
        public virtual Personne Personne{ get; set; }
    }
}