using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZ
{
    class Recurso
    {
        private string nome;
        private int id;
        private int quantidade;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }


        public Recurso() { }

        public Recurso(string nome,int id, int quantidade)
        {
            this.Nome = nome;
            this.Id = id;
            this.Quantidade = quantidade;
        }
    }
}
