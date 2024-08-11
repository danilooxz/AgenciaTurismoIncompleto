using AgenciaTurismo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaTurismo.classes
{
    public class Agencia
    {

        private List<Viagem> viagems = new List<Viagem>();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Reserva> reservas = new List<Reserva>();

        public void AdicionarClientes(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine($"{cliente.Nome} foi adicionado");
        }

        public void AdicionarViagem(Viagem viagem)
        {
            viagems.Add(viagem);
            Console.WriteLine($"{viagem.Destino}, foi adiconada");

        }

        public void ListarClientes()
        {
            if (clientes.Count > 0)
            {
                Console.WriteLine("Clientes na lista");
                foreach (Cliente cliente in clientes)
                {
                    cliente.ExibirDetalhes();
                    Console.WriteLine($"Nome:{cliente.Nome}, Email{cliente.Email}");
                }
            
            }
                else
            {
                Console.WriteLine("A Lista de Clientes está vazia");
            }
        }
    
        public void ListarViagem()
        {
            if (viagems.Count > 0)
            {
                Console.WriteLine("Lista de Viagems");
                foreach (Viagem viagem in viagems)
                {
                    viagem.ExibirDetalhes();
                    Console.WriteLine($"Destino: {viagem.Destino}, Preco: {viagem.Preco}");
                }
            }
        
                else
            {
                Console.WriteLine("A Lista de Viagems está vazia");
            }
        }

        public void RealizarReserva()
        {
            Console.WriteLine("Sua Reserva foi feita com sucesso");
            foreach (Reserva reserva in reservas)
            {
                if (reserva is IReservavel reservavel)
                {
                    reservavel.ExibirReserva();
                }
            }
        }

        public void ListarReserva()
        {
            if (reservas.Count > 0)
            {
                Console.WriteLine("Lista de Reservas");
                foreach (Reserva reserva in reservas)
                {
                    reserva.ExibirReserva();
                    Console.WriteLine($"Viagem: {reserva.Destino}");
                }
            }
       
                else
            {
                Console.WriteLine("A Lista de Reservas está vazia");
            }
        }

        public void CancelarReserva()
        {
            Console.Write("Nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            var reserva = reservas.FirstOrDefault(r => r.Destino == nomeCliente);

            if (reserva != null)
            {
                reservas.Remove(reserva);
                Console.WriteLine("Reserva camcelada");
            }
            else
            {
                Console.WriteLine("Reserva não encontrada");
            }
        }

        public void AtualizarReserva()
        {

        }

        public void ListarReservasCliente()
        {

        }

        public void FiltarViagemPreco()
        {

        }

        public void FiltarViagemDestino()
        {

        }

        public void FiltarViagemTipo()
        {

        }
    }
}
