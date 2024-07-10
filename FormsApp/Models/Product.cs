using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {

        [Display(Name = "Id")]
        public int ProductId { get; set; }

        [Display(Name = "Name")]
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Display(Name = "Price")]
        [Required]
        [Range(0, 999999)]
        public decimal? Price { get; set; }

        [Display(Name = "Image")]
        //[StringLength(9999, ErrorMessage ="{0} length must be between {2} and {1}",MinimumLength =1)]
        public string Image { get; set; } = string.Empty ;
        public bool IsActive { get; set; }


        [Display(Name="Category")]
        [Required]
        public int? CategoryId { get; set; }
    }
}
