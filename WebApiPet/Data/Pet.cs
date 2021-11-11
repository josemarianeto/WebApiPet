using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApiPet.Controllers;

namespace WebApiPet.Data
{
    public class Pet
    {   [Key()]
        public int petid { get; set; }
        
        public string petNome { get; set; }
        public string raca { get; set; }
        public string peso { get; set; }
        public string altura { get; set; }
        public int idade { get; set; }
        public string tipo { get; set; }
        [ForeignKey("Users")]
        public int userid { get; set; }
        public virtual Users user { get; set; }

    }
}
