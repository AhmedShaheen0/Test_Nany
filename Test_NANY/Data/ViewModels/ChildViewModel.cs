using System.ComponentModel.DataAnnotations;

namespace Test_NANY.Data.ViewModels
{
    public class ChildViewModel
    {
        public int Child_Id { get; set; }

        public string? Child_Name { get; set; }


        public string? Age { get; set; }

        public Gender Gender { get; set; }
      
        public Religion Religion { get; set; }
       
        public string? Phone { get; set; }
        public string? Address { get; set; }


    }
}
