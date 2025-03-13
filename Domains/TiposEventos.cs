using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_event_plus.Domains
{
    [Table("TiposEventos")]
    public class TiposEventos
    {
        [Key]
        public Guid IdTiposEventos { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O título do tipo do evento é obrigatório")]

        public string? TituloTipoEvento { get; set; }
    }
}
