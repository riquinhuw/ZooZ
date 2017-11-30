using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZ.Repositorios
{
    class RepositorioFuncionario
    {
        private DAO dao = new DAO();
        public void Inserir(Funcionario f)//FALTA ARRUMAR
        {
            //meio de retornar o ID
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(ID_PESSOA) FROM PESSOA", dao.Conexao);
            
            try
            {
                int inteiro;
                MySqlParameter paramNome = new MySqlParameter("@Nome", f.Nome);
                MySqlParameter paramCpf = new MySqlParameter("@Cpf", f.Cpf);
                MySqlParameter paramIdade = new MySqlParameter("@Idade", f.Idade);
                dao.ExecuteNonQuery("INSERT INTO PESSOA (NOME_PESSOA,IDADE,CPF) VALUES (@Nome, @Idade, @Cpf)", paramNome, paramIdade, paramCpf);
                dao.Conexao.Open();
                inteiro = Convert.ToInt32(cmd.ExecuteScalar());
                dao.Conexao.Close();
                MySqlParameter paramSetor = new MySqlParameter("@Setor", f.Setor);
                MySqlParameter paramCargo = new MySqlParameter("@Cargo", f.Cargo);
                MySqlParameter paramMatricula = new MySqlParameter("@Matricula", inteiro);
                MySqlParameter paramIdPessoa = new MySqlParameter("@IdPessoa", inteiro);
                dao.ExecuteNonQuery("INSERT INTO FUNCIONARIO (SETOR_FUNCIONARIO,CARGO_FUNCIONARIO,MATRICULA_FUNCIONARIO,ID_PESSOA) VALUES (@Setor, @Cargo, @Matricula,@IdPessoa)", paramSetor, paramCargo, paramMatricula, paramIdPessoa);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir um funcionário" + ex.Message);
                throw ex;
            }

        }

        public void Remover(int id)//via ID
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                dao.ExecuteNonQuery("DELETE FROM FUNCIONARIO WHERE ID_PESSOA = (@Id)", paramId);
                dao.ExecuteNonQuery("DELETE FROM PESSOA WHERE ID_PESSOA = (@Id)", paramId);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover o funcionário " + ex.Message);
                throw ex;
            }
        }

        public void AlterarNome(int id, string nome)//via ID mudar só o nome
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramNome = new MySqlParameter("@Nome", nome);
                dao.ExecuteNonQuery("UPDATE PESSOA SET NOME_PESSOA = @Nome WHERE ID_PESSOA = (@Id)", paramNome, paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar o nome do funcionário." + ex.Message);
                throw ex;
            }
        }

        public void AlterarCpf(int id, int cpf)//via ID mudar só o cpf
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramCpf = new MySqlParameter("@cpf", cpf);
                dao.ExecuteNonQuery("UPDATE PESSOA SET CPF = @Nome WHERE ID_PESSOA = (@Id)", paramCpf, paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar o cpf do funcionário." + ex.Message);
                throw ex;
            }
        }

        public void AlterarIdade(int id, int idade)//via ID mudar só a idade
        {
            try
            {
                MySqlParameter paramId = new MySqlParameter("@Id", id);
                MySqlParameter paramIdade = new MySqlParameter("@cpf", idade);
                dao.ExecuteNonQuery("UPDATE PESSOA SET ID_PESSOA = @Nome WHERE ID_PESSOA = (@Id)", paramIdade, paramId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao alterar a idade do funcionário." + ex.Message);
                throw ex;
            }
        }


        public void Listar() //Falta Procurar por nome especifico
        {

            string connectionString = (@"server= sql10.freemysqlhosting.net;user id=sql10207977;password=Dftua2hRb3;database=sql10207977");
            string consulta = "SELECT sql10207977.PESSOA.ID_PESSOA, sql10207977.PESSOA.NOME_PESSOA, sql10207977.PESSOA.IDADE, sql10207977.PESSOA.CPF,sql10207977.FUNCIONARIO.CARGO_FUNCIONARIO,sql10207977.FUNCIONARIO.SETOR_FUNCIONARIO FROM sql10207977.PESSOA, sql10207977.FUNCIONARIO WHERE sql10207977.PESSOA.ID_PESSOA = sql10207977.FUNCIONARIO.MATRICULA_FUNCIONARIO";
            MySqlConnection conexao = new MySqlConnection(connectionString);
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("{0}-{1} {2} anos, CPF:{3} -- Cargo:{4},Setor:{5}", dr["ID_PESSOA"], dr["NOME_PESSOA"], dr["IDADE"],dr["CPF"],dr["CARGO_FUNCIONARIO"],dr["SETOR_FUNCIONARIO"]);
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
