using ClienteLabs.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClienteLabs.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [Required(ErrorMessage = "O CPF/CNPJ deve ser informado")]
        [Display(Name = "CPF/CNPJ")]
        [StringLength(20, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string CPFCNPJ { get; set; }


        [Required(ErrorMessage = "O nome deve ser informado")]
        [Display(Name = "Nome/Razao Social")]
        [MaxLength(150, ErrorMessage = "Nome não pode exceder {1} caracteres")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "email invalido")]
        [Display(Name = "E-mail")]
        [MaxLength(150, ErrorMessage = "E-mail não pode exceder {1} caracteres")]
        public string Email { get; set; }


        
        [Display(Name = "Telefone")]
        [MaxLength(11, ErrorMessage = "Telefone não pode exceder {1} caracteres")]
        public string Telefone { get; set; }

        [Display(Name = "Tipo de Pessoa")]
        public string TipoPessoa { get; set; }

        [Display(Name = "Inscrição Estadual")]
        public int InscricaoEstadual { get; set; }

        [Display(Name = "Genero")]
        public ICollection<Genero> Genero { get; set; } = new List<Genero>();

        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [Display(Name = "Status")]
        public  ClienteStatus Status{ get; set; }

      

       
    }
}
