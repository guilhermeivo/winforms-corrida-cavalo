using CorridaCavalo.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CorridaCavalo.crud
{
    class CorridaCavaloDAO
    {
        SqlConnection conn;

        /// <summary>
        /// Inseri no banco de dados o <paramref name="corridaCavalo"/>
        /// </summary>
        /// <param name="corridaCavalo">
        /// Aposta com os seus gets e sets.
        /// </param>
        public void criarCorridaCavalo(CoridaCavalo cc)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "insert into CorridaCavalo values (@id, @idc)";
            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cc.getIdCavalo();
                cmd.Parameters.Add("@idc", SqlDbType.Int).Value = cc.getIdCorrida();

                cmd.ExecuteScalar();

                MessageBox.Show("Registro inserido com sucesso!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro: " + error);
            }
            finally
            {
                ConnexionDataBase.fecharConexao();
            }
        }

        /// <summary>
        /// Retorna na classe CorridaCavalo todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe CorridaCavalo</returns>
        public CoridaCavalo listarCorridaCavalo(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select * from CorridaCavalo where idCavalo = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CoridaCavalo cc = new CoridaCavalo();
                    cc.setIdCorrida(id);

                    cc.setIdCorrida(int.Parse(reader["idCorrida"].ToString()));
                    cc.setIdCavalo(int.Parse(reader["idCavalo"].ToString()));

                    return cc;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro: " + error);

                return null;
            }
            finally
            {
                ConnexionDataBase.fecharConexao();
            }
        }

        /// <summary>
        /// Exclui o valor no banco de dados dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        public void excluirCorridaCavalo(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "delete from CorridaCavalo where idCavalo = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro: " + error);
            }
            finally
            {
                ConnexionDataBase.fecharConexao();
            }
        }
    }
}
