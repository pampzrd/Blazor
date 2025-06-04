namespace BancoCitacoes.Models;

public class BancoFrases
{
    
    //Atalho de Construtor ctor
    public BancoFrases(string citacoes,string autor,string tags)
    {
        
        Id = Guid.NewGuid();
        DataInclusao = DateTime.Now;
        Citacoes = citacoes;
        Autores = autor;
        Tags = tags;
    }

    public BancoFrases()
    {
        
    }
    
    public Guid Id { get; init; }
    public DateTime DataInclusao { get; set; }
    public string Citacoes { get; set; }
    public string Autores { get; set; }
    public string Tags { get; set; }
}