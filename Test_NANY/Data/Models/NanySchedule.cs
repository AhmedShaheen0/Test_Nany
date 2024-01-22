using System.ComponentModel.DataAnnotations;

namespace Test_NANY.Data.Models
{
    public class NanySchedule
    {
        [Key]
        [Required(ErrorMessage = "ID is Required.")]
        [Display(Name = " Schedule Id")]
        public int Schedule_Id { get; set; }

        [Required(ErrorMessage = "Shift ID is Required.")]
        [Display(Name = "Shift Id")]
        public int Shift_Id { get; set; }

        [Required(ErrorMessage = "Nany ID is Required.")]
        [Display(Name = "Nany Id")]
        public int Nany_Id { get; set; }

        [Required(ErrorMessage = "Child ID is Required.")]
        [Display(Name = "Child Id")]
        public int Child_Id { get; set; }




    }
}
