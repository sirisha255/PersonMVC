using System.ComponentModel.DataAnnotations;

namespace PersonMVC.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [Display(Name ="Person")]
        [Required]
        public string? Name { get; set; }
        [Required]
    
        public string? City { get; set; }
        [StringLength(80,MinimumLength =1)]
       
        public string? PhoneNumber { get; set; }
        [Required]

        public List<string> CityList
        {
            get
            {
                return new List<string>

                { "Malmo","Hesinborg","Amhult","Lund","vaxjo","gothenborg"};

            }
        }
    }
}
