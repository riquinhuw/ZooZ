using MySql.Data.MySqlClient;
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
        private int recursoId;
        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public int RecursoId { get => recursoId; set => recursoId = value; }

        public Habitat() { }

        public Habitat(string nome, int idRecurso)
        {
            this.Nome = nome;
            this.RecursoId = idRecurso;
        }



    }
}
