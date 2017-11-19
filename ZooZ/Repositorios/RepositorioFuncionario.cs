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
        public void Inserir(Funcionario f)
        {

            MySqlParameter paramNome = new MySqlParameter("@Nome", f.Nome);
            MySqlParameter paramCpf = new MySqlParameter("@Cpf", f.Cpf);
            MySqlParameter paramIdade = new MySqlParameter("@Idade", f.Idade);
            MySqlParameter paramMatricula = new MySqlParameter("@Matricula", f.Matricula);
            dao.ExecuteNonQuery("INSERT INTO Pessoa (nome,idade,cpf,id_Pessoa) VALUES (@Nome, @Idade, @Cpf,@Matricula)", paramNome, paramIdade, paramCpf, paramMatricula);
        }


        public void Remover(int id)//via ID
        {
            MySqlParameter paramId = new MySqlParameter("@Id", id);
            dao.ExecuteNonQuery("DELETE FROM Pessoa WHERE id_Pessoa = (@Id)", paramId);
        }

        public void AlterarNome(int id, string nome)//via ID mudar só o nome
        {
            MySqlParameter paramId = new MySqlParameter("@Id", id);
            MySqlParameter paramNome = new MySqlParameter("@Nome", nome);
            dao.ExecuteNonQuery("UPDATE Pessoa SET nomePessoa = @Nome WHERE id_Pessoa = (@Id)", paramNome, paramId);

        }

        public void AlterarCpf(int id, int cpf)//via ID mudar só o cpf
        {
            MySqlParameter paramId = new MySqlParameter("@Id", id);
            MySqlParameter paramCpf = new MySqlParameter("@cpf", cpf);
            dao.ExecuteNonQuery("UPDATE Pessoa SET cpf = @Nome WHERE id_Pessoa = (@Id)", paramCpf, paramId);

        }

        public void AlterarIdade(int id, int idade)//via ID mudar só a idade
        {
            MySqlParameter paramId = new MySqlParameter("@Id", id);
            MySqlParameter paramIdade = new MySqlParameter("@cpf", idade);
            dao.ExecuteNonQuery("UPDATE Pessoa SET idade = @Nome WHERE id_Pessoa = (@Id)", paramIdade, paramId);

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
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("{0}-{1} {2} anos, CPF:{3}", dr["id_Pessoa"], dr["nome"], dr["idade"],dr["cpf"]);
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
