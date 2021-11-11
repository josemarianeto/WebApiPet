using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApiPet.Controllers;

namespace WebApiPet.Data
{
    public class Veterinario
    {
        [Key()]
        public int id { get; set; }

        public int crmv { get; set; }
        [ForeignKey("Users")]
        public int userid {get;set;}
        public virtual Users user { get; set; }
    }
}
