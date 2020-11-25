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
    public partial class FrmConsultaCorrida : Form
    {
        CorridaDAO corridaDAO = new CorridaDAO();
        
        public FrmConsultaCorrida()
        {
            InitializeComponent();
            limparTextBox();
            listarTable();

            txtIdCorrida.Focus();
        }

        public void listarTable()
        {
            dgvConsultaCorrida.Enabled = true;
            // Pega os Id da tabela do banco de dados
            int count = corridaDAO.listarQuantidade();
            int index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (corridaDAO.listarCorrida(i) != null)
                {
                    Corrida corrida = corridaDAO.listarCorrida(i);

                    dgvConsultaCorrida.Rows.Add();

                    dgvConsultaCorrida.Rows[index].Cells[0].Value = corrida.getIdCorrida();
                    dgvConsultaCorrida.Rows[index].Cells[1].Value = corrida.getDtCorrida();
                    dgvConsultaCorrida.Rows[index].Cells[2].Value = corrida.getLocal();
                    dgvConsultaCorrida.Rows[index].Cells[3].Value = corrida.getDistancia();
                    index++;
                }
            }

            if (count == 0)
            {
                dgvConsultaCorrida.Enabled = false;
            }
        }

        public void limparTextBox()
        {
            txtIdCorrida.Text = String.Empty;
            txtData.Text = String.Empty;
            txtLocal.Text = String.Empty;
            txtDistancia.Text = String.Empty;
            
            txtIdCorrida.Focus();

            dgvConsultaCorrida.clearValuesGrid();

            txtIdCorrida.Enabled = false;
            txtData.Enabled = false;
            txtLocal.Enabled = false;
            txtDistancia.Enabled = false;
            
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dgvConsultaCorrida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhas = dgvConsultaCorrida.CurrentRow.Index;
            
            if (Utils.checkValuesDataGriView(dgvConsultaCorrida, linhas))
            {
                try
                {

                    txtIdCorrida.Text = dgvConsultaCorrida.Rows[linhas].Cells[0].Value.ToString().Trim();
                    txtData.Text = dgvConsultaCorrida.Rows[linhas].Cells[1].Value.ToString().Trim();
                    txtLocal.Text = dgvConsultaCorrida.Rows[linhas].Cells[2].Value.ToString().Trim();
                    txtDistancia.Text = dgvConsultaCorrida.Rows[linhas].Cells[3].Value.ToString().Trim();

                    txtIdCorrida.Enabled = true;
                    txtData.Enabled = true;
                    txtLocal.Enabled = true;
                    txtDistancia.Enabled = true;

                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível exibir os valores!");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdCorrida.Text);
                corridaDAO.excluirCorrida(id);

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
                Corrida corrida = new Corrida();

                corrida.setIdCorrida(int.Parse(txtIdCorrida.Text));

                corrida.setDtCorrida(txtData.Text);
                corrida.setLocal(txtLocal.Text);
                corrida.setDistancia(txtDistancia.Text);

                corridaDAO.alterarCorrida(corrida);

                limparTextBox();
                listarTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível editar os valores!");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvConsultaCorrida.Enabled = true;

            int codCorrida = 0;
            codCorrida = int.Parse(txtIdCorrida.Text);

            if (corridaDAO.listarCorrida(codCorrida) != null)
            {
                limparTextBox();

                Corrida corrida = corridaDAO.listarCorrida(codCorrida);

                dgvConsultaCorrida.Rows.Add();

                dgvConsultaCorrida.Rows[0].Cells[0].Value = corrida.getIdCorrida();
                dgvConsultaCorrida.Rows[0].Cells[1].Value = corrida.getDtCorrida();
                dgvConsultaCorrida.Rows[0].Cells[2].Value = corrida.getLocal();
                dgvConsultaCorrida.Rows[0].Cells[3].Value = corrida.getDistancia();
                
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
