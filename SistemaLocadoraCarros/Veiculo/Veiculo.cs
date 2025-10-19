using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros.Veiculo
{
    public abstract class Veiculo
    {
        private string Placa { get; set; }
        private string Modelo { get; set; }
        private string Marca { get; set; }
        private int Ano { get; set; }
        private double ValorDiaria { get; set; }


        public Veiculo(string placa, string modelo, string marca, int ano, double valorDiaria)
        {
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            ValorDiaria = valorDiaria;
        }

        public string GetPlaca() { return Placa; }
        public string GetModelo() { return Modelo; }
        public string getMarca() { return Marca; }
        public int GetAno() { return Ano; }
        public double GetValorDiaria() { return ValorDiaria; }

        public void SetPlaca(string placa) { Placa = placa; }
        public void SetModelo(string modelo) { Modelo = modelo; }
        public void SetMarca(string marca) { Marca = marca; }
        public void SetAno(int ano) { Ano = ano; }
        public void SetValorDiaria(double valorDiaria) { ValorDiaria = valorDiaria; }

        public override string ToString()
        {
            return $"Placa: {Placa}\n Modelo: {Modelo}\n Marca: {Marca}\n Ano: {Ano}\n Valor da Diaria: {ValorDiaria}";
        }

    }
}
