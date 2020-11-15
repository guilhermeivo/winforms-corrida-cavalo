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
            this.txtDono = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
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
            this.lblNomeDono.Size = new System.Drawing.Size(79, 13);
            this.lblNomeDono.TabIndex = 4;
            this.lblNomeDono.Text = "Nome do Dono";
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
            // txtDono
            // 
            this.txtDono.Location = new System.Drawing.Point(221, 162);
            this.txtDono.Name = "txtDono";
            this.txtDono.Size = new System.Drawing.Size(100, 20);
            this.txtDono.TabIndex = 7;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(221, 211);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(221, 254);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // FrmCadastroCavalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtDono);
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
        private System.Windows.Forms.TextBox txtDono;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtStatus;
    }
}