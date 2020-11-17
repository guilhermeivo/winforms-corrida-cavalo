using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaCavalo.crud
{
    class ConexionDataBase
    {
        /// <summary>String para conectar no banco.</summary>
        private static string connString = "Password=12345; Persist Security Info=True; User ID=sa; Initial Catalog=Cavalo; Data Source=" + Environment.MachineName;
        /// <summary>Representa a conexão com o banco.</summary>
        private static SqlConnection conn = null;

        /// <summary>
        /// Método que permite obter a conexão.
        /// </summary>
        /// <returns>
        /// conn, tipo SqlConnection.
        /// </returns>
        public static SqlConnection obterConexao()
        {
            try
            {
                conn = new SqlConnection(connString);

                conn.Open();
            }
            catch (SqlException sqle)
            {
                conn = null;

                MessageBox.Show("Erro: " + sqle);
            }

            return conn;
        }

        /// <summary>
        /// Método que permite fechar a conexão.
        /// </summary>
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}

