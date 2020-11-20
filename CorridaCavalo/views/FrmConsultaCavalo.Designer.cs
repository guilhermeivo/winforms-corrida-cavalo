namespace CorridaCavalo
{
    partial class FrmConsultaCavalo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codCava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelDono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeDn = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblNomeDn = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNomeCav = new System.Windows.Forms.TextBox();
            this.txtCodDn = new System.Windows.Forms.TextBox();
            this.txtCodCav = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNomeCav = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodCav = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta cavalo";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCava,
            this.codDono,
            this.NomeCav,
            this.Idade,
            this.idStatus,
            this.nomeDn,
            this.TelDono,
            this.emailDn});
            this.dataGridView1.Location = new System.Drawing.Point(1, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // codCava
            // 
            this.codCava.HeaderText = "N° do Cavalo";
            this.codCava.Name = "codCava";
            // 
            // codDono
            // 
            this.codDono.HeaderText = "Código do Dono";
            this.codDono.Name = "codDono";
            // 
            // NomeCav
            // 
            this.NomeCav.HeaderText = "Nome do Cavalo";
            this.NomeCav.Name = "NomeCav";
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            // 
            // idStatus
            // 
            this.idStatus.HeaderText = "Status";
            this.idStatus.Name = "idStatus";
            // 
            // nomeDn
            // 
            this.nomeDn.HeaderText = "Nome Dono";
            this.nomeDn.Name = "nomeDn";
            // 
            // TelDono
            // 
            this.TelDono.HeaderText = "Telefone";
            this.TelDono.Name = "TelDono";
            // 
            // emailDn
            // 
            this.emailDn.HeaderText = "Email";
            this.emailDn.Name = "emailDn";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(497, 492);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 44;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(375, 494);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(375, 456);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(375, 411);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 41;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtNomeDn
            // 
            this.txtNomeDn.Location = new System.Drawing.Point(168, 413);
            this.txtNomeDn.Name = "txtNomeDn";
            this.txtNomeDn.Size = new System.Drawing.Size(100, 20);
            this.txtNomeDn.TabIndex = 40;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(168, 492);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 456);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 38;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(168, 381);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 37;
            // 
            // lblNomeDn
            // 
            this.lblNomeDn.AutoSize = true;
            this.lblNomeDn.ForeColor = System.Drawing.Color.White;
            this.lblNomeDn.Location = new System.Drawing.Point(77, 421);
            this.lblNomeDn.Name = "lblNomeDn";
            this.lblNomeDn.Size = new System.Drawing.Size(79, 13);
            this.lblNomeDn.TabIndex = 36;
            this.lblNomeDn.Text = "Nome do Dono";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(77, 500);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 35;
            this.lblTel.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(77, 456);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(77, 381);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(168, 333);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 52;
            // 
            // txtNomeCav
            // 
            this.txtNomeCav.Location = new System.Drawing.Point(168, 296);
            this.txtNomeCav.Name = "txtNomeCav";
            this.txtNomeCav.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCav.TabIndex = 51;
            // 
            // txtCodDn
            // 
            this.txtCodDn.Location = new System.Drawing.Point(168, 260);
            this.txtCodDn.Name = "txtCodDn";
            this.txtCodDn.Size = new System.Drawing.Size(100, 20);
            this.txtCodDn.TabIndex = 50;
            // 
            // txtCodCav
            // 
            this.txtCodCav.Location = new System.Drawing.Point(168, 220);
            this.txtCodCav.Name = "txtCodCav";
            this.txtCodCav.Size = new System.Drawing.Size(100, 20);
            this.txtCodCav.TabIndex = 49;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(77, 341);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 48;
            this.lblIdade.Text = "Idade";
            // 
            // lblNomeCav
            // 
            this.lblNomeCav.AutoSize = true;
            this.lblNomeCav.ForeColor = System.Drawing.Color.White;
            this.lblNomeCav.Location = new System.Drawing.Point(77, 304);
            this.lblNomeCav.Name = "lblNomeCav";
            this.lblNomeCav.Size = new System.Drawing.Size(71, 13);
            this.lblNomeCav.TabIndex = 47;
            this.lblNomeCav.Text = "Nome Cavalo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Código Dono";
            // 
            // lblCodCav
            // 
            this.lblCodCav.AutoSize = true;
            this.lblCodCav.ForeColor = System.Drawing.Color.White;
            this.lblCodCav.Location = new System.Drawing.Point(77, 220);
            this.lblCodCav.Name = "lblCodCav";
            this.lblCodCav.Size = new System.Drawing.Size(35, 13);
            this.lblCodCav.TabIndex = 45;
            this.lblCodCav.Text = "Nome";
            // 
            // FrmConsultaCavalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNomeCav);
            this.Controls.Add(this.txtCodDn);
            this.Controls.Add(this.txtCodCav);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNomeCav);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCodCav);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNomeDn);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblNomeDn);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaCavalo";
            this.Text = "FrmConsultaCavalo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCava;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCav;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelDono;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDn;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeDn;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblNomeDn;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNomeCav;
        private System.Windows.Forms.TextBox txtCodDn;
        private System.Windows.Forms.TextBox txtCodCav;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNomeCav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCodCav;
    }
}