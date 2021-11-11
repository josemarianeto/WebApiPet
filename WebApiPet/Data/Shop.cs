using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApiPet.Controllers;
using WebApiPet.Data;

namespace WebApiPet.Data
{
    public class Shop
    {
        [Key]
        public int shopId { get; set; }
        public string razaoSocial { get; set; }
        public int cnpj { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        [ForeignKey("Users")]
        public int userID { get; set; }
        public virtual Users user { get; set; }

    }
}
