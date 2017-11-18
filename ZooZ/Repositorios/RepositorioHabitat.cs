using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZ.Repositorios
{
    class RepositorioHabitat
    {
        private DAO dao = new DAO();
        public void Inserir(Habitat h)
        {
            MySqlParameter paramNome = new MySqlParameter("@Nome", h.Nome);
            MySqlParameter paramRecursoId = new MySqlParameter("@recursoId", h.RecursoId);
            dao.ExecuteNonQuery("INSERT INTO Habitat (nomeHabitat,Recursos_id) VALUES (@Nome, @recursoId)", paramNome, paramRecursoId);
        }

        public void Remover(int id)//via ID
        {
            MySqlParameter paramId = new MySqlParameter("@Id", id);
            dao.ExecuteNonQuery("DELETE FROM Habitat WHERE id_Habitat = (@Id)", paramId);
        }

        public void Alterar(int id,string nome)//via ID mudar só o nome
        {
            MySqlParameter paramId = new MySqlParameter("@Id", id);
            MySqlParameter paramNomeHabitat = new MySqlParameter("@Nome", nome);
            dao.ExecuteNonQuery("UPDATE Habitat SET nomeHabitat = @Nome WHERE id_Habitat = (@Id)", paramId, paramNomeHabitat);
            
        }


    }
}
