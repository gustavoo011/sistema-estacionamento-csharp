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
    }
}