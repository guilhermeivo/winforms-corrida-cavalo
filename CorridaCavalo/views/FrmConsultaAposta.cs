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
    public partial class FrmConsultaAposta : Form
    {
        ApostaDAO apostaDAO = new ApostaDAO();
        CavaloDAO cavaloDAO = new CavaloDAO();
        ApostadorDAO apostadorDAO = new ApostadorDAO();
        CorridaDAO corridaDAO = new CorridaDAO();

        Object[,] cavaloObject;
        Object[,] corridaObject;
        Object[,] apostadorObject;
        public FrmConsultaAposta()
        {
            InitializeComponent();

            limparTextBox();
            listarTable();

            cmbNomeApostador.Focus();
        }
        public void listarTable()
        {
            dgvConsultaAposta.Enabled = true;
            // Pega os Id da tabela do banco de dados
            int count = apostaDAO.listarQuantidade();
            int index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (apostaDAO.listarAposta(i) != null)
                {
                    Aposta aposta = apostaDAO.listarAposta(i);

                    dgvConsultaAposta.Rows.Add();

                    dgvConsultaAposta.Rows[index].Cells[0].Value = aposta.getIdAposta();
                    dgvConsultaAposta.Rows[index].Cells[1].Value = aposta.getIdApostador();
                    dgvConsultaAposta.Rows[index].Cells[3].Value = aposta.getIdCavalo();
                    dgvConsultaAposta.Rows[index].Cells[5].Value = aposta.getIdCorrida();
                    dgvConsultaAposta.Rows[index].Cells[7].Value = aposta.getValor();

                    Apostador apostador = apostadorDAO.listarApostador(aposta.getIdApostador());

                    dgvConsultaAposta.Rows[index].Cells[2].Value = apostador.getNome();

                    Cavalo cavalo = cavaloDAO.listarCavalo(aposta.getIdCavalo());

                    dgvConsultaAposta.Rows[index].Cells[4].Value = cavalo.getNome();

                    Corrida corrida = corridaDAO.listarCorrida(aposta.getIdCorrida());

                    dgvConsultaAposta.Rows[index].Cells[6].Value = corrida.getLocal();

                    index++;
                }
            }

            if (count == 0)
            {
                dgvConsultaAposta.Enabled = false;
            }
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
                        cmbCodCorrida.Text = Convert.ToString(corrida.getIdCorrida());
                    }

                    cmbCodCorrida.Items.Insert(index, Convert.ToString(corrida.getIdCorrida()));

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

            // Apostador
            // Pega os Id da tabela do banco de dados
            count = apostadorDAO.listarQuantidade();
            index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (apostadorDAO.listarApostador(i) != null)
                {
                    Apostador apostador = apostadorDAO.listarApostador(i);                    

                    cmbNomeApostador.Items.Insert(index, apostador.getNome());
                    
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
        }

        public void limparTextBox()
        {
            txtLocalizacao.Text = String.Empty;
            txtValor.Text = String.Empty;
            cmbNomeApostador.Text = String.Empty;
            cmbCodCorrida.Text = String.Empty;
            cmbNomeCavalo.Text = String.Empty;

            cmbNomeApostador.Items.Clear();
            cmbCodCorrida.Items.Clear();
            cmbNomeCavalo.Items.Clear();

            cmbNomeApostador.Focus();

            dgvConsultaAposta.clearValuesGrid();

            cmbNomeApostador.Enabled = false;
            cmbNomeCavalo.Enabled = false;
            cmbCodCorrida.Enabled = false;
            txtLocalizacao.Enabled = false;
            txtValor.Enabled = false;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dgvConsultaAposta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhas = dgvConsultaAposta.CurrentRow.Index;

            if (Utils.checkValuesDataGriView(dgvConsultaAposta, linhas))
            {
                try
                {
                    setComboBox();

                    txtCodAposta.Text = dgvConsultaAposta.Rows[linhas].Cells[0].Value.ToString().Trim();
                    cmbNomeApostador.Text = dgvConsultaAposta.Rows[linhas].Cells[2].Value.ToString();                    
                    cmbNomeCavalo.Text = dgvConsultaAposta.Rows[linhas].Cells[4].Value.ToString();
                    cmbCodCorrida.Text = dgvConsultaAposta.Rows[linhas].Cells[5].Value.ToString();
                    txtLocalizacao.Text = dgvConsultaAposta.Rows[linhas].Cells[6].Value.ToString().Trim();
                    txtValor.Text = dgvConsultaAposta.Rows[linhas].Cells[7].Value.ToString().Trim();

                    cmbNomeApostador.Enabled = true;
                    cmbNomeCavalo.Enabled = true;
                    cmbCodCorrida.Enabled = true;
                    txtValor.Enabled = true;

                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível exibir os valores!");
                }
            }
        }

        private void cmbCodCorrida_SelectedIndexChanged(object sender, EventArgs e)
        {
            Corrida corrida = new Corrida();

            for (int i = 0; i < corridaObject.Length / 2; i++)
            {
                if (Convert.ToString(corridaObject[i, 0]) == cmbCodCorrida.Text.ToString())
                {
                    corrida.setIdCorrida(Convert.ToInt32(corridaObject[i, 0]));
                }
            }

            txtLocalizacao.Text = corridaDAO.listarCorrida(corrida.getIdCorrida()).getLocal();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCodAposta.Text);
                apostaDAO.excluirAposta(id);

                limparTextBox();
                listarTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível excluir os valores!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Aposta aposta = new Aposta();

                aposta.setIdAposta(Convert.ToInt32(txtCodAposta.Text));
                
                for (int i = 0; i < cavaloObject.Length / 2; i++)
                {
                    if (Convert.ToString(cavaloObject[i, 1]) == cmbNomeCavalo.Text)
                    {
                        aposta.setIdCavalo(Convert.ToInt32(cavaloObject[i, 0]));
                    }
                }
                for (int i = 0; i < corridaObject.Length / 2; i++)
                {
                    if (Convert.ToString(corridaObject[i, 0]) == cmbCodCorrida.Text)
                    {
                        aposta.setIdCorrida(Convert.ToInt32(corridaObject[i, 0]));
                    }
                }
                for (int i = 0; i < apostadorObject.Length / 2; i++)
                {
                    if (Convert.ToString(apostadorObject[i, 1]) == cmbNomeApostador.Text)
                    {
                        aposta.setIdApostador(Convert.ToInt32(apostadorObject[i, 0]));
                    }
                }

                aposta.setValor(Convert.ToDouble(txtValor.Text));

                apostaDAO.alterarAposta(aposta);

                limparTextBox();
                listarTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível editar os valores!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dgvConsultaAposta.Enabled = true;

            int codAposta = 0;
            codAposta = int.Parse(txtCodAposta.Text);

            if (cavaloDAO.listarCavalo(codAposta) != null)
            {
                limparTextBox();

                Aposta aposta = apostaDAO.listarAposta(codAposta);

                dgvConsultaAposta.Rows[0].Cells[0].Value = aposta.getIdApostador();
                dgvConsultaAposta.Rows[0].Cells[2].Value = aposta.getIdCavalo();
                dgvConsultaAposta.Rows[0].Cells[4].Value = aposta.getIdCorrida();
                dgvConsultaAposta.Rows[0].Cells[6].Value = aposta.getValor();

                Apostador apostador = apostadorDAO.listarApostador(aposta.getIdApostador());

                dgvConsultaAposta.Rows[0].Cells[1].Value = apostador.getNome();

                Cavalo cavalo = cavaloDAO.listarCavalo(aposta.getIdCavalo());

                dgvConsultaAposta.Rows[0].Cells[3].Value = cavalo.getNome();

                Corrida corrida = corridaDAO.listarCorrida(aposta.getIdCorrida());

                dgvConsultaAposta.Rows[0].Cells[5].Value = corrida.getLocal();
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar!");
            }
        }
    }
}
