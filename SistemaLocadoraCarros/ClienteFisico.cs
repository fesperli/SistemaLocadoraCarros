using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class ClienteFisico : Pessoa
    {
        private string Cpf {  get; set; }
        private string Cnh { get; set; }

        public string GetCpf () { return Cpf; }
        public string GetCnh () { return Cnh; }

        public void SetCpf (string cpf) { Cpf = cpf; }
        public void SetCnh (string cnh) { Cnh = cnh; }

        public ClienteFisico(string nome, string numerotel, string cpf, string cnh) : base (nome, numerotel)
        {
            Cpf = cpf;
            Cnh = cnh;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nCPF: {Cpf}\nCNH: {Cnh}";
        }

    }
}
