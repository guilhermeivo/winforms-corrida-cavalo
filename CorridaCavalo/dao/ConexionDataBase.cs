using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaCavalo.dao
{
    class ConexionDataBase
    {
        private static string connString = "Server = localhost; Database = vendas; Uid = root; Pwd = 161810";

        // representa a conexão com o banco
        private static SqlConnection conn = null;

        // método que permite obter a conexão
        public static SqlConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new SqlConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (SqlException sqle)
            {
                conn = null;

                MessageBox.Show("Erro: " + sqle);
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
