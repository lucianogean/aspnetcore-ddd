using System.ComponentModel.DataAnnotations;

namespace TesteCadastro.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        [Required(ErrorMessage="O nome é obrigatório")]
        [Display(Name = "Nome completo")]
        [MaxLength(150, ErrorMessage = "Valor máximo é 150")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O CNPJ/CPF é obrigatório")]
        [Display(Name = "CNPJ/CPF")]
        [MaxLength(100, ErrorMessage = "Valor máximo é 100")]
        public string CnpjCpf { get; set; }
        [Display(Name = "Endereço completo")]
        public string Endereco { get; set; }
    }
}
