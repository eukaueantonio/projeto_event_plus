using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_event_plus.Domains
{
    [Table("Eventos")]
    public class Eventos
    {
        [Key]
        public Guid IdEvento { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data do evento é obrigatória")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do evento é obrigatório")]
        public string? NomeEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição do evento é obrigatória")]
        public string? Descricao { get; set; }

        public Guid IdTiposEventos { get; set; }
        [ForeignKey("IdTiposEventos")]
        public TiposEventos? TiposEvento { get; set; }

        public Guid IdInstituicoes { get; set; }

        [ForeignKey("IdInstituicoes")]
        public Instituicoes? Instituicoes { get; set; }

    }
}
