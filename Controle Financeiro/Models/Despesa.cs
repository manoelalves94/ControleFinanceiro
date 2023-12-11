using System.ComponentModel.DataAnnotations;

namespace Controle_Financeiro.Models;

public class Despesa
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Descricao { get; set; }
    [Required]
    public double Valor { get; set; }
    [Required]
    public DateTime Data { get; set; }
}
