using System;
using System.Collections.Generic;
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
        public void criarApostador(ApostaDAO aposta)
        {
            conn = ConnexionDataBase.obterConexao();

            try
            {
                // Codigo
                // ...
                // ...
                // ...

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

            try
            {
                // Codigo
                // ...
                // ...
                // ...

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
        public ApostaDAO listarAposta(int id)
        {
            conn = ConnexionDataBase.obterConexao();

            try
            {
                ApostaDAO aposta = new ApostaDAO();
                // Codigo
                // ...
                // ...
                // ...

                return aposta;
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

            try
            {
                // Codigo
                // ...
                // ...
                // ...
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
        public void alterarAposta(ApostaDAO aposta)
        {
            conn = ConnexionDataBase.obterConexao();

            try
            {
                // Codigo
                // ...
                // ...
                // ...
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
