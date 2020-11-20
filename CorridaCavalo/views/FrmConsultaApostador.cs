using CorridaCavalo.crud;
using CorridaCavalo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaCavalo
{
    public partial class FrmConsultaApostador : Form
    {
        ApostadorDAO apostadorDAO = new ApostadorDAO();
        public FrmConsultaApostador()
        {
            InitializeComponent();

            limparTextBox();
            listarTable();

            txtCodigo.Focus();
        }

        /// <summary>
        /// Coloca no dataGridView todos os valores do banco de dados e deixa visivel os banco de editar e excluir
        /// </summary>
        public void listarTable()
        {
            dgvConsultaApostador.Enabled = true;
            // Pega os Id da tabela do banco de dados
            int count = apostadorDAO.listarQuantidade();
            int index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (apostadorDAO.listarApostador(i) != null)
                {
                    Apostador apostador = apostadorDAO.listarApostador(i);

                    dgvConsultaApostador.Rows.Add();

                    dgvConsultaApostador.Rows[index].Cells[0].Value = apostador.getIdApostador();
                    dgvConsultaApostador.Rows[index].Cells[1].Value = apostador.getNome();
                    dgvConsultaApostador.Rows[index].Cells[2].Value = apostador.getTelefone();
                    dgvConsultaApostador.Rows[index].Cells[3].Value = apostador.getEmail();
                    dgvConsultaApostador.Rows[index].Cells[4].Value = apostador.getValor();

                    index++;
                }
            }

            if (count == 0)
            {
                dgvConsultaApostador.Enabled = false;
            }
        }
        public void limparTextBox()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtDinherio.Text = String.Empty;

            txtCodigo.Focus();

            for (int i = 0; i < dgvConsultaApostador.RowCount; i++)
            {
                dgvConsultaApostador.Rows[i].DataGridView.Rows.Clear();
            }            

            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtDinherio.Enabled = false;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linhas = dgvConsultaApostador.CurrentRow.Index;

            if (dgvConsultaApostador.Rows[linhas].Cells[0].Value != null ||
                    dgvConsultaApostador.Rows[linhas].Cells[1].Value != null ||
                    dgvConsultaApostador.Rows[linhas].Cells[2].Value != null ||
                    dgvConsultaApostador.Rows[linhas].Cells[3].Value != null ||
                    dgvConsultaApostador.Rows[linhas].Cells[4].Value != null)
            {
                try
                {


                    txtCodigo.Text = dgvConsultaApostador.Rows[linhas].Cells[0].Value.ToString().Trim();
                    txtNome.Text = dgvConsultaApostador.Rows[linhas].Cells[1].Value.ToString().Trim();
                    txtTelefone.Text = dgvConsultaApostador.Rows[linhas].Cells[2].Value.ToString().Trim();
                    txtEmail.Text = dgvConsultaApostador.Rows[linhas].Cells[3].Value.ToString().Trim();
                    txtDinherio.Text = dgvConsultaApostador.Rows[linhas].Cells[4].Value.ToString().Trim();

                    txtNome.Enabled = true;
                    txtTelefone.Enabled = true;
                    txtEmail.Enabled = true;
                    txtDinherio.Enabled = true;

                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Não foi possível exibir os valores!");
                }
            }        
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCodigo.Text);
                apostadorDAO.excluirApostador(id);

                limparTextBox();
                listarTable();
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível excluir os valores!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Apostador apostador = new Apostador();

                apostador.setIdApostador(int.Parse(txtCodigo.Text));
                apostador.setNome(txtNome.Text);
                apostador.setTelefone(txtTelefone.Text);
                apostador.setEmail(txtEmail.Text);
                apostador.setValor(Convert.ToDouble(txtDinherio.Text));

                apostadorDAO.alterarApostador(apostador);

                limparTextBox();
                listarTable();
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível editar os valores!");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvConsultaApostador.Enabled = true;           

            int codApostador = 0;
            codApostador = int.Parse(txtCodigo.Text);

            if (apostadorDAO.listarApostador(codApostador) != null)
            {
                limparTextBox();

                Apostador apostador = apostadorDAO.listarApostador(codApostador);

                dgvConsultaApostador.Rows.Add();
                
                dgvConsultaApostador.Rows[0].Cells[0].Value = apostador.getIdApostador();
                dgvConsultaApostador.Rows[0].Cells[1].Value = apostador.getNome();
                dgvConsultaApostador.Rows[0].Cells[2].Value = apostador.getTelefone();
                dgvConsultaApostador.Rows[0].Cells[3].Value = apostador.getEmail();
                dgvConsultaApostador.Rows[0].Cells[4].Value = apostador.getValor();
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar!");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
