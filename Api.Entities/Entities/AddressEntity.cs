using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Entities.Entities
{
    [Table("Address")]
    public class AddressEntity : BaseEntity
    {
        [Display(Name = "Rua")]
        private string _street;
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        [Display(Name = "Número")]
        private int _number;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        [Display(Name = "Bairro")]
        private string _neighborhood;
        public string Neighborhood
        {
            get { return _neighborhood; }
            set { _neighborhood = value; }
        }

        [Display(Name = "Cidade")]
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        [Display(Name = "Estado")]
        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        [Display(Name = "Pais")]
        private string _country;
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

    }
}
