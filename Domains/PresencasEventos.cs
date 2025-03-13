using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_event_plus.Domains
{
    [Table("PresencasEventos")]
    public class PresencasEventos
    {
        [Key]
        public Guid IdPresenca { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "A situação é obrigatória")]
        public bool Situacao { get; set; }

        public Guid IdUsuarios { get; set; }
        [ForeignKey("IdUsuarios")]
        public Usuarios? Usuarios { get; set; }

        public Guid IdEventos { get; set; }
        [ForeignKey("IdEventos")]
        public Eventos? Eventos { get; set; }

    }
}
