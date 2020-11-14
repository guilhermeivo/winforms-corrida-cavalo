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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "admin") && (txtSenha.Text == "123"))
            {
                this.Hide();

                Form FMain = new FrmMain();
                FMain.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Clear();
                txtSenha.Clear();
            }
        }

        #region configuração-formlogin
        private void FormLogin_Activated(object sender, EventArgs e)
        {
            SetButtonWindowImage(true);
        }

        private void FormLogin_Deactivate(object sender, EventArgs e)
        {
            SetButtonWindowImage(false);
        }

        #region btnClose methods
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClose_MouseUp(object sender, MouseEventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close;
        }
        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_pressed;
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_prelight;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close;
        }
        #endregion
        #region btnMinimize methods
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMinimize_MouseUp(object sender, MouseEventArgs e)
        {
            btnMinimize.BackgroundImage = Properties.Resources.minimize;
        }
        private void btnMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            btnMinimize.BackgroundImage = Properties.Resources.minimize_pressed;
        }
        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.BackgroundImage = Properties.Resources.minimize_prelight;
        }
        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackgroundImage = Properties.Resources.minimize;
        }
        #endregion
        #region panelHeader methods
        bool mouseDownHeader;
        Point lastLocation;
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownHeader = true;
            lastLocation = e.Location;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownHeader)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }
        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownHeader = false;
        }
        #endregion

        /// <summary>
        /// Altera as imagens dos botões da Window (close, maximize, minimize) dependo do <paramref name="active"/>.
        /// </summary>
        /// <param name="active">
        /// Estado do Window.
        /// </param>
        public void SetButtonWindowImage(bool active = true)
        {
            if (active)
            {
                btnClose.BackgroundImage = Properties.Resources.close;
                btnMinimize.BackgroundImage = Properties.Resources.minimize;
            }
            else
            {
                btnClose.BackgroundImage = Properties.Resources.close_unfocused;
                btnMinimize.BackgroundImage = Properties.Resources.minimize_unfocused;
            }
        }
        #endregion
    }
}
