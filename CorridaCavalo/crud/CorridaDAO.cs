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
    class CorridaDAO
    {
        SqlConnection conn;

        /// <summary>
        /// Inseri no banco de dados o <paramref name="corrida"/>
        /// </summary>
        /// <param name="corrida">
        /// Aposta com os seus gets e sets.
        /// </param>
        public void criarCorrida(Corrida corrida)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "insert into Corrida values (@data, @local, @distancia)";
            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = corrida.getDtCorrida();
                cmd.Parameters.Add("@local", SqlDbType.NVarChar, 30).Value = corrida.getLocal();
                cmd.Parameters.Add("@distancia", SqlDbType.NVarChar, 9).Value = corrida.getDistancia ();

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
        /// Lista a quantidade da cadastros no banco de dados
        /// </summary>
        /// <returns>
        /// Retorna um ds com o idCorrida ou null
        /// </returns>
        public int listarQuantidade()
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select max(idCorrida) from Corrida";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows && reader.Read() && reader[0] != DBNull.Value)
                {
                    return Convert.ToInt32(reader[0]);
                }

                return 0;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro: " + error);

                return 0;
            }
            finally
            {
                ConnexionDataBase.fecharConexao();
            }
        }

        /// <summary>
        /// Retorna na classe Corrida todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe Corrida</returns>
        public Corrida listarCorrida(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select * from Corrida where idCorrida = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Corrida corrida = new Corrida();
                    corrida.setIdCorrida(id);

                    corrida.setIdCorrida(int.Parse(reader["idCorrida"].ToString()));
                    corrida.setDtCorrida(reader["dt_Corrida"].ToString());
                    corrida.setLocal(reader["local_"].ToString());
                    corrida.setDistancia(reader["distancia"].ToString());

                    return corrida;
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
        public void excluirCorrida(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "delete from Corrida where idCorrida = @id";

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

        /// <summary>
        /// Altera no banco de dados a Corrida
        /// </summary>
        /// <param name="corrida"></param>
        public void alterarCorrida(Corrida corrida)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "update Corrida set dt_Corrida = @data, local_ = @local, distancia = @distancia where idCorrida = @Id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = corrida.getIdCorrida();
                cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = corrida.getDtCorrida();
                cmd.Parameters.Add("@local", SqlDbType.NVarChar, 30).Value = corrida.getLocal();
                cmd.Parameters.Add("@distancia", SqlDbType.NVarChar, 9).Value = corrida.getDistancia();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro atualizado com sucesso!");
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
