using System.ComponentModel.DataAnnotations;

namespace Test_NANY.Data.ViewModels
{
    public class NanyViewModel
    {
        public int Nany_Id { get; set; }

        public string? Nany_Name { get; set; }


        public string? NAge { get; set; }

        public Gender NGender { get; set; }
      
        public Religion NReligion { get; set; }
       
        public string? NPhone { get; set; }
        public string? NAddress { get; set; }


    }
}
