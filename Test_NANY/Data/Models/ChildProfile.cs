using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Test_NANY.Data.Models
{
    public class ChildProfile
    {
        [Key]
        [Required(ErrorMessage = "Child ID is Required.")]
        [Display(Name = "Child Id")]
        public int Child_Id { get; set; }

        [Required(ErrorMessage = "Child Name Required.")]
        [Display(Name = "Child Name")]
        public string Child_Name { get; set; }


        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "Age")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Religion is required")]
        [Display(Name = "Religion")]
        public string Religion { get; set; }
      [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

       
    }
}
