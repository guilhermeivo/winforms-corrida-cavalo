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
        /// Retorna um ds com o idCavalo ou null
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
        /// Retorna na classe Cavalo todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe Cavalo</returns>
        public Cavalo listarCavalo(int id)
        {
            conn = ConnexionDataBase.obterConexao();

            try
            {
                Cavalo cavalo = new Cavalo();
                // Codigo
                // ...
                // ...
                // ...

                return cavalo;
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
        /// Altera no banco de dados do Cavalo
        /// </summary>
        /// <param name="cavalo"></param>
        public void alterarCavalo(Cavalo cavalo)
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
