using System.ComponentModel.DataAnnotations;

namespace DevotionNote.Models;

public class Anotacoes
{
    [Key]
    public int AnotacaoId { get; set; }
    public string Anotacao { get; set; }
}