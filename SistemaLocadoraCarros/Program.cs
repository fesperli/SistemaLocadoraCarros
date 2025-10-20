using SistemaLocadoraCarros;
using SistemaLocadoraCarros.Veiculo;
using System.ComponentModel.Design;

List<Pessoa> clientes = new List<Pessoa>();
List<Veiculo> veiculos = new List<Veiculo>();


void CadastrarCliente()
{
    Console.WriteLine("1 - Cadastrar cliente\n 1 - Cliente Fisico\n 2 - Cliente Juridico");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine("Nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Telefone: ");
    string numerotel = Console.ReadLine();

    if (op == 1)
    {
        Console.WriteLine("CPF: ");
        string cpf = Console.ReadLine();
        Console.WriteLine("CNH: ");
        string cnh = Console.ReadLine();
        clientes.Add(new ClienteFisico(nome, numerotel, cpf, cnh));
    }
    else if (op == 2) {
        Console.WriteLine("CNPJ: ");
        string cnpj = Console.ReadLine();
        clientes.Add(new ClienteJuridico(nome, numerotel, cnpj));
    } else
    {
        Console.WriteLine("tipo de cliente invalido");
    }
}

void CadastrarVeiculo ()
{
    Console.WriteLine("Cadastrar Veiculo: ");
    Console.WriteLine("1 - Carro\n 2 - Moto\n 3 - Caminhao");
    Console.WriteLine("\n");
    int op = int.Parse(Console.ReadLine());

    Console.WriteLine("Placa: ");
    string placa = Console.ReadLine();
    Console.WriteLine("Modelo: ");
    string modelo = Console.ReadLine();
    Console.WriteLine("Marca: ");
    string marca = Console.ReadLine();
    Console.WriteLine("Ano: ");
    int ano = int.Parse(Console.ReadLine());
    Console.WriteLine("Valor da diaria: ");
    double valordiaria = double.Parse(Console.ReadLine());

    if (op == 1)
    {
        Console.WriteLine("Tipo de combustivel: ");
        string combustivel = Console.ReadLine();
        Console.WriteLine("Tipo de cambio: ");
        string cambio = Console.ReadLine();
        Console.WriteLine("Categoria do veiculo: ");
        string categoria = Console.ReadLine();

        veiculos.Add(new Carro(placa, modelo, marca, ano, valordiaria, combustivel, cambio, categoria));
    }
    else if (op == 2)
    {
        Console.WriteLine("Cilindradas :");
        string cilindradas = Console.ReadLine();
        Console.WriteLine("Categoria da moto :");
        string catmoto = Console.ReadLine();

        veiculos.Add(new Moto(placa, modelo, marca, ano, valordiaria, cilindradas, catmoto));
    }
    else if (op == 3)
    {
        Console.WriteLine("Quantidade de eixos: ");
        int eixos = int.Parse(Console.ReadLine());
        Console.WriteLine("Tipo de carga(alimento, construcao, animal): ");
        string tipocarga = Console.ReadLine();
        Console.WriteLine("Comprimento(em metros): ");
        int comprimento = int.Parse(Console.ReadLine());
    }
    else {
        Console.WriteLine("Veiculo invalido");
    }
}

void RealizarLocacao()
{
    if (clientes.Count > 0 || veiculos.Count == 0)
    {
        Console.WriteLine("Nao tem nenhum cliente ou veiculo cadastrado");
        return;
    }
    Console.WriteLine("Escolha o cliente: ");
    for (int i = 0; i < clientes.Count; i++)
    {
        Console.WriteLine($"{i + 1} {clientes[i].GetNome()}");
    }
    int clientescadastrados = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("Escolha o Veiculo: ");
    for (int i = 0; i < veiculos.Count; i++)
    {
        Console.WriteLine($"{i + 1} {veiculos[i].GetModelo()} - {veiculos[i].GetMarca()} - {veiculos[i].GetPlaca()}");
    }
    int veiculoscadastrados = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("Qnt de dias de locacao: ");
    int dias = int.Parse(Console.ReadLine());

    veiculos[veiculoscadastrados].RegistrarLocacao(clientes[clientescadastrados], dias);
}

void ListarClientes()
{
    Console.WriteLine("\nClientes cadastrados: ");
    foreach (var cliente in clientes)
    {
        Console.WriteLine(cliente.ToString());
        Console.WriteLine("------------");
    }
}

void ListarVeiculos ()
{
    Console.WriteLine("\nVeiculos cadastrados: ");
    foreach (var veiculo in veiculos)
    {
        Console.WriteLine(veiculo.ToString());
        Console.WriteLine("------------");
    }
}

int op;

do
{
    Console.Clear();
    Console.WriteLine("---Sistema de Locacao de Veiculos---");
    Console.WriteLine("\n 1 - Cadastrar Cliente:\n2 - Cadastrar Veiculo:\n3 - Realizar Locacao\n4 - Listar Clientes\n5 - Listar Veiculos\n0 - Sair");
    Console.WriteLine("\n Digite uma opcao: ");
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
            Console.WriteLine("opcao invalida");
            break;
    }

    if (op != 0)
    {
        Console.ReadKey();
    }

} while (op != 0);