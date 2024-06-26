using Microsoft.EntityFrameworkCore;
public class Produto{
    public int ID { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=nomeDoSeuBanco.db");
    }
}