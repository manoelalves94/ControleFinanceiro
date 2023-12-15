namespace Controle_Financeiro.DTOs;

public class ReadReceitaDto
{
    public Guid Id { get; set; }
    public string Descricao { get; set; }
    public double Valor { get; set; }
    public string Data { get; set; }
}
