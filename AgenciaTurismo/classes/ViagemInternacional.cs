using AgenciaTurismo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaTurismo.classes
{
    public class ViagemInternacional : Viagem, IDetalhavel
    {
        public string Pais { get; set; }
        public bool PrecisaVisto { get; set; }

        public ViagemInternacional(string destino, decimal preco, string pais, bool precisavisto) : base(destino, preco)
        {
            Pais = pais;
            PrecisaVisto = precisavisto;
        }

        public void ExibirDetalhes()
        {
            
        }
    }
}
