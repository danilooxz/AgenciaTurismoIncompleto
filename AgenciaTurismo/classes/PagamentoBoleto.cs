using AgenciaTurismo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaTurismo.classes
{
    public class PagamentoBoleto : Pagamento, IReservavel
    {
        public string NumeroBoleto { get; set; }

        public PagamentoBoleto(decimal valor, string numeroboleto) : base(valor)
        {
            NumeroBoleto = numeroboleto;
        }

        public void ExibirReserva()
        {

        }
    }
}
