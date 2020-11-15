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
        ApostadorDAO apostadorDAO = new ApostadorDAO();
        public FrmCadastroApostador()
        {
            InitializeComponent();
        }

        private void btnCadatro_Click(object sender, EventArgs e)
        {
            Apostador apostador = new Apostador();

            apostador.setNome(txtNome.Text);
            apostador.setTelefone(txtTelefone.Text);
            apostador.setEmail(txtEmail.Text);
            apostador.setValor(Convert.ToDouble(txtValor.Text));

            apostadorDAO.criarApostador(apostador);

            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtValor.Clear();

            txtNome.Focus();
        }
    }
}
