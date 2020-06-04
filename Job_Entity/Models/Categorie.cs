using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Entity.Models
{
    public class Categorie
    {
        [Key]
        public int idCat { get; set; } 
        
        public virtual ICollection<Profession> Professions { set; get; }
    }
}