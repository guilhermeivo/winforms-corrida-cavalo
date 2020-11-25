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
    public partial class FrmConsultaAposta : Form
    {
        ApostaDAO apostaDAO = new ApostaDAO();
        CavaloDAO cavaloDAO = new CavaloDAO();
        ApostadorDAO apostadorDAO = new ApostadorDAO();
        CorridaDAO corridaDAO = new CorridaDAO();

        Object[,] cavaloObject;
        Object[,] apostadorObject;
        Object[,] corridaOject;
        public FrmConsultaAposta()
        {
            InitializeComponent();

            limparTextBox();
            listarTable();

            txtValor.Focus();
        }
        public void listarTable()
        {
            
        }

        public void limparTextBox()
        {

        }
    }
}
