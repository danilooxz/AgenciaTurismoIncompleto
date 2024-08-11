using AgenciaTurismo.classes;
using AgenciaTurismo.interfaces;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaTurismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agencia agenciaTur = new Agencia();

            while (true)
            {
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("1. Adicionar Cliente");
                Console.WriteLine("2. Adicionar Viagem");
                Console.WriteLine("3. Realizar Reserva");
                Console.WriteLine("4. Atualizar Reserva");
                Console.WriteLine("5. Listar Clientes ");
                Console.WriteLine("6. Listar Viagems");
                Console.WriteLine("7. Listar Reservas");
                Console.WriteLine("8. Listar Reservas Por Clientes");
                Console.WriteLine("9. Cancelar Reserva");
                Console.WriteLine("10. Filtrar Viagem Por Preço");
                Console.WriteLine("11. Filtrar Viagem Por Destino");
                Console.WriteLine("12. Filtrar Viagem Por Tipo");
                Console.WriteLine("13. Sair");
                string opcao = Console.ReadLine();

                if (opcao == "13")
                {
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do cliente: ");
                        string nomeCliente = Console.ReadLine();

                        Console.WriteLine("Digite o email do cliente: ");
                        string emailCliente = Console.ReadLine();

                        Cliente cliente = new Cliente(nomeCliente, emailCliente);
                        
                        agenciaTur.AdicionarClientes(cliente);
                        break;

                    case "2":
                        Console.WriteLine("Digite o destino da viagem: ");
                        string viagemDestino = Console.ReadLine();

                        Console.WriteLine("Digite o preço da viagem: ");
                        decimal viagemPreco = decimal.Parse(Console.ReadLine());

                        Viagem viagem = new ViagemConcreta(viagemDestino, viagemPreco);

                        agenciaTur.AdicionarViagem(viagem);
                        break;

                    case "3":
                        agenciaTur.RealizarReserva();
                        break;

                    case "4":
                        agenciaTur.AtualizarReserva();
                        break;

                    case "5":
                        agenciaTur.ListarClientes();
                        break;

                    case "6":
                        agenciaTur.ListarViagem();
                        break;

                    case "7":
                        agenciaTur.ListarReserva();
                        break;

                    case "8":
                        agenciaTur.ListarReservasCliente();
                        break;

                    case "9":
                        agenciaTur.CancelarReserva();
                        break;
                            
                    case "10":
                        agenciaTur.FiltarViagemPreco();
                        break;

                    case "11":
                        agenciaTur.FiltarViagemDestino(); 
                        break;
                    
                    case "12":
                        agenciaTur.FiltarViagemTipo();
                        break;
                }
            }
        }
    }
}
