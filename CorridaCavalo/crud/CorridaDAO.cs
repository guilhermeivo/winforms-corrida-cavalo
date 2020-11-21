using CorridaCavalo.model;
using System;
using System.Collections.Generic;
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
        /// Retorna um ds com o idCorrida ou null
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
        /// Retorna na classe Corrida todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe Corrida</returns>
        public Corrida listarCorrida(int id)
        {
            conn = ConnexionDataBase.obterConexao();

            try
            {
                Corrida corrida = new Corrida();
                // Codigo
                // ...
                // ...
                // ...

                return corrida;
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
        /// Altera no banco de dados a Corrida
        /// </summary>
        /// <param name="corrida"></param>
        public void alterarCorrida(Corrida corrida)
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
