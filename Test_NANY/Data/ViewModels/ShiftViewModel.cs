using System.ComponentModel.DataAnnotations;

namespace Test_NANY.Data.ViewModels
{
    public class ShiftViewModel
    {
       public int Shift_Id { get; set; }

         public DateTime? Start_datetime { get; set; }

           public DateTime? End_datetime { get; set; }

      public string shift_No { get; set; }

        public string shift_Type { get; set; }

    }
}
