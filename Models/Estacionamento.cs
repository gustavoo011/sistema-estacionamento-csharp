using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> Veiculos = new List<string>();
        private string placa = "";

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Veículo");
            Console.Write("\nDigite a placa do veículo: ");
            placa = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(placa) || placa.Length != 7) //consistência de dados
            {
                Console.WriteLine("\nEntrada Inválida. Digite novamente");
                Console.Write("Digite a placa do veículo: ");
                placa = Console.ReadLine();
            }
            Veiculos.Add(placa);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            Console.WriteLine("Listar Veículos");
            Console.WriteLine($"Veículos Estacionados: {Veiculos.Count}");
            if (Veiculos.Any()) //Verificando se há algum elemento na lista 'Veiculos'
            {
                Console.WriteLine("\nLista de Veículos");
                foreach (string veiculo in Veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void RemoverVeiculo()
        {
            int horas;
            Console.Clear();
            Console.WriteLine("Remover Veículo");
            Console.Write("\nDigite a placa do veículo que será removido: ");
            placa = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(placa) || placa.Length != 7)
            {
                Console.WriteLine("\nEntrada Inválida. Digite novamente");
                Console.Write("Digite a placa do veículo que será removido: ");
                placa = Console.ReadLine();
            }
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas estacionadas: ");
                while (!int.TryParse(Console.ReadLine(), out horas))
                {
                    Console.WriteLine("\nEntrada Inválida. Digite novamente");
                    Console.Write("Digite a quantidade de horas estacionadas: ");
                }
                Console.Clear();
                Console.WriteLine($"Veículo: {placa}");
                Console.WriteLine($"\nPreço Inicial: R${precoInicial}");
                Console.WriteLine($"Preço por Hora: R${precoHora}");
                Console.WriteLine($"Horas estacionadas: {horas}");
                Console.WriteLine($"Preço total a pagar: R${(precoHora * horas) + precoInicial}");
                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Veiculos.Remove(placa);
                Console.Clear();
                Console.WriteLine($"Veículo de placa {placa} removido com sucesso.");

            }
            else if (!Veiculos.Contains(placa))
            {
                Console.WriteLine("\nO veículo digitado não existe.");
            }
            else
            {
                Console.WriteLine("\nNão existem veículos para serem removidos.");
            }
            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        
        }
        public int QuantidadeVeiculos
        {
            get {return Veiculos.Count;}
        }
    }
}