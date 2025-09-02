using Estacionamento.Models;


//Declaração de Variáveis
bool encerrar = false;
int opcao;
decimal precoInicial, precoHora;

//Lista para armazenar os Veículos
List<string> Veiculos = new List<string>();

Console.Clear();
Console.WriteLine("Seja bem-vindo(a) ao Sistema de Estacionamento!");
Console.Write("\nDigite o preço inicial que será cobrado: R$");
while (!decimal.TryParse(Console.ReadLine(), out precoInicial)) //consistência de dados
{
  Console.WriteLine("\nEntrada Inválida. Digite novamente");
  Console.Write("Digite o preço inicial que será cobrado: R$");
}

Console.Write("Digite o preço que será cobrado por hora: R$");
while (!decimal.TryParse(Console.ReadLine(), out precoHora)) //consistência de dados
{
  Console.WriteLine("\nEntrada Inválida. Digite novamente");
  Console.Write("Digite o preço que será cobrado por hora: R$");
}

Estacionamento.Models.Estacionamento es = new Estacionamento.Models.Estacionamento(precoInicial, precoHora);

//Loop para o Menu
while (!encerrar)
{
  //Limpando o Console
  Console.Clear();
  Console.WriteLine("Seja bem-vindo(a) ao Sistema de Estacionamento!");
  Console.WriteLine($"Preço Inicial: R${precoInicial}");
  Console.WriteLine($"Preço por Hora: R${precoHora}");

  Console.WriteLine("\nMenu");
  Console.WriteLine("1. Adicionar Veículo");
  Console.WriteLine("2. Listar Veículos");
  Console.WriteLine("3. Remover Veículo");
  Console.WriteLine("4. Encerrar");
  Console.Write("\nDigite o número correspondente a opção desejada: ");
  while (!int.TryParse(Console.ReadLine(), out opcao) || opcao > 4 || opcao < 1) //consistência de dados
  {
    Console.WriteLine("\nEntrada Inválida. Digite novamente");
    Console.Write("Digite o número correspondente a opção desejada: ");
  }

  //Switch Case para as opções do Menu
  switch (opcao)
  {
    case 1: //Adicionar Veículo
      es.AdicionarVeiculo();
      break;
    case 2: //Listar Veículos
      es.ListarVeiculos();
      break;
    case 3: //Remover Veículo
      es.RemoverVeiculo();
      break;
    case 4: //Encerrar
      Console.WriteLine("Encerrando...");
      encerrar = true;
      break;

      Console.WriteLine("\nOpção Inválida!");
      Console.Write("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      break;
  }
}