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
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbDono = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro Cavalo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(221, 109);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNomeCav
            // 
            this.lblNomeCav.AutoSize = true;
            this.lblNomeCav.ForeColor = System.Drawing.Color.White;
            this.lblNomeCav.Location = new System.Drawing.Point(47, 112);
            this.lblNomeCav.Name = "lblNomeCav";
            this.lblNomeCav.Size = new System.Drawing.Size(86, 13);
            this.lblNomeCav.TabIndex = 3;
            this.lblNomeCav.Text = "Nome do Cavalo";
            // 
            // lblNomeDono
            // 
            this.lblNomeDono.AutoSize = true;
            this.lblNomeDono.ForeColor = System.Drawing.Color.White;
            this.lblNomeDono.Location = new System.Drawing.Point(47, 162);
            this.lblNomeDono.Name = "lblNomeDono";
            this.lblNomeDono.Size = new System.Drawing.Size(33, 13);
            this.lblNomeDono.TabIndex = 4;
            this.lblNomeDono.Text = "Dono";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(48, 211);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(85, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade do Cavalo";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(48, 254);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(221, 211);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Casdastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Consultas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbDono
            // 
            this.cmbDono.FormattingEnabled = true;
            this.cmbDono.Location = new System.Drawing.Point(221, 154);
            this.cmbDono.Name = "cmbDono";
            this.cmbDono.Size = new System.Drawing.Size(121, 21);
            this.cmbDono.TabIndex = 12;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(221, 265);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 13;
            // 
            // FrmCadastroCavalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbDono);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNomeDono);
            this.Controls.Add(this.lblNomeCav);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbDono;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}