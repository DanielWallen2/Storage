using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Kategori")]
        public Category Category { get; set; }

        [Display(Name = "Pris")]
        public int Price { get; set; }

        [Display(Name = "Antal")]
        public int Count { get; set; }

        [Display(Name = "Lager Värde")]
        public int InventoryValue { get; set; }

    }

    //public class TestViewModel
    //{
    //    public IEnumerable<ProductViewModel> Products { get; set; }
    //    public int TotalValue { get; set; }
    //}
}
