using System.ComponentModel.DataAnnotations;

namespace Test_NANY.Data.Models
{
    public class Shift
    {
        [Key]
        [Required(ErrorMessage = "Shift ID is Required.")]
        [Display(Name = "Shift Id")]
        public int Shift_Id { get; set; }

        [Required]
        [Display(Name = "Start Date-Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy:MM:dd: HH:mm}")]
        public DateTime? Start_datetime { get; set; }

        [Required]
        [Display(Name = "End Date-Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy:MM:dd: HH:mm}")]
        public DateTime? End_datetime { get; set; }

        [Required]
        [Display(Name = "Shift No")]
        public string shift_No { get; set; }

        [Required]
        [Display(Name = "Shift Type")]
        public string shift_Type { get; set; }

    }
}
