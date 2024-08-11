using AgenciaTurismo.classes;

namespace AgenciaTurismo
{
    internal class ViagemConcreta : Viagem
    {
        public ViagemConcreta(string destino, decimal preco) : base(destino, preco)
        {
        }
    }
}