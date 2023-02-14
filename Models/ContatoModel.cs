using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class ContatoModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
