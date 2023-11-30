using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroDeLivros.Models
{
    public class Livro
    {
        [Key]
        public int LivroID { get; set; }
        [Required]
        [StringLength(255)]
        public string? Nome { get; set; }
        public string? Autores { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public string? AnoPublicacao { get; set; }
        public string? Idioma { get; set; }
        public int NumeroPaginas { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
    }
}
