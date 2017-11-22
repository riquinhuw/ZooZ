using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZ.Repositorios
{
    class RepositorioAnimal
    {
        private DAO dao = new DAO();
        public void Inserir(Animal a)
        {
            try
            {
                MySqlParameter paramNome = new MySqlParameter("@Nome", a.Nome);
                MySqlParameter paramEspecie = new MySqlParameter("@Especie", a.Especie);
                MySqlParameter paramIdade = new MySqlParameter("@Idade", a.Idade);
                MySqlParameter paramId = new MySqlParameter("@Id", a.Id);
                MySqlParameter paramHabitat = new MySqlParameter("@IdHabitat", a.IdHabitat);
                MySqlParameter paramFuncionario = new MySqlParameter("@IdFuncionario", a.IdFuncionario);
                dao.ExecuteNonQuery("INSERT INTO Animais (nomeAnimal,idade,especie,id_Animal,Habitat_id,id_Funcionario) VALUES (@Nome, @Idade, @especie,@id,@IdHabitat,@IdFuncionario)", paramNome, paramIdade, paramEspecie, paramId, paramHabitat, paramFuncionario);
            }
            catch( Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um animal." + ex.Message);
                throw ex;
            }
    
            
        }                           


        public void Remover(int id)//via ID
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                dao.ExecuteNonQuery("DELETE FROM Animais WHERE id_Pessoa = (@Id)", paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover o animal." + ex.Message);
                throw ex;
            }
        }
        

        public void AlterarNome(int id, string nome)//via ID mudar só o nome
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramNome = new MySqlParameter("@Nome", nome);
                dao.ExecuteNonQuery("UPDATE Animais SET nomeAnimal = @Nome WHERE id_Animal = (@Id)", paramNome, paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar o nome do animal. " + ex.Message);
                throw ex;
            }
        }

        public void AlterarEspecie(int id, string especie)//via ID mudar só a Especie
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramEspecie = new MySqlParameter("@Especie", especie);
                dao.ExecuteNonQuery("UPDATE Animais SET especie = @Especie WHERE id_Animal = (@Id)", paramEspecie, paramId);
            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao alterar a espécie.");
                throw ex;
            }
        }

        public void AlterarIdade(int id, int idade)//via ID mudar só a idade
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramIdade = new MySqlParameter("@Idade", idade);
                dao.ExecuteNonQuery("UPDATE Animais SET idade = @Idade WHERE id_Anial = (@Id)", paramIdade, paramId);
            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao alterar a idade do animal.");
                throw ex;
            }
        }


        public void Listar() //Falta Procurar por nome especifico
        {
            string connectionString = (@"server=sql10.freemysqlhosting.net;user id=sql10205465;password=2IrZ7R4mIS;database=sql10205465");
            string consulta = "SELECT * FROM Pessoa";
            MySqlConnection conexao = new MySqlConnection(connectionString);
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataReader dr = null;
            try
            {
                conexao.Open();                 // nomeAnimal,idade,especie,id_Animal,Habitat_id,id_Funcionario
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("{0}-{1} {2} anos, da especie:{3}, no Habitat:{4}, tratado pelo funcionario:{5}", dr["id_Animal"], dr["nomeAnimal"], dr["idade"], dr["especie"], dr["Habitat_id"], dr["id_Funcionario"]);
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
