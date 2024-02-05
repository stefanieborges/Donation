using System;
using System.ComponentModel.DataAnnotations;

namespace Donation.Models
{
    public class DoacaoModel
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Digite o nome da doação ")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Digite a URL da imagem ")]
        public string image { get; set; }
        [Required(ErrorMessage = "Digite a descrição")]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Digite um valor razoável ou gratuito ")]
        public string valor { get; set; }
        [Required(ErrorMessage = "Digite o número de telefone")]
        public string contato { get; set; }
        [Required(ErrorMessage = "Digite o endereço ")]
        public string endereco { get; set; }
        public bool ativo { get; set; } = true;
        [Required(ErrorMessage = "Digite o nome da pessoa beneficiada")]
        public string beneficario { get; set; } = "NULL";
        public DateTime dataFinalizacao { get; set; } = DateTime.Now;

    }
}
