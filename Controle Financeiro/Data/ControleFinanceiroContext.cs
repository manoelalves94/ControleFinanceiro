using Controle_Financeiro.Models;
using Microsoft.EntityFrameworkCore;

namespace Controle_Financeiro.Data;

public class ControleFinanceiroContext : DbContext
{
    public ControleFinanceiroContext(DbContextOptions<ControleFinanceiroContext> opts) : base(opts)
    {
        
    }

    public DbSet<Receita> Receitas { get; set; }
    public DbSet<Despesa> Despesas { get; set; }
}
