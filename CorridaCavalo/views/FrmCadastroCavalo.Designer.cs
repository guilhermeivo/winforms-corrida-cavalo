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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeCav = new System.Windows.Forms.Label();
            this.lblNomeDono = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cmbDono = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro Cavalo";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtNome.Location = new System.Drawing.Point(310, 168);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNomeCav
            // 
            this.lblNomeCav.AutoSize = true;
            this.lblNomeCav.ForeColor = System.Drawing.Color.White;
            this.lblNomeCav.Location = new System.Drawing.Point(70, 172);
            this.lblNomeCav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCav.Name = "lblNomeCav";
            this.lblNomeCav.Size = new System.Drawing.Size(125, 20);
            this.lblNomeCav.TabIndex = 3;
            this.lblNomeCav.Text = "Nome do Cavalo";
            // 
            // lblNomeDono
            // 
            this.lblNomeDono.AutoSize = true;
            this.lblNomeDono.ForeColor = System.Drawing.Color.White;
            this.lblNomeDono.Location = new System.Drawing.Point(70, 249);
            this.lblNomeDono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeDono.Name = "lblNomeDono";
            this.lblNomeDono.Size = new System.Drawing.Size(48, 20);
            this.lblNomeDono.TabIndex = 4;
            this.lblNomeDono.Text = "Dono";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(72, 325);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(124, 20);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade do Cavalo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(72, 365);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 20);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtIdade.Location = new System.Drawing.Point(310, 319);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(148, 26);
            this.txtIdade.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(76, 483);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Casdastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(292, 483);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(112, 35);
            this.btnConsulta.TabIndex = 11;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // cmbDono
            // 
            this.cmbDono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cmbDono.FormattingEnabled = true;
            this.cmbDono.Location = new System.Drawing.Point(310, 237);
            this.cmbDono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDono.Name = "cmbDono";
            this.cmbDono.Size = new System.Drawing.Size(180, 28);
            this.cmbDono.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(310, 365);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(180, 28);
            this.cmbCategoria.TabIndex = 13;
            // 
            // FrmCadastroCavalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbDono);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNomeDono);
            this.Controls.Add(this.lblNomeCav);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCadastroCavalo";
            this.Text = "FrmCadastroCavalo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeCav;
        private System.Windows.Forms.Label lblNomeDono;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ComboBox cmbDono;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}