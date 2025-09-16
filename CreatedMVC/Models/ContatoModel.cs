using System.ComponentModel.DataAnnotations;

namespace CreatedMVC.Models
{
    public class ContatoModel
    {
        public int id { get; set; }
        [Required(ErrorMessage ="O campo nome é obrigatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O e-mail inserido não é válido.")]
        [EmailAddress(ErrorMessage = "O email informado não é valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Numero não definido")]
        [Phone(ErrorMessage = "O telefone inserido não é válido.")]
        public string tel { get; set; }
    }
}
