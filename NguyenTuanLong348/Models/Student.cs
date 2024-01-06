using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetMVC.Models
{
    public class Student 
    {
        [Required(ErrorMessage = "Vui long nhap Student id")]
        public string StudentID { get; set; }
        public string HoTen { get; set; }
        public string PersonID { get; set; }
        [ForeignKey("PersonID")]
        public Person? Person { get; set; }

    }
}