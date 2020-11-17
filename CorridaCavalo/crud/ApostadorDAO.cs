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
    class ApostadorDAO
    {
        SqlConnection conn = new SqlConnection("Password = 12345; Persist Security Info=True; User ID = sa; Initial Catalog = Cavalo; Data Source = " + Environment.MachineName);
        /// <summary>
        /// Inseri no banco de dados o <paramref name="apostador"/>
        /// </summary>
        /// <param name="apostador">
        /// Apostador com os seus gets e sets.
        /// </param>
        /// 

        public void criarApostador(Apostador apostador)
        {
            

            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    string queryString = "insert into Apostador (nome, telefone, email, valor) values (@nome, @telefone, @email, @valor)";

                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 100).Value = apostador.getNome();
                    cmd.Parameters.Add("@telefone", SqlDbType.NVarChar, 11).Value = apostador.getTelefone();
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = apostador.getEmail();
                    cmd.Parameters.Add("@valor", SqlDbType.Money).Value = apostador.getValor();

                    cmd.ExecuteScalar();
                    ConexionDataBase.fecharConexao();

                    MessageBox.Show("Registro inserido com sucesso!");
                }
                catch(Exception error)
                {
                    MessageBox.Show("Erro: " + error);
                }
                finally
                {
                    ConexionDataBase.fecharConexao();
                }
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
            

            if (conn.State == ConnectionState.Open)
            {     
                string queryString = "select max(idApostador) from Apostador";

                SqlCommand cmd = new SqlCommand(queryString, conn);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader[0]);
                        }
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
                    ConexionDataBase.fecharConexao();
                }
            } 
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Retorna na classe Apostador todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe Apostador</returns>
        public Apostador listarApostador(int id)
        {
            

            if (conn.State == ConnectionState.Open)
            {
                string queryString = "select * from Apostador where idApostador = @id";

                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Apostador apostador = new Apostador();
                        apostador.setIdApostador(id);

                        apostador.setIdApostador(int.Parse(reader[0].ToString()));
                        apostador.setNome(reader[1].ToString());
                        apostador.setTelefone(reader[2].ToString());
                        apostador.setEmail(reader[3].ToString());
                        apostador.setValor(Convert.ToDouble(reader[4].ToString()));

                        return apostador;
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
                    ConexionDataBase.fecharConexao();
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Exclui o valor no banco de dados dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        public void excluirApostador(int id)
        {
            

            if (conn.State == ConnectionState.Open)
            {
                string queryString = "delete from Apostador where idApostador = @id";

                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro excluído com sucesso!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error);
                }
                finally
                {
                    ConexionDataBase.fecharConexao();
                }
            }
        }

        /// <summary>
        /// Altera no banco de dados o Apostador
        /// </summary>
        /// <param name="apostador"></param>
        public void alterarApostador(Apostador apostador)
        {
            

            if (conn.State == ConnectionState.Open)
            {
                string queryString = "update Apostador set nome = @nome, Telefone = @telefone, Email = @Email, valor = @valor where idApostador = @Id";

                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = apostador.getIdApostador();
                cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 100).Value = apostador.getNome();
                cmd.Parameters.Add("@telefone", SqlDbType.NVarChar, 11).Value = apostador.getTelefone();
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = apostador.getEmail();
                cmd.Parameters.Add("@valor", SqlDbType.Money).Value = apostador.getValor();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro atualizado com sucesso!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error);
                }
                finally
                {
                    ConexionDataBase.fecharConexao();
                }
            }
        }
    }
}
