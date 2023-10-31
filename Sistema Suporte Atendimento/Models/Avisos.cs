using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Suporte_Atendimento.Models;

[Table ("Avisos")]
public class Avisos
{
    [Key]
    [Required]
    [Display(Name = "Número identificador")]
    public int AvisosId { get; set; }

    [Required]
    [Display(Name = "Assunto")]
    [MaxLength(50)]
    public string Assunto { get; set; }

    [Required]
    [Display(Name = "Descrição")]
    [MaxLength(1000)]
    public string Descricao { get; set; }
}