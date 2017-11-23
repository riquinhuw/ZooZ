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
            try
            {
                MySqlParameter paramNome = new MySqlParameter("@Nome", h.Nome);
                MySqlParameter paramRecursoId = new MySqlParameter("@recursoId", h.RecursoId);
                dao.ExecuteNonQuery("INSERT INTO Habitat (nomeHabitat,Recursos_id) VALUES (@Nome, @recursoId)", paramNome, paramRecursoId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir o Habitat" + ex.Message);
                throw ex;
            }
        }

        public void Remover(int id)//via ID
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                dao.ExecuteNonQuery("DELETE FROM Habitat WHERE id_Habitat = (@Id)", paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover o Habitat" + ex.Message);
                throw ex;
            }
        }

        public void Alterar(int id, string nome)//via ID mudar só o nome
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramNomeHabitat = new MySqlParameter("@Nome", nome);
                dao.ExecuteNonQuery("UPDATE Habitat SET nomeHabitat = @Nome WHERE id_Habitat = (@Id)", paramNomeHabitat, paramId);
            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao alterar o Habit" + ex.Message);
                throw ex;
            }
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
                    Console.WriteLine("{0} - {1} ,consumindo:{2}",dr["id_Habitat"],dr["nomeHabitat"],dr["Recursos_id"]);
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
