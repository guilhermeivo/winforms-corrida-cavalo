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
    public partial class FrmConsultaApostador : Form
    {
        ApostadorDAO apostadorDAO = new ApostadorDAO();
        public FrmConsultaApostador()
        {
            InitializeComponent();
            listarTable();
        }

        /// <summary>
        /// Coloca no dataGridView todos os valores do banco de dados e deixa visivel os banco de editar e excluir
        /// </summary>
        public void listarTable()
        {
            DataSet ds = new DataSet();

            // Pega os Id da tabela do banco de dados
            ds = apostadorDAO.listarQuantidade();
            // Pega a quantidade de registros no banco de dados
            int quantidade = ds.Tables[0].Rows.Count - 1;

            for (int i = 0; i <= quantidade; i++)
            {
                Apostador apostador = apostadorDAO.listarApostador((int)(ds.Tables[0].Rows[i][0]));

                dataGridView2.Rows.Add();

                dataGridView2.Rows[i].Cells[0].Value = apostador.getIdApostador();
                dataGridView2.Rows[i].Cells[1].Value = apostador.getNome();
                dataGridView2.Rows[i].Cells[2].Value = apostador.getTelefone();
                dataGridView2.Rows[i].Cells[3].Value = apostador.getEmail();
                dataGridView2.Rows[i].Cells[4].Value = apostador.getValor();
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

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].DataGridView.Rows.Clear();
            }

            listarTable();

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linhas = dataGridView2.CurrentRow.Index;

            try
            {
                txtCodigo.Text = dataGridView2.Rows[linhas].Cells[0].Value.ToString();
                txtNome.Text = dataGridView2.Rows[linhas].Cells[1].Value.ToString();
                txtTelefone.Text = dataGridView2.Rows[linhas].Cells[2].Value.ToString();
                txtEmail.Text = dataGridView2.Rows[linhas].Cells[3].Value.ToString();
                txtDinherio.Text = dataGridView2.Rows[linhas].Cells[4].Value.ToString();

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            catch(Exception error)
            {
                MessageBox.Show("Não foi possível exibir os valores!");
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCodigo.Text);
                apostadorDAO.excluirApostador(id);

                limparTextBox();
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
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível editar os valores!");
            }
        }
    }
}
