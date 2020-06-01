using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Entity.Models
{
    public class Domaine
    {
        [Key]
        public int IDdomaine{ get; set; }
        public string Libelle{ get; set; }

        public virtual ICollection<Profession> Professions{ get; set; }
    }
}