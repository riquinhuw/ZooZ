using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void Alterar(int id, string nome)//via ID mudar só o nome
        {
            MySqlParameter paramId = new MySqlParameter("@Id", id);
            MySqlParameter paramNomeHabitat = new MySqlParameter("@Nome", nome);
            dao.ExecuteNonQuery("UPDATE Habitat SET nomeHabitat = @Nome WHERE id_Habitat = (@Id)", paramId, paramNomeHabitat);

        }

        public void Listar() //Falta Procurar por nome especifico
        {
            string connectionString = (@"server=sql10.freemysqlhosting.net;user id=sql10205465;password=2IrZ7R4mIS;database=sql10205465");
            string consulta = "SELECT * FROM Habitat";
            MySqlConnection conexao = new MySqlConnection(connectionString);
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["nomeHabitat"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ... " + ex.Message);
                throw ex;
            }
            finally
            {
                dr.Close();
                conexao.Close();
            }

        }
    }
}
