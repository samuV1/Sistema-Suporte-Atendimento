using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Suporte_Atendimento.Models
{
    [Table("Ordem de Servicos")]
    public class OrdemServicos
    {
        [Key]
        [Required]
        public int OrdemServicosId { get; set; }

        [Required]
        [Display(Name = "Serviço")]
        [MaxLength(50)]
        public string Servico { get; set; }

        [Display(Name = "Subserviço")]
        [MaxLength(70)]
        public string Subservico { get; set; }

        [Required]
        [Display(Name = "Descriçao")]
        [MaxLength(1000)]
        public string Descricao { get; set; }

        [Display(Name = "Notas")]
        [MaxLength(5000)]
        public string Notas { get; set; }

        [Display(Name = "Status")]
        [MaxLength(50)]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Contato")]
        [MaxLength(50)]
        public string Contato { get; set; }

        [Display(Name = "Url do arquivo")]
        [MaxLength(50)]
        public string Arquivo { get; set; }

        [Required]
        [Display(Name = "Abertura")]
        public DateTime Abertura { get; set; }

        [Required]
        [Display(Name = "Fechamento")]
        public DateTime Fechamento { get; set; }

        [Display(Name = "Recebimento")]
        public DateTime Recebimento { get; set; }

        [Required]
        [Display(Name = "ANS")]
        public DateTime ANS { get; set; }

        [Display(Name = "Urgência")]
        public int Urgencia { get; set; }

        [Required]
        [Display(Name = "Fila")]
        [MaxLength(50)]
        public string Fila { get; set; }
    }
}