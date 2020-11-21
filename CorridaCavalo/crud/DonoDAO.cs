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
    class DonoDAO
    {
        SqlConnection conn;

        /// <summary>
        /// Inseri no banco de dados o <paramref name="dono"/>
        /// </summary>
        /// <param name="dono">
        /// Apostador com os seus gets e sets.
        /// </param>
        public void criarDono(Dono dono)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "insert into Dono (nomedn, telefone, email) values (@nome, @telefone, @email)";
            try
            {               
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 100).Value = dono.getNome();
                cmd.Parameters.Add("@telefone", SqlDbType.NVarChar, 20).Value = dono.getTelefone();
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 80).Value = dono.getEmail();

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
        /// Retorna um ds com o idApostador ou null
        /// </returns>
        public int listarQuantidade()
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select max(idDono) from Dono";

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
        /// Retorna na classe Dono todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe Dono</returns>
        public Dono listarDono(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select * from Dono where idDono = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Dono dono = new Dono();
                    dono.setIdDono(id);

                    dono.setIdDono(int.Parse(reader["idDono"].ToString()));
                    dono.setNome(reader["nomedn"].ToString());
                    dono.setTelefone(reader["telefone"].ToString());
                    dono.setEmail(reader["email"].ToString());

                    return dono;
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
        public void excluirDono(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "delete from Dono where idDono = @id";

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
        /// Altera no banco de dados o Dono
        /// </summary>
        /// <param name="dono"></param>
        public void alterarDono(Dono dono)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "update Dono set nome = @nome, telefone = @telefone, email = @Email where idDono = @Id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = dono.getIdDono();
                cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 100).Value = dono.getNome();
                cmd.Parameters.Add("@telefone", SqlDbType.NVarChar, 20).Value = dono.getTelefone();
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 80).Value = dono.getEmail();

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
