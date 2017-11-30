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
            try
            {
                MySqlParameter paramNome = new MySqlParameter("@Nome", r.Nome);
                MySqlParameter paramQuantidade = new MySqlParameter("@Quantidade", r.Quantidade);
                dao.ExecuteNonQuery("INSERT INTO RECURSOS (NOME_PRODUTO,QUANTIDADE_PRODUTO) VALUES (@Nome, @Quantidade)", paramNome, paramQuantidade);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir o recurso." + ex.Message);
                throw ex;
            }
        }


        public void Remover(int id)//via ID
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                dao.ExecuteNonQuery("DELETE FROM RECURSOS WHERE ID_PRODUTO = (@Id)", paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover o recurso" + ex.Message);
                throw ex;
            }
        }

        public void AlterarNome(int id, string nome)//via ID mudar só o nome
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramNomeProduto = new MySqlParameter("@Nome", nome);
                dao.ExecuteNonQuery("UPDATE RECURSOS SET NOME_PRODUTO = @Nome WHERE ID_PRODUTO = (@Id)", paramNomeProduto, paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar o nome do recurso" + ex.Message);
                throw ex;
            }
        }

        public void AlterarQuantidade(int id, int quantidade)//via ID mudar só a quantidade
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramQuantidade = new MySqlParameter("@Quantidade", quantidade);
                dao.ExecuteNonQuery("UPDATE RECURSOS SET QUANTIDADE_PRODUTO = @Quantidade WHERE ID_PRODUTO = (@Id)", paramQuantidade, paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar a quantidade do recurso" + ex.Message);
                throw ex;
            }
        }

        public void Listar() //Falta Procurar por nome especifico
        {
            string connectionString = (@"server= sql10.freemysqlhosting.net;user id=sql10207977;password=Dftua2hRb3;database=sql10207977");//fix it
            string consulta = "SELECT * FROM RECURSOS";
            MySqlConnection conexao = new MySqlConnection(connectionString);
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("{0}-{1} - {2}", dr["ID_PRODUTO"], dr["NOME_PRODUTO"], dr["QUANTIDADE_PRODUTO"]);
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
