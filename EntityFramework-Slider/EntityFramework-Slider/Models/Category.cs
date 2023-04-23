using System.ComponentModel.DataAnnotations;

namespace EntityFramework_Slider.Models
{
    public class Category:BaseEntity
    {
        [Required(ErrorMessage ="Dont be empty")]
        [StringLength(10,ErrorMessage ="The name length must be 10 characters")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
