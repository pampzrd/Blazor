using DevotionNote.Models;
using Microsoft.EntityFrameworkCore;

namespace DevotionNote.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
    { }

    public DbSet<Versiculos> Versiculo { get; set; }
    public DbSet<Anotacoes> Anotacao { get; set; }
}