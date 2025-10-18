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
        

    public Veiculo (string placa, string modelo, string marca, int ano)
        {
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            
            
        }

        public override string ToString()
        {
            return $"Placa: {Placa}, Modelo: {Modelo}, Marca: {Marca}, Ano: {Ano}";
        }

    }
}
