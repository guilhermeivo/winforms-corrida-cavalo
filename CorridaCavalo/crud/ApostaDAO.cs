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
    class ApostaDAO
    {
        SqlConnection conn;

        /// <summary>
        /// Inseri no banco de dados o <paramref name="aposta"/>
        /// </summary>
        /// <param name="aposta">
        /// Aposta com os seus gets e sets.
        /// </param>
        public void criarApostador(Aposta aposta)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "insert into Aposta values (@id, @idc, @idco, @valor)";
            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = aposta.getIdApostador();
                cmd.Parameters.Add("@idc", SqlDbType.Int).Value = aposta.getIdCavalo();
                cmd.Parameters.Add("@idco", SqlDbType.Int).Value = aposta.getIdCorrida();
                cmd.Parameters.Add("@valor", SqlDbType.Int).Value = aposta.getValor();

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
        /// Retorna um ds com o idAposta ou null
        /// </returns>
        public int listarQuantidade()
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select max(idApostador) from Aposta";

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
        /// Retorna na classe Aposta todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe Aposta</returns>
        public Aposta listarAposta(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select * from Aposta where idApostador = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Aposta aposta = new Aposta();
                    aposta.setIdCorrida(id);

                    aposta.setIdApostador(int.Parse(reader["idApostador"].ToString()));
                    aposta.setIdCavalo(int.Parse(reader["idCavalo"].ToString()));
                    aposta.setIdCorrida(int.Parse(reader["idCorrida"].ToString()));
                    aposta.setValor(Convert.ToDouble(reader["valor"]));

                    return aposta;
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
        public void excluirAposta(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "delete from Aposta where idAposta = @id";

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
        /// Altera no banco de dados o Aposta
        /// </summary>
        /// <param name="aposta"></param>
        public void alterarAposta(Aposta aposta)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "update Aposta set idApostador = @id, idCavalo = @idc, idCorrida = @idco, valor = @valor where idApostador = @Id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = aposta.getIdApostador();
                cmd.Parameters.Add("@idc", SqlDbType.Int).Value = aposta.getIdCavalo();
                cmd.Parameters.Add("@idco", SqlDbType.Int).Value = aposta.getIdCorrida();
                cmd.Parameters.Add("@valor", SqlDbType.Money).Value = aposta.getValor(); //caso dê erro troque o money por double

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
