using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LernMVC_September.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Produkt Name")]
        public string ProductName { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Beschreibung")]
        public string Description { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Hersteller")]
        public string Producer { get; set; }



    }
}
