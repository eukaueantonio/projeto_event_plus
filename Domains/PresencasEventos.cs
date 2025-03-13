using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_event_plus.Domains
{
    public class PresencasEventos
    {
        [Key]
        public Guid IdPresenca { get; set; }
        [ForeignKey("Usuario")]
        public Guid IdUsuario { get; set; }
        [ForeignKey("Evento")]
        public Guid IdEvento { get; set; }
        public Guid Situacao { get; set; }
    }
}
