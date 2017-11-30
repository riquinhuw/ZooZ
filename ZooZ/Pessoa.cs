using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZ
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private long cpf;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public long Cpf { get => cpf; set => cpf = value; }


        protected Pessoa() { }//construtor vazio

        protected Pessoa(string nome,int idade, long cpf)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
        }
    }
}
