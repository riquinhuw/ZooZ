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
                dao.ExecuteNonQuery("INSERT INTO ANIMAL (NOME_ANIMAL,IDADE_ANIMAL,ESPECIE_ANIMAL,ID_ANIMAL,ID_HABITAT,FUNCIONARIO_PESSOA_ID) VALUES (@Nome, @Idade, @especie,@id,@IdHabitat,@IdFuncionario)", paramNome, paramIdade, paramEspecie, paramId, paramHabitat, paramFuncionario);
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
                dao.ExecuteNonQuery("DELETE FROM ANIMAL WHERE FUNCIONARIO_PESSOA_ID = (@Id)", paramId);
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
                dao.ExecuteNonQuery("UPDATE ANIMAL SET NOME_ANIMAL = @Nome WHERE ID_ANIMAL = (@Id)", paramNome, paramId);
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
                dao.ExecuteNonQuery("UPDATE ANIMAL SET ESPECIE_ANIMAL = @Especie WHERE ID_ANIMAL = (@Id)", paramEspecie, paramId);
            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao alterar a espécie." + ex.Message);
                throw ex;
            }
        }

        public void AlterarIdade(int id, int idade)//via ID mudar só a idade
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramIdade = new MySqlParameter("@Idade", idade);
                dao.ExecuteNonQuery("UPDATE ANIMAL SET IDADE_ANIMAL = @Idade WHERE ID_ANIMAL = (@Id)", paramIdade, paramId);
            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao alterar a idade do animal." + ex.Message);
                throw ex;
            }
        }


        public void Listar() //Falta Procurar por nome especifico
        {
            string connectionString = (@"server= sql10.freemysqlhosting.net;user id=sql10207977;password=Dftua2hRb3;database=sql10207977");//fix it
            string consulta = "SELECT * FROM ANIMAL";
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
