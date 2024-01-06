using Api.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Entities.Entities
{
    [Table("Imobile")]
    public class ImobileEntity : BaseEntity
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
        [Display(Name = "Endereço")]
        public AddressEntity Address { get; set; }

    }
}
