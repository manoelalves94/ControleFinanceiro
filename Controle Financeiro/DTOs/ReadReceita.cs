namespace Controle_Financeiro.DTOs;

public class ReadReceita
{
    public Guid Id { get; set; }
    public string Descricao { get; set; }
    public double Valor { get; set; }
    public DateTime Data { get; set; }
}
