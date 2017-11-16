using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZ
{
    class Funcionario : Pessoa
    {
       private int matricula;
       private string cargo;
       private int setor; //Numero do Habitat, vulgo chave estrangeira

        public int Matricula { get => matricula; set => matricula = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Setor { get => setor; set => setor = value; }


        public Funcionario() { }//Construtor vazio

        public Funcionario(string nome, int idade, double cpf,string cargo,int setor)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
            this.Cargo = cargo;
            this.Setor = setor;
        }

    }
}
