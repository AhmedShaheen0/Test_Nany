using System.ComponentModel.DataAnnotations;

namespace Test_NANY.Data.Models
{
    public class NanyProfile
    {
        [Key]
        [Required(ErrorMessage = "Nany ID is Required.")]
        [Display(Name = "Nany Id")]
        public int Nany_Id { get; set; }




        [Required(ErrorMessage = "Nany Name Required.")]
        [Display(Name = "Nany Name")]
        public string Nany_Name { get; set; }


        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "Age")]
        public string NAge { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Display(Name = "NGender")]
        public Gender Gender { get; set; }


        [Required(ErrorMessage = "Religion is required")]
        [Display(Name = "NReligion")]
        public Religion Religion { get; set; }


        [Required]
        [Display(Name = "Phone Number")]
        public string NPhone { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string NAddress { get; set; }

    }
}
