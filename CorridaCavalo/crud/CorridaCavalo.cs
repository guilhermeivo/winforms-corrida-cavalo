using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaCavalo.crud
{
    class CorridaCavalo
    {
        SqlConnection conn;

        /// <summary>
        /// Inseri no banco de dados o <paramref name="corridaCavalo"/>
        /// </summary>
        /// <param name="corridaCavalo">
        /// Aposta com os seus gets e sets.
        /// </param>
        public void criarCorridaCavalo(CorridaCavalo corridaCavalo)
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
        /// Retorna um ds com o idCorridaCavalo ou null
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
        /// Retorna na classe CorridaCavalo todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe CorridaCavalo</returns>
        public CorridaCavalo listarCorridaCavalo(int id)
        {
            conn = ConnexionDataBase.obterConexao();

            try
            {
                CorridaCavalo corridaCavalo = new CorridaCavalo();
                // Codigo
                // ...
                // ...
                // ...

                return corridaCavalo;
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
        /// Altera no banco de dados o CorridaCavalo
        /// </summary>
        /// <param name="corridaCavalo"></param>
        public void alterarCorridaCavalo(CorridaCavalo corrida)
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
