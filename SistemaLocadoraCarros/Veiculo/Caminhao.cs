using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros.Veiculo
{
    public class Caminhao : Veiculo
    {
        private int QntEixos {  get; set; }
        private string TipoCarga {  get; set; }
        private double Comprimento {  get; set; }

        public Caminhao(string placa, string modelo, string marca, int ano, double valorDiaria, string tipoveiculo, int qnteixos, string tipocarga, double comprimento) : base (placa, modelo, marca, ano, valorDiaria)
        {
            QntEixos = qnteixos;
            TipoCarga = tipocarga;
            Comprimento = comprimento;
        }

        public int GetQntEixos () { return QntEixos; }
        public string GetTipoCarga () { return TipoCarga; }
        public double GetComprimento () { return Comprimento; }

        public void SetQntEixos (int qnteixos) {QntEixos = qnteixos;}
        public void SetTipoCarga (string tipocarga) { TipoCarga = tipocarga;}
        public void SetComprimento (double comprimento) {Comprimento = comprimento;}

        public override string ToString()
        {
            return base.ToString() +
                $"Quantidade de eixos: {QntEixos}\n Tipo de Carga: {TipoCarga}\n Comprimento(em Metros): {Comprimento}";
        }





    }
}
