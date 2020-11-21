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
    class CavaloDAO
    {
        SqlConnection conn;

        /// <summary>
        /// Inseri no banco de dados o <paramref name="cavalo"/>
        /// </summary>
        /// <param name="cavalo">
        /// Aposta com os seus gets e sets.
        /// </param>
        public void criarCavalo(Cavalo cavalo)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "insert into Cavalo (idDono, idCategoria, nome, idade) values (@idDono, @idCategoria, @nome, @idade)";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@idDono", SqlDbType.Int).Value = cavalo.getIdDono();
                cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = cavalo.getIdStatus();
                cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 100).Value = cavalo.getNome();
                cmd.Parameters.Add("@idade", SqlDbType.Int).Value = cavalo.getIdade();

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
        /// Retorna um ds com o idCavalo ou null
        /// </returns>
        public int listarQuantidade()
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select max(idcavalo) from Cavalo";

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
        /// Retorna na classe Cavalo todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe Cavalo</returns>
        public Cavalo listarCavalo(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select * from Cavalo where idCavalo = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Cavalo cavalo = new Cavalo();
                    cavalo.setIdCavalo(id);

                    cavalo.setIdCavalo(int.Parse(reader["idCavalo"].ToString()));
                    cavalo.setIdDono(int.Parse(reader["idDono"].ToString()));
                    cavalo.setIdStatus(int.Parse(reader["idCategoria"].ToString()));
                    cavalo.setNome(reader["nome"].ToString());
                    cavalo.setIdade(int.Parse(reader["idade"].ToString()));

                    return cavalo;
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
        public void excluirCavalo(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "delete from Cavalo where idCavalo = @id";

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
        /// Altera no banco de dados do Cavalo
        /// </summary>
        /// <param name="cavalo"></param>
        public void alterarCavalo(Cavalo cavalo)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "update Cavalo set idDono = @idDono, idCategoria = @idCategoria, nome = @nome, idade = @idade where idCavalo = @Id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = cavalo.getIdCavalo();
                cmd.Parameters.Add("@idDono", SqlDbType.Int).Value = cavalo.getIdDono();
                cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = cavalo.getIdStatus();
                cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 100).Value = cavalo.getNome();
                cmd.Parameters.Add("@idade", SqlDbType.Int).Value = cavalo.getIdade();

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
