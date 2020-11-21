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
        /// Retorna um ds com o idCategoria ou null
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
        /// Retorna na classe Categoria todos os seus valores dependo do <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a classe categoria</returns>
        public Categoria listarCategoria(int id)
        {
            conn = ConnexionDataBase.obterConexao();

            try
            {
                Categoria categoria = new Categoria();
                // Codigo
                // ...
                // ...
                // ...

                return categoria;
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
        /// Altera no banco de dados a Categoria
        /// </summary>
        /// <param name="categoria"></param>
        public void alterarCategoria(Categoria categoria)
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
