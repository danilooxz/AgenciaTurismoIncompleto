using AgenciaTurismo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaTurismo.classes
{
    public class PagamentoCartao : Pagamento, IReservavel
    {
        public string NumeroCartao { get; set; }

        public PagamentoCartao(decimal valor, string numerocartao) : base(valor)
        {
            NumeroCartao = numerocartao;
        }

        public void ExibirReserva()
        {

        }
    }
}
