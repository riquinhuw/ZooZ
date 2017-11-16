using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZ
{
    class Habitat
    {
        //Funcionario recebe a chave estrangeira de HAbitat
        // O IdHabitat vai para Pessoa( isso já no BD)

        private string nome;
        private int id;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }

        public Habitat() { }

        public Habitat(string nome)
        {
            this.Nome = nome;

        }

    }
}
