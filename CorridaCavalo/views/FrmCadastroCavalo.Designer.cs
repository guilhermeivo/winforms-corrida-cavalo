namespace CorridaCavalo
{
    partial class FrmCadastroCavalo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDono = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.bntConsultar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadatro = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNomeCavalo = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNomeDono = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNomeCavalo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDivisionSideMenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDono
            // 
            this.cmbDono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cmbDono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDono.ForeColor = System.Drawing.Color.White;
            this.cmbDono.FormattingEnabled = true;
            this.cmbDono.Location = new System.Drawing.Point(365, 145);
            this.cmbDono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDono.Name = "cmbDono";
            this.cmbDono.Size = new System.Drawing.Size(247, 28);
            this.cmbDono.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.ForeColor = System.Drawing.Color.White;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(34, 220);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(180, 28);
            this.cmbCategoria.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelDivisionSideMenu);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 594);
            this.panel1.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnFechar);
            this.panel5.Controls.Add(this.cmbCategoria);
            this.panel5.Controls.Add(this.cmbDono);
            this.panel5.Controls.Add(this.bntConsultar);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btnCadatro);
            this.panel5.Controls.Add(this.txtIdade);
            this.panel5.Controls.Add(this.txtNomeCavalo);
            this.panel5.Controls.Add(this.lblIdade);
            this.panel5.Controls.Add(this.lblNomeDono);
            this.panel5.Controls.Add(this.lblCategoria);
            this.panel5.Controls.Add(this.lblNomeCavalo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(718, 590);
            this.panel5.TabIndex = 25;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(210, 524);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(148, 35);
            this.btnFechar.TabIndex = 34;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // bntConsultar
            // 
            this.bntConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.bntConsultar.Enabled = false;
            this.bntConsultar.FlatAppearance.BorderSize = 0;
            this.bntConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntConsultar.ForeColor = System.Drawing.Color.White;
            this.bntConsultar.Location = new System.Drawing.Point(534, 524);
            this.bntConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntConsultar.Name = "bntConsultar";
            this.bntConsultar.Size = new System.Drawing.Size(148, 35);
            this.bntConsultar.TabIndex = 33;
            this.bntConsultar.Text = "Consultar";
            this.bntConsultar.UseVisualStyleBackColor = false;
            this.bntConsultar.Click += new System.EventHandler(this.bntConsultar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 85);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(718, 1);
            this.panel7.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(718, 85);
            this.panel6.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cadastro Cavalo";
            // 
            // btnCadatro
            // 
            this.btnCadatro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCadatro.FlatAppearance.BorderSize = 0;
            this.btnCadatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadatro.ForeColor = System.Drawing.Color.White;
            this.btnCadatro.Location = new System.Drawing.Point(372, 524);
            this.btnCadatro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadatro.Name = "btnCadatro";
            this.btnCadatro.Size = new System.Drawing.Size(148, 35);
            this.btnCadatro.TabIndex = 30;
            this.btnCadatro.Text = "Cadastrar";
            this.btnCadatro.UseVisualStyleBackColor = false;
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdade.ForeColor = System.Drawing.Color.White;
            this.txtIdade.Location = new System.Drawing.Point(37, 292);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(148, 26);
            this.txtIdade.TabIndex = 29;
            // 
            // txtNomeCavalo
            // 
            this.txtNomeCavalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtNomeCavalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCavalo.ForeColor = System.Drawing.Color.White;
            this.txtNomeCavalo.Location = new System.Drawing.Point(34, 145);
            this.txtNomeCavalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeCavalo.Name = "txtNomeCavalo";
            this.txtNomeCavalo.Size = new System.Drawing.Size(278, 26);
            this.txtNomeCavalo.TabIndex = 26;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(33, 267);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(50, 20);
            this.lblIdade.TabIndex = 25;
            this.lblIdade.Text = "Saldo";
            // 
            // lblNomeDono
            // 
            this.lblNomeDono.AutoSize = true;
            this.lblNomeDono.ForeColor = System.Drawing.Color.White;
            this.lblNomeDono.Location = new System.Drawing.Point(363, 120);
            this.lblNomeDono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeDono.Name = "lblNomeDono";
            this.lblNomeDono.Size = new System.Drawing.Size(116, 20);
            this.lblNomeDono.TabIndex = 24;
            this.lblNomeDono.Text = "Nome do Dono";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(33, 195);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 20);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNomeCavalo
            // 
            this.lblNomeCavalo.AutoSize = true;
            this.lblNomeCavalo.ForeColor = System.Drawing.Color.White;
            this.lblNomeCavalo.Location = new System.Drawing.Point(30, 120);
            this.lblNomeCavalo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCavalo.Name = "lblNomeCavalo";
            this.lblNomeCavalo.Size = new System.Drawing.Size(125, 20);
            this.lblNomeCavalo.TabIndex = 22;
            this.lblNomeCavalo.Text = "Nome do Cavalo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(2, 592);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 2);
            this.panel4.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(718, 2);
            this.panel3.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(720, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 594);
            this.panel2.TabIndex = 22;
            // 
            // panelDivisionSideMenu
            // 
            this.panelDivisionSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelDivisionSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDivisionSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelDivisionSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDivisionSideMenu.Name = "panelDivisionSideMenu";
            this.panelDivisionSideMenu.Size = new System.Drawing.Size(2, 594);
            this.panelDivisionSideMenu.TabIndex = 21;
            // 
            // FrmCadastroCavalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCadastroCavalo";
            this.Text = "FrmCadastroCavalo";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDono;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button bntConsultar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadatro;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNomeCavalo;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNomeDono;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNomeCavalo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDivisionSideMenu;
    }
}