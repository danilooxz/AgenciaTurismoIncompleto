using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaTurismo.classes
{
    public abstract class Pagamento
    {
        public decimal Valor { get; set; }


        public Pagamento(decimal valor)
        {
            Valor = valor;
        }

    }
}
