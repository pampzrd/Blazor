using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DevotionNote.Models;

public class Versiculos
{
    [Key]
    public int IdVersiculos { get; set; }
    [Required(ErrorMessage = "Por favor, Adicione um versículo")]
    public string Versiculo { get; set; }
    
    public string palavrasChave { get; set; }
    [Required(ErrorMessage = "Por favor, adicione o Capítulo e Versículo de referência")]
    public string Referencia { get; set; }
    public DateTime? DataDeInclusao { get; set; }
    [ValidateNever]
    public Anotacoes Anotacoes { get; set; }
}