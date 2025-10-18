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
        private string Cpf { get; set; }
        

        public Pessoa(string nome, string numerotel, string cpf)
        {
            Nome = nome;
            NumeroTel = numerotel;
            Cpf = cpf;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {NumeroTel}, CPF: {Cpf}";
        }
    }
}
