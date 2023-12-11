using System.ComponentModel.DataAnnotations;

namespace Controle_Financeiro.Models;

public class Receita
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Descricao { get; set; }
    [Required]
    [Range(0.01, int.MaxValue)]
    public double Valor { get; set; }
    [Required]
    public DateTime Data { get; set; }
}
