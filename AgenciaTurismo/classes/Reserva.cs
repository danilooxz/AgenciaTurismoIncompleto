using AgenciaTurismo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaTurismo.classes
{
    public class Reserva : Viagem, IReservavel
    {

        public string AdicionarPagamento { get; set; }

        public Reserva(string destino, decimal preco) : base(destino, preco)
        {
            AdicionarPagamento = AdicionarPagamento;
        }

        public void ExibirDetalhes()
        {

        }


        public void ExibirReserva()
        {

        }

    }

}
