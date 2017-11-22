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
                dao.ExecuteNonQuery("INSERT INTO Recursos (nomeProduto,quantidade) VALUES (@Nome, @Quantidade)", paramNome, paramQuantidade);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir o recurso.");
                throw ex;
            }
        }


        public void Remover(int id)//via ID
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                dao.ExecuteNonQuery("DELETE FROM Recursos WHERE id_Produto = (@Id)", paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover o recurso");
                throw ex;
            }
        }

        public void AlterarNome(int id, string nome)//via ID mudar só o nome
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramNomeProduto = new MySqlParameter("@Nome", nome);
                dao.ExecuteNonQuery("UPDATE Recursos SET nomeProduto = @Nome WHERE id_Produto = (@Id)", paramNomeProduto, paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar o nome do recurso");
                throw ex;
            }
        }

        public void AlterarQuantidade(int id, int quantidade)//via ID mudar só a quantidade
        {
            MySqlParameter paramId = new MySqlParameter("@Id", id);
            MySqlParameter paramQuantidade = new MySqlParameter("@Quantidade", quantidade);
            dao.ExecuteNonQuery("UPDATE Recursos SET quantidade = @Quantidade WHERE id_Produto = (@Id)", paramQuantidade, paramId);

        }

        public void Listar() //Falta Procurar por nome especifico
        {
            string connectionString = (@"server=sql10.freemysqlhosting.net;user id=sql10205465;password=2IrZ7R4mIS;database=sql10205465");
            string consulta = "SELECT * FROM Recursos";
            MySqlConnection conexao = new MySqlConnection(connectionString);
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("{0}-{1} - {2}", dr["id_Produto"], dr["nomeProduto"], dr["quantidade"]);
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
