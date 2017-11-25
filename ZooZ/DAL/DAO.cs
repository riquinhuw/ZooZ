﻿using MySql.Data.MySqlClient;
using System.Data;

namespace ZooZ
{
    public class DAO
    {
        // FALTA TESTAR!
        private string connectionString = @"server=127.0.0.1;user id=root;password=563009;database=zoologico";
        private MySqlConnection conexao;

        public MySqlConnection Conexao
        {
            get { return conexao; }
            set { conexao = value; }
        }

        public DAO()
        {
            conexao = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Executa um comando (INSERT, UPDATE, DELETE) no Banco de Dados.
        /// </summary>
        /// <param name="sql">Comando SQL a ser executado</param>
        /// <param name="parameters">Parâmetros MySQL</param>
        public void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            PrepareCommand(sql, parameters).ExecuteNonQuery(); ;
            conexao.Close();
        }

        /// <summary>
        /// Executa um comando de leitura (SELECT) no Banco de Dados 
        /// Lembre-se: Sempre feche a conexão!!!
        /// </summary>
        /// <param name="sql">Comando SQL a ser executado</param>
        /// <param name="parameters">Parâmetros MySQL</param>
        /// <returns>O Data Reader para ser lido.</returns>
        public MySqlDataReader ExecuteReader(string sql, params MySqlParameter[] parameters)
        {
            return PrepareCommand(sql, parameters).ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// Prepara o comando para a execução. 
        /// Lembre-se: Sempre feche a conexão!!!
        /// </summary>
        /// <param name="sql">Comando SQL a ser executado</param>
        /// <param name="parameters">Parâmetros MySQL</param>
        /// <returns>O comando SQL preparado para ser executado</returns>
        private MySqlCommand PrepareCommand(string sql, MySqlParameter[] parameters)
        {
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            if (parameters != null)
            {
                foreach (MySqlParameter item in parameters)
                {
                    comando.Parameters.Add(item);
                }
            }

            conexao.Open();
            return comando;
        }
    }
}
