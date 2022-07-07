using System;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    #nullable disable
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Namn")]
        [StringLength(20, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Kategori")]
        public Category Category { get; set; }

        [Display(Name = "Hyllplats")]
        public string Shelf { get; set; }

        [Display(Name = "Orderdatum")]
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required]
        [Display(Name = "Antal")]
        [Range(0, 999999)]
        public int Count { get; set; }

        [Display(Name = "Pris")]
        [Range(1, 10000)]
        public int Price { get; set; }

        [Display(Name = "Beskrivning")]
        public string Description { get; set; }
    }
}
