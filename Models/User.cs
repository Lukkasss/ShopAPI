using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models
{
    public class User
    {
        [Key]
        public long Id {get; set;}

        [MinLength(3)]
        [MaxLength(20)]
        public string Username {get; set;}
        
        [MinLength(3)]
        [MaxLength(20)]
        public string Password {get; set;}

        public string Role {get; set;}

    }
}