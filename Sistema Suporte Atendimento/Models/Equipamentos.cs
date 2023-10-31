using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Suporte_Atendimento.Models;

[Table("Equipamentos")]
public class Equipamentos
{
    [Key]
    [Required]
    [Display(Name = "Patrimônio")]
    public int EquipamentosId { get; set; }

    [Required]
    [Display(Name = "Tipo")]
    [MaxLength(50)]
    public string Tipo { get; set; }

    [Required]
    [Display(Name = "Marca")]
    [MaxLength(50)]
    public string Marca { get; set; }

    [Required]
    [Display(Name = "Modelo")]
    [MaxLength(50)]
    public string Modelo { get; set; }

}