using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_event_plus.Domains
{
    public class Usuarios
    {
        [Key]
        public Guid IdUsuario { get; set; }
        [ForeignKey("TipoUsuario")]
        public Guid IdTipoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
