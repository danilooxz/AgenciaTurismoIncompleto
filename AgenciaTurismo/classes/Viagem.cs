using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaTurismo.classes
{
    public abstract class Viagem
    {
        public string Destino { get; set; }
        public decimal Preco { get; set; }

        public Viagem(string destino, decimal preco)
        {
            Destino = destino;
            Preco = preco;
        }

        public void ExibirDetalhes()
        {

        }
    }
}
