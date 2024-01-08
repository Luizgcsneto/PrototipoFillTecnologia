using System.ComponentModel.DataAnnotations;

namespace Api.Entities.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        private DateTime? _createAt;
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }
    }
}
