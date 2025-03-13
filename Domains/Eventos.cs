using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_event_plus.Domains
{
    public class Eventos
    {
        [Key]
        public Guid IdEvent { get; set; }
        [ForeignKey("TipoEvento")]
        public Guid IdTipoEvento { get; set; }
        [ForeignKey("Instituicao")]
        public Guid IdInstituicao { get; set; }
        public DateTime DataEvento { get; set; }

        public string NomeEvento { get; set; }
        public string Descricao { get; set; }
    }
}
