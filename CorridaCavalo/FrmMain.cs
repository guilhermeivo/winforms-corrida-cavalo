using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaCavalo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            customizedMenu();  
        }

        #region configuração-formsMain

        // Estado do formulario
        bool StateFormMaximized = false;

        Color ActiveBorderColor = Color.FromArgb(8, 109, 227); // Roxo
        Color InactiveBorderColor = Color.FromArgb(240, 240, 240); // Cinza

        private void FormMain_Activated(object sender, EventArgs e)
        {
            SetBorderColor(ActiveBorderColor);
            SetButtonWindowImage(true);
        }

        private void FormMain_Deactivate(object sender, EventArgs e)
        {
            SetButtonWindowImage(false);
            SetBorderColor(InactiveBorderColor);
        }

        public void SetButtonWindowImage(bool active = true)
        {
            if (active)
            {
                btnClose.BackgroundImage = Properties.Resources.close;
                btnMaximized.BackgroundImage = Properties.Resources.maximize;
                btnMinimize.BackgroundImage = Properties.Resources.minimize;
            }
            else
            {
                btnClose.BackgroundImage = Properties.Resources.close_unfocused;
                btnMaximized.BackgroundImage = Properties.Resources.maximize_unfocused;
                btnMinimize.BackgroundImage = Properties.Resources.minimize_unfocused;
            }
        }
        // Definir as cores das bordas de resize
        public void SetBorderColor(Color color)
        {
            panelBottomCorner.BackColor = color;
            panelBottomRightCorner.BackColor = color;
            panelBottomLeftCorner.BackColor = color;
            panelTopCorner.BackColor = color;
            panelTopRightCorner.BackColor = color;
            panelTopLeftCorner.BackColor = color;
            panelLeftCorner.BackColor = color;
            panelRightPanel.BackColor = color;
        }
        // Deixar visivil as bordas de resize
        public void SetBorderVisible(bool value)
        {
            panelBottomCorner.Visible = value;
            panelBottomRightCorner.Visible = value;
            panelBottomLeftCorner.Visible = value;
            panelTopCorner.Visible = value;
            panelTopRightCorner.Visible = value;
            panelTopLeftCorner.Visible = value;
            panelLeftCorner.Visible = value;
            panelRightPanel.Visible = value;
        }
        // btnClose
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // btnMaximized
        private void btnMaximized_MouseUp(object sender, MouseEventArgs e)
        {
            btnMaximized.BackgroundImage = Properties.Resources.maximize;
        }
        private void btnMaximized_MouseDown(object sender, MouseEventArgs e)
        {
            btnMaximized.BackgroundImage = Properties.Resources.maximize_pressed;
        }
        private void btnMaximized_MouseHover(object sender, EventArgs e)
        {
            btnMaximized.BackgroundImage = Properties.Resources.maximize_prelight;
        }
        private void btnMaximized_MouseLeave(object sender, EventArgs e)
        {
            btnMaximized.BackgroundImage = Properties.Resources.maximize;
        }
        private void btnMaximized_Click(object sender, EventArgs e)
        {
            ChangeSize();
        }
        //btnMinimize
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
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // panelHeader - Movimentations
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
                if (StateFormMaximized)
                {
                    ChangeSize();
                }
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownHeader = false;
        }
        private void panelHeader_DoubleClick(object sender, EventArgs e)
        {
            ChangeSize();
        }
        Size lastSize;
        Point lastPosition;
        public void ChangeSize()
        {
            if (StateFormMaximized)
            {
                this.Size = lastSize;
                this.Location = lastPosition;
                SetBorderVisible(true);

                StateFormMaximized = false;
            }
            else
            {
                lastSize = this.Size;
                lastPosition = this.Location;

                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = new Point(0, 0);
                SetBorderVisible(false);

                StateFormMaximized = true;
            }
        }

        int Mx; // mouseX
        int My; // mouseY
        int Sw; // sizeWidth
        int Sh; // sizeHeight

        bool mov;
        private void panelCorner_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void panelCorner_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = this.Width;
            Sh = this.Height;
        }

        private void panelLeftCorner_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                ResizerWindow(1);
            }
        }
        private void panelBottomLeftCorner_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                ResizerWindow(5);
            }
        }

        private void panelBottomCorner_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                ResizerWindow(4);
            }
        }
        public void ResizerWindow(int side)
        {
            switch (side)
            {
                case 1: // left
                    this.Width = MousePosition.X - Mx + Sw;

                    break;
                case 4: // bottom
                    this.Height = MousePosition.Y - My + Sh;

                    break;
                case 5: // bottom-left
                    this.Width = MousePosition.X - Mx + Sw;
                    this.Height = MousePosition.Y - My + Sh;

                    break;
            }
        }
        #endregion

        #region configuração-menu
        private void customizedMenu()
        {
            panelCadastrarSubmenu.Visible = false;
            panelConsultaSubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelCadastrarSubmenu.Visible)
            {
                panelCadastrarSubmenu.Visible = false;
            }
            if (panelConsultaSubmenu.Visible)
            {
                panelConsultaSubmenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void setColorButtonMenu(Panel panelButton)
        {
            panelHome.BackColor = Color.FromArgb(12, 255, 255, 255);
            panelCadastrar.BackColor = Color.FromArgb(12, 255, 255, 255);
            panelCorrida.BackColor = Color.FromArgb(12, 255, 255, 255);
            panelConsulta.BackColor = Color.FromArgb(12, 255, 255, 255);
            panelAjuda.BackColor = Color.FromArgb(12, 255, 255, 255);
            panelSair.BackColor = Color.FromArgb(12, 255, 255, 255);

            panelButton.BackColor = Color.FromArgb(8, 109, 227);
        }
        // btnCadastrar
        private void btnCadastrarCavalo_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCadastroCavalo());
            hideSubMenu();
        }
        private void btnCadastrarApostador_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCadastroApostador());
            hideSubMenu();
        }

        private void cadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            hideSubMenu();
            showSubMenu(panelCadastrarSubmenu);
            setColorButtonMenu(panelCadastrar);            
        }
        // btnHome
        private void panelHome_MouseClick(object sender, MouseEventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            setColorButtonMenu(panelHome);
            hideSubMenu();
        }
        // btnCorrida
        private void panelCorrida_MouseClick(object sender, MouseEventArgs e)
        {
            openChildForm(new FrmCorrida());
            setColorButtonMenu(panelCorrida);
            hideSubMenu();
        }
        // btnConsulta
        private void panelConsulta_MouseClick(object sender, MouseEventArgs e)
        {
            setColorButtonMenu(panelConsulta);
            showSubMenu(panelConsultaSubmenu);
        }
        private void btnConsultaCavalo_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConsultaCavalo());
            hideSubMenu();
        }

        private void btnConsultaApostador_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConsultaApostador()); 
            hideSubMenu();
        }
        private void btnConsultaCorrida_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConsultaApostador());
            hideSubMenu();
        }
        // btnAjuda
        private void panelAjuda_MouseClick(object sender, MouseEventArgs e)
        {
            // A classe fornece acesso a processos locais e remotos (como uma url)
            // Ele está abrindo no navegador padrão
            Process.Start("https://github.com/guilhermeivo/winforms-corrida-cavalo");
            setColorButtonMenu(panelAjuda);
            hideSubMenu();
        }
        // btnSair
        private void panelSair_MouseClick(object sender, MouseEventArgs e)
        {
            Form FLogin = new FrmLogin();
            this.Hide();
            FLogin.ShowDialog();
            setColorButtonMenu(panelSair);
            hideSubMenu();
        }

        // openChildForm
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

    }
}
