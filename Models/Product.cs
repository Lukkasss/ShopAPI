using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models
{
    public class Product
    {
        [Key]
        public long Id {get; set;}

        [MinLength(3)]
        [MaxLength(60)]
        public string Title {get; set;}

        [MaxLength(1024)]
        public string Description {get; set;}

        [Range(1, 9999999999999.9)]
        public decimal Price {get; set;}

        public Category Category {get; set;}

    }
}