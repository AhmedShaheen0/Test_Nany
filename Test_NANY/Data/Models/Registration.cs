using System.ComponentModel.DataAnnotations;


namespace Test_NANY.Data.Models
{
    public class Registration
    {
        [Key]
        [Required(ErrorMessage = "User ID is Required.")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password.")]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string Pass { get; set; }

        [Required(ErrorMessage = "Confirm required password ")]
        [Display(Name = "Confirm Password.")]
        [Compare("Pass")]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string RePass { get; set; }

    }
}
