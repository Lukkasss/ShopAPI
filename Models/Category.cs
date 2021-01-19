using System.ComponentModel.DataAnnotations;


namespace ShopAPI.Models 
{

    public class Category
    {
        [Key]
        public long Id {get; set;}
        
        [MaxLength(60)]
        [MinLength(2)]
        public string Title {get; set;}

    }


}