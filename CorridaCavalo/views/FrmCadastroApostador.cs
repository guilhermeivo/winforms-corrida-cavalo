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
    public partial class FrmCadastroApostador : Form
    {
        // Inicializa o apostadorDAO para poder usar os seus metodos
        ApostadorDAO apostadorDAO = new ApostadorDAO();
        public FrmCadastroApostador()
        {
            InitializeComponent();
        }

        private void btnCadatro_Click(object sender, EventArgs e)
        {
            // Inicializa o apostador para poder usar seus metodos {get, set}
            Apostador apostador = new Apostador();

            // Armazena os valores das textbox na classe apostador
            apostador.setNome(txtNome.Text);
            apostador.setTelefone(txtTelefone.Text);
            apostador.setEmail(txtEmail.Text);
            apostador.setValor(Convert.ToDouble(txtValor.Text));

            // Manda a classe Apostador para o método criarApostador onde armazena os dados no banco de dados
            apostadorDAO.criarApostador(apostador);

            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtValor.Clear();

            txtNome.Focus();
        }
    }
}
