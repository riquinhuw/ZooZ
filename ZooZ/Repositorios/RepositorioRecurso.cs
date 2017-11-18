using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZ.Repositorios
{
    class RepositorioRecurso
    {
        private DAO dao = new DAO();
        public void Inserir(Recurso r)
        {


            MySqlParameter paramNome = new MySqlParameter("@Nome", r.Nome);
            MySqlParameter paramQuantidade = new MySqlParameter("@Quantidade", r.Quantidade);
            dao.ExecuteNonQuery("INSERT INTO Recursos (nomeProduto,quantidade) VALUES (@Nome, @Quantidade)", paramNome, paramQuantidade);
        }
    }
}
