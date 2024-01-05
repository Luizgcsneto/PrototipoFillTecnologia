using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Entities.Entities
{
    [Table("Address")]
    public class Address : Base
    {
        [Display(Name = "Rua")]
        public string Street { get; set; }
        [Display(Name = "Rua")]
        public int Number { get; set; }
        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }
        [Display(Name = "Cidade")]
        public string City { get; set; }
        [Display(Name = "Estado")]
        public string State { get; set; }
        [Display(Name = "Pais")]
        public string Country { get; set; }

    }
}
