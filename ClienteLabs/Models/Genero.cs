using System.ComponentModel.DataAnnotations;

namespace ClienteLabs.Models
{
    public class Genero
    {
        [Key]
        public int GeneroId { get; set; }

        public string Nome { get; set; }

        public Cliente Cliente { get; set; }

        public Genero()
        {
        }

        public Genero(int generoId, string nome, Cliente cliente)
        {
            GeneroId = generoId;
            Nome = nome;
            Cliente = cliente;
        }
    }
}
