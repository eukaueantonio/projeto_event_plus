using System.ComponentModel.DataAnnotations;

namespace projeto_event_plus.Domains
{
    public class TiposUsuarios
    {
        [Key]
        public Guid IdTipoUsuario { get; set; }
        public string TituloTipoUsuario { get; set; }
    }
}
