using System.ComponentModel.DataAnnotations;

namespace Api.Entities.Entities
{
    public class Base
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
