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
    public partial class FrmCadastroApostador : Form
    {
        // Inicializa o apostadorDAO para poder usar os seus metodos
        ApostadorDAO apostadorDAO = new ApostadorDAO();
        public FrmCadastroApostador()
        {
            InitializeComponent();

            txtNome.Focus();
        }

        private void btnCadatro_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializa o apostador para poder usar seus metodos {get, set}
                Apostador apostador = new Apostador();

                // Armazena os valores das textbox na classe apostador
                apostador.setNome(txtNome.Text.Trim());
                apostador.setTelefone(txtTelefone.Text.Trim());
                apostador.setEmail(txtEmail.Text.Trim());
                apostador.setValor(Convert.ToDouble(txtValor.Text.Trim()));

                // Manda a classe Apostador para o método criarApostador onde armazena os dados no banco de dados
                apostadorDAO.criarApostador(apostador);

                txtNome.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                txtValor.Clear();

                txtNome.Focus();
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
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
