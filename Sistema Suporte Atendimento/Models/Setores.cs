using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Suporte_Atendimento.Models;

[Table("Setores")]
public class Setores
{
    [Key]
    [Required]
    public int SetoresId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Nome { get; set; }
}