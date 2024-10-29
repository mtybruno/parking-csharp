using Parkingslotcsharp.models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoHora = 0;

Console.WriteLine("Bem vindo ao sistema de Estacionamento\n" +
                  "Digite um preço inicial: ");

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Digite um preço por hora");
precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento park = new Estacionamento(precoInicial, precoHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            park.addVeiculo();
            break;
        case "2":
            park.removeVeiculo();
            break;
        case "3":
            park.listVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa encerrou");

