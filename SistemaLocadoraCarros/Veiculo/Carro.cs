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

        public Carro(string placa, string modelo, string marca, int ano, double valorDiaria, string tipocombustivel, string tipocambio, string tipoveiculo) : base(placa, modelo, marca, ano, valorDiaria)
        {
            TipoCombustivel = tipocombustivel;
            TipoCambio = tipocambio;
            TipoVeiculo = tipoveiculo;
        }

        public string GetTipoCombustivel() { return  TipoCombustivel; }
        public string GetTipoCambio() { return TipoCambio; }
        public string GetTipoVeiculo() { return TipoVeiculo; }

        public void SetTipoCombustivel (string tipocombustivel) { TipoCombustivel = tipocombustivel;}
        public void SetTipoCambio (string tipocambio) { TipoCambio = tipocambio;}
        public void SetTipoVeiculo (string tipoveiculo) { TipoVeiculo = tipoveiculo;}
        
        public override string ToString()
        {
            return base.ToString() +
                $"Categoria: {TipoVeiculo}\n Combustivel: {TipoCombustivel}\n Cambio: {TipoCambio}";
        }


    }
}
