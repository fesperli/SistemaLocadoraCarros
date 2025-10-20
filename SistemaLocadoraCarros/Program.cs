using SistemaLocadoraCarros;
using SistemaLocadoraCarros.Veiculo;
using System;
using System.Collections.Generic;

List<Pessoa> clientes = new List<Pessoa>();
List<Veiculo> veiculos = new List<Veiculo>();
void CadastrarCliente()
{
    Console.WriteLine("1 - Cadastrar cliente: \n 1 - Pessoa Fisica\n 2 - Pessoa Juridica");
    int op = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Telefone: ");
    string numerotel = Console.ReadLine();

    if (op == 1)
    {
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("CNH: ");
        string cnh = Console.ReadLine();
        clientes.Add(new ClienteFisico(nome, numerotel, cpf, cnh));
    }
    else if (op == 2)
    {
        Console.Write("CNPJ: ");
        string cnpj = Console.ReadLine();
        clientes.Add(new ClienteJuridico(nome, numerotel, cnpj));
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
    int op = int.Parse(Console.ReadLine());

    Console.Write("Placa: ");
    string placa = Console.ReadLine();
    Console.Write("Modelo: ");
    string modelo = Console.ReadLine();
    Console.Write("Marca: ");
    string marca = Console.ReadLine();
    Console.Write("Ano: ");
    int ano = int.Parse(Console.ReadLine());
    Console.Write("Valor da diaria: ");
    double valordiaria = double.Parse(Console.ReadLine());

    if (op == 1) { 
    
        Console.Write("Tipo de Combustivel: ");
        string combustivel = Console.ReadLine();
        Console.Write("Tipo de Cambio: ");
        string cambio = Console.ReadLine();
        Console.Write("Categoria do Veiculo: ");
        string categoria = Console.ReadLine();

        veiculos.Add(new Carro(placa, modelo, marca, ano, valordiaria, combustivel, cambio, categoria));
    }
    else if (op == 2)
    {
        Console.Write("Cilindradas: ");
        string cilindradas = Console.ReadLine();
        Console.Write("Categoria da Moto: ");
        string categoria = Console.ReadLine();

        veiculos.Add(new Moto(placa, modelo, marca, ano, valordiaria, cilindradas, categoria));
    }
    else if (op == 3)
    {
        Console.Write("Quantidade de Eixos: ");
        int eixos = int.Parse(Console.ReadLine());
        Console.Write("Tipo de Carga: ");
        string carga = Console.ReadLine();
        Console.Write("Comprimento (em metros): ");
        double comprimento = double.Parse(Console.ReadLine());

        veiculos.Add(new Caminhao(placa, modelo, marca, ano, valordiaria, "Caminhão", eixos, carga, comprimento));
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
        Console.WriteLine("Nao existe nenhum cliente ou veiculo cadastrado");
        return;
    }

    Console.WriteLine("Escolha o cliente: ");
    for (int i = 0; i < clientes.Count; i++)
    {
        Console.WriteLine($"{i + 1} {clientes[i].GetNome()}");
    }
    int clientescadastrados = (int.Parse(Console.ReadLine()) - 1);

    Console.WriteLine("Escolha o veiculo:");
    for (int i = 0; i < veiculos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {veiculos[i].GetModelo()} - {veiculos[i].GetMarca()} - {veiculos[i].GetPlaca()}");
    }
    int veiculoscadastrados = (int.Parse(Console.ReadLine()) - 1);

    Console.Write("Quantidade de dias da locacao: ");
    int dias = int.Parse(Console.ReadLine());

    veiculos[veiculoscadastrados].RegistrarLocacao(clientes[clientescadastrados], dias);
}

void ListarClientes()
{
    Console.WriteLine("Clientes cadastrados");
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


int op;
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
    Console.WriteLine("\n Digite sua escolha: ");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            CadastrarCliente();
            break;
        case 2:
            CadastrarVeiculo();
            break;
        case 3:
            RealizarLocacao();
            break;
        case 4:
            ListarClientes();
            break;
        case 5:
            ListarVeiculos();
            break;
        case 0:
            break;
        default:
            Console.WriteLine("opcao errada");
            break;
    }

    if (op != 0)
    {
        Console.ReadKey();
    }

} while (op != 0);
