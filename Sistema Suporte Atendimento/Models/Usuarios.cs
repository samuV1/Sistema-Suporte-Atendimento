using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Suporte_Atendimento.Models;

[Table("Usuarios")] 
public class Usuarios
{
    [Key]
    [Required]
    public int UsuariosId { get; set; }

    [Required]
    [Display(Name = "Nome")]
    [MaxLength(255)]
    public string Nome { get; set; }

    [Required]
    [Display(Name = "Usuário Administrador?")]
    public bool Admministrador { get; set; }

    [Required]
    public int NivelAcesso { get; set; }
}