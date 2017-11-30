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
                MySqlParameter paramRecursoId = new MySqlParameter("@RecursoId", h.RecursoId);
                dao.ExecuteNonQuery("INSERT INTO HABITAT (NOME_HABITAT,ID_RECURSOS) VALUES (@Nome, @RecursoId)", paramNome, paramRecursoId);
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
                dao.ExecuteNonQuery("DELETE FROM HABITAT WHERE ID_HABITAT = (@Id)", paramId);
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
                dao.ExecuteNonQuery("UPDATE HABITAT SET NOME_HABITAT = @Nome WHERE ID_HABITAT = (@Id)", paramNomeHabitat, paramId);
            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao alterar o Habit" + ex.Message);
                throw ex;
            }
        }

        public void Listar() //Falta Procurar por nome especifico
        {
            string connectionString = (@"server= sql10.freemysqlhosting.net;user id=sql10207977;password=Dftua2hRb3;database=sql10207977");//fix it
            string consulta = "SELECT * FROM HABITAT";
            MySqlConnection conexao = new MySqlConnection(connectionString);
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("{0} - {1} ,consumindo:{2}", dr["ID_HABITAT"], dr["NOME_HABITAT"], dr["ID_RECURSOS"]);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ocorreu um erro ao listar os habitats\n\n\n");
                Console.ResetColor();
                Console.WriteLine(ex.Message);
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
