namespace CorridaCavalo
{
    partial class FrmCadastroApostador
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblDindin = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCadatro = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro apostador";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(76, 108);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(80, 149);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Telefone";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(80, 196);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 13);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "email";
            // 
            // lblDindin
            // 
            this.lblDindin.AutoSize = true;
            this.lblDindin.ForeColor = System.Drawing.Color.White;
            this.lblDindin.Location = new System.Drawing.Point(80, 236);
            this.lblDindin.Name = "lblDindin";
            this.lblDindin.Size = new System.Drawing.Size(77, 13);
            this.lblDindin.TabIndex = 5;
            this.lblDindin.Text = "Valor Restante";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(211, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(211, 142);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(211, 236);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 9;
            // 
            // btnCadatro
            // 
            this.btnCadatro.Location = new System.Drawing.Point(79, 299);
            this.btnCadatro.Name = "btnCadatro";
            this.btnCadatro.Size = new System.Drawing.Size(75, 23);
            this.btnCadatro.TabIndex = 10;
            this.btnCadatro.Text = "Cadastrar";
            this.btnCadatro.UseVisualStyleBackColor = true;
            this.btnCadatro.Click += new System.EventHandler(this.btnCadatro_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(273, 299);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 11;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroApostador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnCadatro);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDindin);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroApostador";
            this.Text = "FrmCadastroApostador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblDindin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCadatro;
        private System.Windows.Forms.Button btnConsulta;
    }
}