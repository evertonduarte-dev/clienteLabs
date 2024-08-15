using System.ComponentModel.DataAnnotations;

namespace ClienteLabs.Models
{
    public class Login
    {
        [Key]
        public string CPFCNPJ { get; set; }           
        public virtual Cliente Cliente { get; set; }

        [StringLength(15, MinimumLength = 8, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Senha { get; set; }
        
        public bool Bloqueado { get; set; }

        public Login()
        {
        }

        public Login(string cPFCNPJ, Cliente cliente, string senha, bool bloqueado)
        {
            CPFCNPJ = cPFCNPJ;
            Cliente = cliente;
            Senha = senha;
            Bloqueado = bloqueado;
        }
    }
}
