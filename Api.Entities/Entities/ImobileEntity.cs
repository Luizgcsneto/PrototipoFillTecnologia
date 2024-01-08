using Api.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Entities.Entities
{
    [Table("Imobile")]
    public class ImobileEntity : BaseEntity
    {
        [Display(Name = "Titulo")]
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [Display(Name = "Bairro")]
        private string _district;
        public string District
        {
            get { return _district; }
            set { _district = value; }
        }

        [Display(Name = "Quantidade de Quartos")]
        private int _numberRooms;
        public int NumberRooms
        {
            get { return _numberRooms; }
            set { _numberRooms = value; }
        }
        [Display(Name = "Tipo de negócio")]
        private BusinessType _businessType;
        public BusinessType BusinessType
        {
            get { return _businessType; }
            set { _businessType = value; }
        }

        [Display(Name = "Valor")]
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
