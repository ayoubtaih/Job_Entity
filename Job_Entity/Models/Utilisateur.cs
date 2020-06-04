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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDUtilisateur{get; set;}

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email {get; set;}

        [DataType(DataType.Password)]
        public string mdp{get; set;}

        public string UserType { get; set; }

        [DataType(DataType.Date)]
        public DateTime DernierVisit {get; set;}

    }
}