namespace WebApiDemo.Models;

using System.ComponentModel.DataAnnotations;
using WebApiDemo.Enums;
public class Post
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O Titulo é obrigatorio")]
    [MaxLength(50, ErrorMessage = "O tamanho do Titulo não pode exceder 50 caracteres")]
    public string Title { get; set; }
    [Required(ErrorMessage = "O Conteudo é obrigatorio")]
    public string Content { get; set; }
    [Required(ErrorMessage = "O Gênero é obrigatorio")]
    public Genre Genre { get; set; }
}
