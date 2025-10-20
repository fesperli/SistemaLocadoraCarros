using SistemaLocadoraCarros;
using SistemaLocadoraCarros.Veiculo;
using System;
using System.Collections.Generic;

List<Pessoa> clientes = new List<Pessoa>();
List<Veiculo> veiculos = new List<Veiculo>();

string opcao;
do
{
    Console.Clear();
    Console.WriteLine("=== Sistema de Locadora de Carros ===");
    Console.WriteLine("1. Cadastrar Cliente");
    Console.WriteLine("2. Cadastrar Veículo");
    Console.WriteLine("3. Realizar Locação");
    Console.WriteLine("4. Listar Clientes");
    Console.WriteLine("5. Listar Veículos");
    Console.WriteLine("0. Sair");
    Console.Write("\nEscolha uma opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            CadastrarCliente();
            break;
        case "2":
            CadastrarVeiculo();
            break;
        case "3":
            RealizarLocacao();
            break;
        case "4":
            ListarClientes();
            break;
        case "5":
            ListarVeiculos();
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Opcao invalida.");
            break;
    }

    if (opcao != "0")
    {
        Console.ReadKey();
    }

} while (opcao != "0");
void CadastrarCliente()
{
    Console.WriteLine("\nCadastrar cliente:");
    Console.Write("1 - Fisico\n2 - Juridico");
    Console.WriteLine("\n");
    string tipo = Console.ReadLine();

    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Telefone: ");
    string telefone = Console.ReadLine();

    if (tipo == "1")
    {
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("CNH: ");
        string cnh = Console.ReadLine();
        clientes.Add(new ClienteFisico(nome, telefone, cpf, cnh));
    }
    else if (tipo == "2")
    {
        Console.Write("CNPJ: ");
        string cnpj = Console.ReadLine();
        clientes.Add(new ClienteJuridico(nome, telefone, cnpj));
    }
    else
    {
        Console.WriteLine("tipo de cliente invalido");
    }
}

void CadastrarVeiculo()
{
    Console.WriteLine("Cadastrar Veículo:");
    Console.Write("1 - Carro\n2 - Moto\n3 - Caminhao");
    Console.WriteLine("\n");
    string tipo = Console.ReadLine();

    Console.Write("Placa: ");
    string placa = Console.ReadLine();
    Console.Write("Modelo: ");
    string modelo = Console.ReadLine();
    Console.Write("Marca: ");
    string marca = Console.ReadLine();
    Console.Write("Ano: ");
    int ano = int.Parse(Console.ReadLine());
    Console.Write("Valor da diaria: ");
    double diaria = double.Parse(Console.ReadLine());

    if (tipo == "1")
    {
        Console.Write("Tipo de Combustivel: ");
        string combustivel = Console.ReadLine();
        Console.Write("Tipo de Cambio: ");
        string cambio = Console.ReadLine();
        Console.Write("Categoria do Veiculo: ");
        string categoria = Console.ReadLine();

        veiculos.Add(new Carro(placa, modelo, marca, ano, diaria, combustivel, cambio, categoria));
    }
    else if (tipo == "2")
    {
        Console.Write("Cilindradas: ");
        string cilindradas = Console.ReadLine();
        Console.Write("Categoria da Moto: ");
        string categoria = Console.ReadLine();

        veiculos.Add(new Moto(placa, modelo, marca, ano, diaria, cilindradas, categoria));
    }
    else if (tipo == "3")
    {
        Console.Write("Quantidade de Eixos: ");
        int eixos = int.Parse(Console.ReadLine());
        Console.Write("Tipo de Carga: ");
        string carga = Console.ReadLine();
        Console.Write("Comprimento (em metros): ");
        double comprimento = double.Parse(Console.ReadLine());

        veiculos.Add(new Caminhao(placa, modelo, marca, ano, diaria, "Caminhão", eixos, carga, comprimento));
    }
    else
    {
        Console.WriteLine("veiculo invalido");
    }
}

void RealizarLocacao()
{
    if (clientes.Count == 0 || veiculos.Count == 0)
    {
        Console.WriteLine("Nao tem clientes ou veiculos cadastrados.");
        return;
    }

    Console.WriteLine("Escolha o cliente:");
    for (int i = 0; i < clientes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {clientes[i].GetNome()}");
    }
    int nmrCliente = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("Escolha o veiculo:");
    for (int i = 0; i < veiculos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {veiculos[i].GetModelo()} -  {veiculos[i].GetMarca()} - {veiculos[i].GetPlaca()}");
    }
    int nmrVeiculo = int.Parse(Console.ReadLine()) - 1;

    Console.Write("Quantidade de dias da locacao: ");
    int dias = int.Parse(Console.ReadLine());

    veiculos[nmrVeiculo].RegistrarLocacao(clientes[nmrCliente], dias);
}

void ListarClientes()
{
    Console.WriteLine("\nClientes cadastrados:");
    foreach (var cliente in clientes)
    {
        Console.WriteLine(cliente.ToString());
        Console.WriteLine("-----------------------------------");
    }
}

void ListarVeiculos()
{
    Console.WriteLine("\nVeiculos cadastrados:");
    foreach (var veiculo in veiculos)
    {
        Console.WriteLine(veiculo.ToString());
        Console.WriteLine("-----------------------------------");
    }
}
