using AgenciaTurismo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaTurismo.classes
{
    public class ViagemNacional : Viagem, IDetalhavel
    {
        public string Estado { get; set; }

        public ViagemNacional(string destino, decimal preco, string estado) : base(destino, preco)
        {
            Estado = estado;
        }

        public void ExibirDetalhes()
        {

        }
    }
}
