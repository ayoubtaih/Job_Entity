﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Job_Entity.Models
{
    public class Personne
    {
        [Key]
        public int id { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaissance { get; set; }
        public string genre { get; set; }
        public int tel { get; set; }
        public string ville { get; set; }
        public string pays { get; set; }
        public string competence { get; set; }

    }
}