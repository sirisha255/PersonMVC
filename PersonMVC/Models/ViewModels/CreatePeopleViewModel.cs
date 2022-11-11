using System.ComponentModel.DataAnnotations;

namespace PersonMVC.Models.ViewModels
{
    public class CreatePeopleViewModel
    {
        [Display(Name ="People")]
        [Required]
        public string? Name { get; set; }
        [Required]
    
        public string? CityName { get; set; }
        [StringLength(80,MinimumLength =1)]
        [Required]
        public int PhoneNumber { get; set; }

        public List<string> CityNameList
        {
            get
            {
                return new List<string>

                { "Malmo","Hesinborg","Amhult","Lund","vaxjo","gothenborg"};

            }
        }
    }
}
