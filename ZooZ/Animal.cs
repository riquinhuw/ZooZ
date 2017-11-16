using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZ
{
    class Animal
    {
        private string nome;
        private int idade; // o certo seria data de nascimento
        private string especie;
        private int id;
        private int idHabitat;


        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Especie { get => especie; set => especie = value; }
        public int Id { get => id; set => id = value; }
        public int IdHabitat { get => idHabitat; set => idHabitat = value; }


        public Animal() { } //Cosntrutor vazio

        public Animal(string nomeDoAnimal,int idadeDoAnimal,string especieDoAnimal)
        {
            this.Nome = nomeDoAnimal;
            this.Idade = idadeDoAnimal;
            this.Especie = especieDoAnimal;
        }


    }
}
