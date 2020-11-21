using CorridaCavalo.crud;
using CorridaCavalo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaCavalo
{
    public partial class FrmCadastroCavalo : Form
    {
        CavaloDAO cavaloDAO = new CavaloDAO();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        DonoDAO donoDAO = new DonoDAO();

        Object[,] categoriaObject;
        Object[,] donoObject;

        public FrmCadastroCavalo()
        {
            InitializeComponent();

            txtNomeCavalo.Focus();
            setComboBox();
        }

        private void setComboBox()
        {
            int count;
            int index;
            // Categoria
            // Pega os Id da tabela do banco de dados
            count = categoriaDAO.listarQuantidade();
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (categoriaDAO.listarCategoria(i) != null)
                {
                    Categoria categoria = categoriaDAO.listarCategoria(i);

                    if (index == 0)
                    {
                        cmbCategoria.Text = categoria.getDescCategoria(); ;
                    }

                    cmbCategoria.Items.Insert(index, categoria.getDescCategoria());

                    index++;
                }
            }

            categoriaObject = new Object[index, 2];
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (categoriaDAO.listarCategoria(i) != null)
                {
                    Categoria categoria = categoriaDAO.listarCategoria(i);

                    categoriaObject[index, 0] = categoria.getIdCategoria();
                    categoriaObject[index, 1] = categoria.getDescCategoria();

                    index++;
                }
            }

            // Dono
            // Pega os Id da tabela do banco de dados
            count = donoDAO.listarQuantidade();
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (donoDAO.listarDono(i) != null)
                {
                    Dono dono = donoDAO.listarDono(i);

                    if (index == 0)
                    {
                        cmbDono.Text = dono.getNome();
                    }

                    cmbDono.Items.Insert(index, dono.getNome());

                    index++;
                }
            }

            donoObject = new Object[index, 2];
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (donoDAO.listarDono(i) != null)
                {
                    Dono dono = donoDAO.listarDono(i);

                    donoObject[index, 0] = dono.getIdDono();
                    donoObject[index, 1] = dono.getNome();

                    index++;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializa o apostador para poder usar seus metodos {get, set}
                Cavalo cavalo = new Cavalo();

                // Armazena os valores das textbox na classe apostador
                cavalo.setNome(txtNomeCavalo.Text.Trim());
                cavalo.setIdade(int.Parse(txtIdade.Text.Trim()));

                for (int i = 0; i < categoriaObject.Length / 2; i++)
                {
                    if (Convert.ToString(categoriaObject[i, 1]) == cmbCategoria.Text.ToString())
                    {
                        cavalo.setIdStatus(Convert.ToInt32(categoriaObject[i, 0]));
                    }
                }
                for (int i = 0; i < donoObject.Length / 2; i++)
                {
                    if (Convert.ToString(donoObject[i, 1]) == cmbDono.Text.ToString())
                    {
                        cavalo.setIdDono(Convert.ToInt32(donoObject[i, 0]));
                    }
                }

                // Manda a classe Apostador para o método criarApostador onde armazena os dados no banco de dados
                cavaloDAO.criarCavalo(cavalo);

                txtNomeCavalo.Clear();
                txtIdade.Clear();

                txtNomeCavalo.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível cadastrar!");
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bntConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
