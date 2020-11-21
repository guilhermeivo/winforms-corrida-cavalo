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
    public partial class FrmCadastroDono : Form
    {
        // Inicializa o apostadorDAO para poder usar os seus metodos
        DonoDAO donoDAO = new DonoDAO();
        public FrmCadastroDono()
        {
            InitializeComponent();

            txtNome.Focus();
        }

        private void btnCadatro_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializa o apostador para poder usar seus metodos {get, set}
                Dono dono = new Dono();

                // Armazena os valores das textbox na classe apostador
                dono.setNome(txtNome.Text.Trim());
                dono.setEmail(txtEmail.Text.Trim());
                dono.setTelefone(txtTelefone.TextNoFormating().Trim());


                // Manda a classe Dono para o método criarApostador onde armazena os dados no banco de dados
                donoDAO.criarDono(dono);

                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();                

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
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
