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
    public partial class FrmConsultaCavalo : Form
    {
        // Inicializa o apostadorDAO para poder usar os seus metodos
        CavaloDAO cavaloDAO = new CavaloDAO();
        DonoDAO donoDAO = new DonoDAO();
        CategoriaDAO categoriaDAO = new CategoriaDAO();

        Object[,] categoriaObject;
        Object[,] donoObject;

        public FrmConsultaCavalo()
        {
            InitializeComponent();

            limparTextBox();
            listarTable();

            txtCodigoCavalo.Focus();
        }

        /// <summary>
        /// Coloca no dataGridView todos os valores do banco de dados e deixa visivel os banco de editar e excluir
        /// </summary>
        public void listarTable()
        {
            dgvConsultaCavalo.Enabled = true;
            // Pega os Id da tabela do banco de dados
            int count = cavaloDAO.listarQuantidade();
            int index = 0;

            for (int i = 0; i <= count; i++)
            {
                if (cavaloDAO.listarCavalo(i) != null)
                {
                    Cavalo cavalo = cavaloDAO.listarCavalo(i);                    

                    dgvConsultaCavalo.Rows.Add();

                    dgvConsultaCavalo.Rows[index].Cells[0].Value = cavalo.getIdCavalo();
                    dgvConsultaCavalo.Rows[index].Cells[1].Value = cavalo.getIdDono();
                    dgvConsultaCavalo.Rows[index].Cells[2].Value = cavalo.getNome();
                    dgvConsultaCavalo.Rows[index].Cells[3].Value = cavalo.getIdade();

                    Categoria categoria = categoriaDAO.listarCategoria(cavalo.getIdStatus());

                    dgvConsultaCavalo.Rows[index].Cells[4].Value = categoria.getDescCategoria();

                    Dono dono = donoDAO.listarDono(cavalo.getIdDono());

                    dgvConsultaCavalo.Rows[index].Cells[5].Value = dono.getNome();
                    dgvConsultaCavalo.Rows[index].Cells[6].Value = dono.getTelefone();
                    dgvConsultaCavalo.Rows[index].Cells[7].Value = dono.getEmail();

                    index++;
                }
            }

            if (count == 0)
            {
                dgvConsultaCavalo.Enabled = false;
            }
        }
        public void limparTextBox()
        {
            txtCodigoCavalo.Text = String.Empty;
            txtNomeCavalo.Text = String.Empty;
            txtIdade.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            cmbCategoria.Text = String.Empty;
            cmbNomeDono.Text = String.Empty;

            cmbCategoria.Items.Clear();
            cmbNomeDono.Items.Clear();

            txtCodigoCavalo.Focus();

            dgvConsultaCavalo.clearValuesGrid();

            txtNomeCavalo.Enabled = false;
            txtIdade.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            cmbCategoria.Enabled = false;
            cmbNomeDono.Enabled = false;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        private void dgvConsultaCavalo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linhas = dgvConsultaCavalo.CurrentRow.Index;
            cmbCategoria.Items.Clear();
            cmbNomeDono.Items.Clear();

            if (Utils.checkValuesDataGriView(dgvConsultaCavalo, linhas))
            {
                try
                {
                    setComboBox();

                    txtCodigoCavalo.Text = dgvConsultaCavalo.Rows[linhas].Cells[0].Value.ToString().Trim();
                    txtNomeCavalo.Text = dgvConsultaCavalo.Rows[linhas].Cells[2].Value.ToString().Trim();
                    txtIdade.Text = dgvConsultaCavalo.Rows[linhas].Cells[3].Value.ToString().Trim();
                    cmbCategoria.Text = dgvConsultaCavalo.Rows[linhas].Cells[4].Value.ToString();
                    cmbNomeDono.Text = dgvConsultaCavalo.Rows[linhas].Cells[5].Value.ToString();

                    Dono dono = donoDAO.listarDono(int.Parse(dgvConsultaCavalo.Rows[linhas].Cells[1].Value.ToString()));

                    txtTelefone.Text = dono.getTelefone();
                    txtEmail.Text = dono.getEmail();

                    txtNomeCavalo.Enabled = true;
                    txtIdade.Enabled = true;
                    cmbCategoria.Enabled = true;
                    cmbNomeDono.Enabled = true;

                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível exibir os valores!");
                }
            }
        }        
        private void cmbNomeDono_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dono dono = new Dono();

            for (int i = 0; i < donoObject.Length / 2; i++)
            {
                if (Convert.ToString(donoObject[i, 1]) == cmbNomeDono.Text.ToString())
                {
                    dono.setIdDono(Convert.ToInt32(donoObject[i, 0]));
                }
            }

            txtTelefone.Text = donoDAO.listarDono(dono.getIdDono()).getTelefone();
            txtEmail.Text = donoDAO.listarDono(dono.getIdDono()).getEmail();
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
                        cmbCategoria.Text = categoria.getDescCategoria();
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
                        cmbNomeDono.Text = dono.getNome();
                    }

                    cmbNomeDono.Items.Insert(index, dono.getNome());

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCodigoCavalo.Text);
                cavaloDAO.excluirCavalo(id);

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
                Cavalo cavalo = new Cavalo();

                cavalo.setIdCavalo(int.Parse(txtCodigoCavalo.Text));

                for (int i = 0; i < categoriaObject.Length / 2; i++)
                {
                    if (Convert.ToString(categoriaObject[i, 1]) == cmbCategoria.Text)
                    {
                        cavalo.setIdStatus(Convert.ToInt32(categoriaObject[i, 0]));
                    }
                }
                for (int i = 0; i < donoObject.Length / 2; i++)
                {
                    if (Convert.ToString(donoObject[i, 1]) == cmbNomeDono.Text)
                    {
                        cavalo.setIdDono(Convert.ToInt32(donoObject[i, 0]));
                    }
                }

                cavalo.setNome(txtNomeCavalo.Text);
                cavalo.setIdade(int.Parse(txtIdade.Text));

                cavaloDAO.alterarCavalo(cavalo);

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
            dgvConsultaCavalo.Enabled = true;

            int codCavalo = 0;
            codCavalo = int.Parse(txtCodigoCavalo.Text);

            if (cavaloDAO.listarCavalo(codCavalo) != null)
            {
                limparTextBox();

                Cavalo cavalo = cavaloDAO.listarCavalo(codCavalo);

                dgvConsultaCavalo.Rows.Add();

                dgvConsultaCavalo.Rows[0].Cells[0].Value = cavalo.getIdCavalo();
                dgvConsultaCavalo.Rows[0].Cells[1].Value = cavalo.getIdDono();
                dgvConsultaCavalo.Rows[0].Cells[2].Value = cavalo.getNome();
                dgvConsultaCavalo.Rows[0].Cells[3].Value = cavalo.getIdade();

                Categoria categoria = categoriaDAO.listarCategoria(cavalo.getIdStatus());

                dgvConsultaCavalo.Rows[0].Cells[4].Value = categoria.getDescCategoria();

                Dono dono = donoDAO.listarDono(cavalo.getIdDono());

                dgvConsultaCavalo.Rows[0].Cells[5].Value = dono.getNome();
                dgvConsultaCavalo.Rows[0].Cells[6].Value = dono.getTelefone();
                dgvConsultaCavalo.Rows[0].Cells[7].Value = dono.getEmail();
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
