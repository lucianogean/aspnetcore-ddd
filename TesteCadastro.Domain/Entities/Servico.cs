using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteCadastro.Domain.Entities
{
    public class Servico : BaseEntity
    {
        [Required(ErrorMessage = "O Descrição é obrigatório")]
        [Display(Name = "Descrição do serviço")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O Data é obrigatório")]
        [Display(Name = "Data de atendimento")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "O Valor é obrigatório")]
        [Display(Name = "Valor do serviço")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O Tipo é obrigatório")]
        [Display(Name = "Tipo de serviço")]
        public int TipoServicoId { get; set; }

        [ForeignKey("TipoServicoId")]
        public TipoServico TipoServico { get; set; }


        [Display(Name = "Número da nota fiscal")]
        public string NumeroNota { get; set; }
        [Display(Name = "Tempo para execução")]
        public string Tempo { get; set; }

        
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        public int PrestadorId { get; set; }

        [ForeignKey("PrestadorId")]
        public Prestador Prestador { get; set; }
    }
}
