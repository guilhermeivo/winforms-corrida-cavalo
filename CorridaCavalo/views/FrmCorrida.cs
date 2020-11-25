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
    public partial class FrmCorrida : Form
    {
        CorridaDAO corridaDAO = new CorridaDAO();
        CavaloDAO cavaloDAO = new CavaloDAO();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        CorridaCavaloDAO corridaCavaloDAO = new CorridaCavaloDAO();

        Object[,] cavaloObject;
        
        public FrmCorrida()
        {
            InitializeComponent();

            txtdtCorrida.Focus();
            setComboBox();
        }

        private void setComboBox()
        {
            int count;
            int index;
            // Categoria
            // Pega os Id da tabela do banco de dados
            count = cavaloDAO.listarQuantidade();
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (cavaloDAO.listarCavalo(i) != null)
                {
                    Cavalo cavalo = cavaloDAO.listarCavalo(i);

                    if (index == 0)
                    {
                        cmbNomeCavalo.Text = cavalo.getNome();
                    }

                    cmbNomeCavalo.Items.Insert(index, cavalo.getNome());
                    

                    index++;
                }
            }

            cavaloObject = new Object[index, 2];
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (cavaloDAO.listarCavalo(i) != null)
                {
                    Cavalo cavalo = cavaloDAO.listarCavalo(i);

                    cavaloObject[index, 0] = cavalo.getIdCavalo();
                    cavaloObject[index, 1] = cavalo.getNome();

                    index++;
                }
            }
            
        }

        private void cmbNomeCavalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cavalo cavalo = new Cavalo();

            for (int i = 0; i < cavaloObject.Length / 2; i++)
            {
                if (Convert.ToString(cavaloObject[i, 1]) == cmbNomeCavalo.Text.ToString())
                {
                    cavalo.setIdCavalo(Convert.ToInt32(cavaloObject[i, 0]));
                }
            }

            txtIdade.Text = Convert.ToString(cavaloDAO.listarCavalo(cavalo.getIdCavalo()).getIdade());
            txtCat.Text = Convert.ToString(categoriaDAO.listarCategoria(cavaloDAO.listarCavalo(cavalo.getIdCavalo()).getIdStatus()).getDescCategoria());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cavalo cavalo = new Cavalo();

            for (int i = 0; i < cavaloObject.Length / 2; i++)
            {
                if (Convert.ToString(cavaloObject[i, 1]) == cmbNomeCavalo.Text)
                {
                    cavalo.setIdCavalo(Convert.ToInt32(cavaloObject[i, 0]));
                }
            }
            Cavalo cavaloRes = cavaloDAO.listarCavalo(cavalo.getIdCavalo());

            if (dgvCavalo.Rows.Count - 1 < 13)
            {
                dgvCavalo.Rows.Insert(
                     0, // linha index
                     cavaloRes.getIdCavalo(),
                     cavaloRes.getNome(),
                     cavaloRes.getIdade(),
                     categoriaDAO.listarCategoria(
                         cavaloDAO.listarCavalo(
                             cavaloRes.getIdCavalo()
                         ).getIdStatus()
                     ).getDescCategoria()
                );
            }
            else
            {
                MessageBox.Show("Limite de cavalos atingido para a corrida: máximo de 13");
            }             
        }

        private void btnCadatro_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializa o apostador para poder usar seus metodos {get, set}
                Corrida corrida = new Corrida();
                CoridaCavalo coridaCavalo = new CoridaCavalo();

                // Armazena os valores das textbox na classe apostador
                corrida.setDtCorrida(txtdtCorrida.Text.Trim());
                corrida.setDistancia(txtDistancia.Text.Trim());
                corrida.setLocal(txtLocal.Text.Trim());

                // Manda a classe Apostador para o método criarApostador onde armazena os dados no banco de dados
                corridaDAO.criarCorrida(corrida);

                for (int i = 0; i < dgvCavalo.Rows.Count - 1; i++)
                {
                    coridaCavalo.setIdCavalo(int.Parse(dgvCavalo.Rows[i].Cells[0].Value.ToString()));
                    coridaCavalo.setIdCorrida(corridaDAO.listarQuantidade());

                    corridaCavaloDAO.criarCorridaCavalo(coridaCavalo);
                }

                dgvCavalo.clearValuesGrid();

                txtdtCorrida.Clear();
                txtDistancia.Clear();
                txtLocal.Clear();

                txtIdade.Clear();
                txtCat.Clear();

                txtdtCorrida.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível cadastrar!");
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
