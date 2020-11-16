using CorridaCavalo.dao;
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

        public void listarTable()
        {
            DataSet ds = new DataSet();

            ds = apostadorDAO.listarQuantidade();

            for (int i = 0; i <= (int)(ds.Tables[0].Rows.Count) - 1; i++)
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
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linhas = dataGridView2.CurrentRow.Index;

            txtCodigo.Text = dataGridView2.Rows[linhas].Cells[0].Value.ToString();
            txtNome.Text = dataGridView2.Rows[linhas].Cells[1].Value.ToString();
            txtTelefone.Text = dataGridView2.Rows[linhas].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView2.Rows[linhas].Cells[3].Value.ToString();
            txtDinherio.Text = dataGridView2.Rows[linhas].Cells[4].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCodigo.Text);
            apostadorDAO.excluirApostador(id);

            limparTextBox();
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
    }
}
