using Api.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Api.Entities.Entities
{
    public class Imobile : Base
    {
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        
        [Display(Name = "Bairro")]
        public string District { get; set; }

        [Display(Name = "Quantidade de Quartos")]
        public int NumberRooms { get; set; }

        [Display(Name = "Tipo de negócio")]
        public BusinessType BusinessType { get; set; }
        [Display(Name = "Valor")]
        public decimal Price { get; set; }

        public Address Adress { get; set; }

    }
}
