using System.ComponentModel.DataAnnotations;

namespace projeto_event_plus.Domains
{
    public class TiposEventos
    {
        [Key]
        public Guid IdTipoEvento { get; set; }
        public string TituloTipoEvento { get; set; }
    }
}
