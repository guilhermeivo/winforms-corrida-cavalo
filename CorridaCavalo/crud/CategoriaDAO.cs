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
    class CategoriaDAO
    {
        SqlConnection conn;

        /// <summary>
        /// Inseri no banco de dados o <paramref name="categoria"/>
        /// </summary>
        /// <param name="categoria">
        /// Categoria com os seus gets e sets.
        /// </param>
        public void criarCategoria(Categoria categoria)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "insert into Categoria (descr) values (@descr)";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@descr", SqlDbType.NVarChar, 200).Value = categoria.getDescCategoria();

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
        /// Retorna um ds com o idCategoria ou null
        /// </returns>
        public int listarQuantidade()
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select max(idCategoria) from Categoria";

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
        /// Retorna na classe Categoria todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe categoria</returns>
        public Categoria listarCategoria(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "select * from Categoria where idCategoria = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.setIdCategoria(id);

                    categoria.setIdCategoria(int.Parse(reader["idCategoria"].ToString()));
                    categoria.setDescCategoria(reader["descr"].ToString());

                    return categoria;
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
        public void excluirCategoria(int id)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "delete from Categoria where idCategoria = @id";

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
        /// Altera no banco de dados a Categoria
        /// </summary>
        /// <param name="categoria"></param>
        public void alterarCategoria(Categoria categoria)
        {
            conn = ConnexionDataBase.obterConexao();
            string queryString = "update Categoria set descr = @descr where idCategoria = @Id";

            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = categoria.getIdCategoria();
                cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 200).Value = categoria.getDescCategoria();

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
