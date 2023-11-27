using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace TimesCrud.Models
{
    public class Jogador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do jogadodor")]
        public string NomeJogador { get; set; }

        [Required(ErrorMessage = "Digite o time do jogadodor")]
        public string TimeJogador { get; set; }

        [Required(ErrorMessage = "Digite o número da camisa do jogadodor")]
        public string CamisaJogador { get; set; }
        public DateTime HoraJogo { get; set; } = DateTime.Now;
    }
}
