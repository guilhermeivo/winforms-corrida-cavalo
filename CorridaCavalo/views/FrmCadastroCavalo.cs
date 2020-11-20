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
    public partial class FrmCadastroCavalo : Form
    {
        CavaloDAO cavaloDAO = new CavaloDAO();
        public FrmCadastroCavalo()
        {
            InitializeComponent();

            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cavalo cavalo = new Cavalo();

                cavalo.setNome(txtNome.Text.Trim());
                cavalo.setIdade(Convert.ToInt32(txtIdade.Text.Trim()));

            ///CavaloDAO ainda não foi codificado ;-;
                cavaloDAO.criarCavalo(cavalo);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível cadastrar!");
            }
        }
    }
}
