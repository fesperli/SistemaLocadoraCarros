using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaLocadoraCarros.Veiculo
{
    public class Carro : Veiculo
    {
        private string TipoCombustivel { get; set; }
        private string TipoCambio { get; set; }
        private string TipoVeiculo { get; set; }

        public Carro (string marca, string modelo, string placa, int ano, string tipoveiculo, string tipocambio, string tipocombustivel) : base (placa, modelo, marca, ano) 
        {
            TipoCombustivel = tipocombustivel;
            TipoCambio = tipocambio;
            TipoVeiculo = tipocombustivel;
        }

        public override string ToString()
        {
            return $"Categoria: {TipoVeiculo}, Combustivel: {TipoCombustivel}, Cambio: {TipoCambio}";
        }


    }
}
