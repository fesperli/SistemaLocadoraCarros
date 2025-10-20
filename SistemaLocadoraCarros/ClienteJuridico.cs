using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class ClienteJuridico : Pessoa
    {
        private string Cnpj { get; set; }

        public string GetCnpj() { return Cnpj; }
        public void SetCnpj (string cnpj) { Cnpj = cnpj; }


        public ClienteJuridico(string nome, string numerotel, string cnpj) : base(nome, numerotel)
        {
            Cnpj = cnpj;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nCPNJ: {Cnpj}";
        }

    }
}
