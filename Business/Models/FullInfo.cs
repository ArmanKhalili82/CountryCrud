using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CountryCrud.Models
{
    public class FullInfo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Country { get; set; }
        [MaxLength(30)]
        public string City { get; set; }
        public int Population { get; set; }
        [DisplayName("Capital")]
        public bool IsCapital { get; set; }
    }
}
