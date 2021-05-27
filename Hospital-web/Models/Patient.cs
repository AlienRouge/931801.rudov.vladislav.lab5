using System.ComponentModel.DataAnnotations;

namespace Hospital_web.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Diagnosis is required")]
        public string Diagnosis { get; set; }
    }
}