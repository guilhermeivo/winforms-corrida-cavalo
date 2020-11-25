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

namespace CorridaCavalo.views
{
    public partial class FrmCadastroAposta : Form
    {
        ApostaDAO apostaDAO = new ApostaDAO();
        CavaloDAO cavaloDAO = new CavaloDAO();
        ApostadorDAO apostadorDAO = new ApostadorDAO();
        CorridaDAO corridaDAO = new CorridaDAO();

        Object[,] cavaloObject;
        Object[,] apostadorObject;
        Object[,] corridaObject;
        public FrmCadastroAposta()
        {
            InitializeComponent();

            txtValor.Focus();
            setComboBox();
        }

        private void setComboBox()
        {
            int count;
            int index;
            // Cavalo
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
                        cmbCavalo.Text = cavalo.getNome();
                    }

                    cmbCavalo.Items.Insert(index, cavalo.getNome());

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

            // apostador
            // Pega os Id da tabela do banco de dados
            count = apostadorDAO.listarQuantidade();
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (apostadorDAO.listarApostador(i) != null)
                {
                    Apostador apostador = apostadorDAO.listarApostador(i);

                    if (index == 0)
                    {
                        cmbApostador.Text = apostador.getNome();
                    }

                    cmbApostador.Items.Insert(index, apostador.getNome());

                    index++;
                }
            }

            apostadorObject = new Object[index, 2];
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (apostadorDAO.listarApostador(i) != null)
                {
                    Apostador apostador = apostadorDAO.listarApostador(i);

                    apostadorObject[index, 0] = apostador.getIdApostador();
                    apostadorObject[index, 1] = apostador.getNome();

                    index++;
                }
            }

            // Corrida
            // Pega os Id da tabela do banco de dados
            count = corridaDAO.listarQuantidade();
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (corridaDAO.listarCorrida(i) != null)
                {
                    Corrida corrida = corridaDAO.listarCorrida(i);

                    if (index == 0)
                    {
                        cmbCorrida.Text = corrida.getLocal();
                    }

                    cmbCorrida.Items.Insert(index, corrida.getLocal());

                    index++;
                }
            }

            corridaObject = new Object[index, 2];
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (corridaDAO.listarCorrida(i) != null)
                {
                    Corrida corrida = corridaDAO.listarCorrida(i);

                    corridaObject[index, 0] = corrida.getIdCorrida();
                    corridaObject[index, 1] = corrida.getLocal();

                    index++;
                }
            }
        }

        private void btnCadatro_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializa o apostador para poder usar seus metodos {get, set}
                Aposta aposta = new Aposta();

                // Armazena os valores das textbox na classe apostador
                aposta.setValor(Double.Parse(txtValor.Text.Trim()));

                for (int i = 0; i < apostadorObject.Length / 2; i++)
                {
                    if (Convert.ToString(apostadorObject[i, 1]) == cmbApostador.Text.ToString())
                    {
                        aposta.setIdApostador(Convert.ToInt32(apostadorObject[i, 0]));
                    }
                }
                for (int i = 0; i < cavaloObject.Length / 2; i++)
                {
                    if (Convert.ToString(cavaloObject[i, 1]) == cmbCavalo.Text.ToString())
                    {
                        aposta.setIdCavalo(Convert.ToInt32(cavaloObject[i, 0]));
                    }
                }
                for (int i = 0; i < corridaObject.Length / 2; i++)
                {
                    if (Convert.ToString(corridaObject[i, 1]) == cmbCorrida.Text.ToString())
                    {
                        aposta.setIdCorrida(Convert.ToInt32(corridaObject[i, 0]));
                    }
                }

                // Manda a classe Apostador para o método criarApostador onde armazena os dados no banco de dados
                apostaDAO.criarAposta(aposta);

                txtValor.Clear();
               
                txtValor.Focus();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
