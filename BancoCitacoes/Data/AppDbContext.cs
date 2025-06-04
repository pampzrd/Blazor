using BancoCitacoes.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoCitacoes.Data;

public class AppDbContext : DbContext
{
//A pasta DATA e o arquivo AppDbContext foi criado separado para lidar com o banco.
//Referenciar a Classe que quero representar no banco.
//Eu pego HERANÇA do DbContext
//Adiciono o Prop da classe do Banco.
    public DbSet<BancoFrases>  BancoFrases { get; set; }

    //chamo a função OnConfiguring e faço uma override com as strings de conexão do banco.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = bancofrases.sqlite");
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        base.OnConfiguring(optionsBuilder);
    }
}