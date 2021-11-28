using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Malwaro.Data
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho { get; set; }

        public double Total { get; set; }

        [Display(Name = "Forma de Pagamento")]
        [Required(ErrorMessage = "Obrigatório.")]
        public FormaDePagamento FormaDePagamento { get; set; }

        [Display(Name = "Número do Cartão")]
        public string CartaoNumero { get; set; }

        [Display(Name = "Data De Validade")]
        [DataType(DataType.Date)]
        public DateTime CartaoValidade{ get; set; }

        [Display(Name = "CVV")]
        public string CartaoCVV { get; set; }
    }
}
