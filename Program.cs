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
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o preço que será cobrado por hora: R$");
precoHora = Convert.ToDecimal(Console.ReadLine());

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
  opcao = Convert.ToInt32(Console.ReadLine());

  //Switch Case para as opções do Menu
  switch (opcao)
  {
    case 1: //Adicionar Veículo
      Console.Clear();
      Console.WriteLine("Adicionar Veículo");
      Console.Write("\nDigite a placa do veículo: ");
      placa = Console.ReadLine();
      Veiculos.Add(placa);
      Console.WriteLine("\nVeículo adicionado com sucesso!");
      Console.Write("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      break;
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
      Console.WriteLine();
      break;
    case 4: //Encerrar
      Console.WriteLine("Encerrando...");
      encerrar = true;
      break;
    default: //Opções Inválidas
      Console.WriteLine("\nOpção Inválida!");
      Console.Write("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      break;
  }
}