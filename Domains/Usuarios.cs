using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_event_plus.Domains
{
    [Table("Usuarios")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuarios
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string? NomeUsuario { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string? Email { get; set; }

        [Column(TypeName ="VARCHAR(60)")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres e no máximo 60")]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "O tipo do usuário é obrigatório")]
        public Guid IdTiposUsuarios { get; set; }
        
        [ForeignKey("IdTiposUsuarios")]
        public TiposUsuarios? TiposUsuarios { get; set; }
    }
}
