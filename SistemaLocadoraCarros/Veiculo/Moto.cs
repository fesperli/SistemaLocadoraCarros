using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaLocadoraCarros.Veiculo
{
    public class Moto : Veiculo
    {
        private string Cilindradas { get; set; }
        private string TipoVeiculo { get; set; }

        public Moto(string placa, string modelo, string marca, int ano, double valorDiaria, string cilindradas, string tipoveiculo)
            : base(placa, modelo, marca, ano, valorDiaria)
        {
            Cilindradas = cilindradas;
            TipoVeiculo = tipoveiculo;
        }

        public string GetCilindradas() { return Cilindradas; }
        public string GetTipoVeiculo () { return TipoVeiculo; }

        public void SetCilindradas (string cilindradas) { Cilindradas = cilindradas;}
        public void SetTipoVeiculo (string tipoveiculo) { TipoVeiculo = tipoveiculo;}

        public override string ToString()
        {
            return base.ToString() +
                $"\nCilindradas: {Cilindradas}\nCategoria: {TipoVeiculo}";
        }


    }
} 
