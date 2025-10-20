using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public abstract class Pessoa
    {
        private string Nome { get; set; }
        private string NumeroTel { get; set; }
        
        

        public Pessoa(string nome, string numerotel)
        {
            Nome = nome;
            NumeroTel = numerotel;
           
        }
        public string GetNome () { return Nome; }
        public string GetNumeroTel () { return NumeroTel; }
        

        public void SetNome (string nome) { Nome = nome; }
        public void SetNumeroTel (string numerotel) { NumeroTel = numerotel; }

        public override string ToString()
        {
            return $"\nNome: {Nome}\nTelefone: {NumeroTel}";
        }

        

    }
}
