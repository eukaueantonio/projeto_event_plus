using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projeto_event_plus.Domains
{
    [Table("ComentarioEvento")]
    public class ComentarioEvento
    {
        [Key]
        public Guid IdComentarioEvento { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A descrição do evento é obrigatória")]
        public string Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "A descrição do evento é obrigatória")]
        public bool Exibe { get; set; }


        public Guid IdUsuarios { get; set; }
        [ForeignKey("IdUsuarios")]
        public Usuarios? Usuarios { get; set; }


        public Guid IdEventos { get; set; }
        [ForeignKey("IdEventos")]
        public Eventos? Eventos { get; set; }
    }
}
