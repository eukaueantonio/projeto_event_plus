using System.ComponentModel.DataAnnotations;

namespace projeto_event_plus.Domains
{
    public class Instituicoes
    {
        [Key]
        public Guid IdInstituicao { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string NomeFantasia { get; set; }
    }
}
