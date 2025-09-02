using Estacionamento.Models;


//Declaração de Variáveis
bool encerrar = false;
int opcao, horas;
decimal precoInicial, precoHora;
string placa;

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

 

//Loop para o Menu
while (!encerrar)
{
  //Limpando o Console
  Console.Clear();
  Console.WriteLine("Seja bem-vindo(a) ao Sistema de Estacionamento!");
  Console.WriteLine($"Preço Inicial: R${precoInicial}");
  Console.WriteLine($"Preço por Hora: R${precoHora}");
  Console.WriteLine($"Veículos estacionados: {Veiculos.Count}");
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

    case 2: //Listar Veículos
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
      break;
    case 3: //Remover Veículo
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
        Console.Write("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
      }
      else
      {
        Console.WriteLine("\nNão existem veículos para serem removidos.");
      }

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