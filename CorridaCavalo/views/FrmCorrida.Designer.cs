namespace CorridaCavalo
{
    partial class FrmCorrida
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
            this.txtdtCorrida = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.cmbNomeCavalo = new System.Windows.Forms.ComboBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCavalo = new System.Windows.Forms.DataGridView();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCavalo)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Corrida";
            // 
            // txtdtCorrida
            // 
            this.txtdtCorrida.Location = new System.Drawing.Point(26, 160);
            this.txtdtCorrida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdtCorrida.Name = "txtdtCorrida";
            this.txtdtCorrida.Size = new System.Drawing.Size(148, 26);
            this.txtdtCorrida.TabIndex = 2;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(234, 160);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(148, 26);
            this.txtLocal.TabIndex = 3;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(441, 160);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(148, 26);
            this.txtDistancia.TabIndex = 4;
            // 
            // cmbNomeCavalo
            // 
            this.cmbNomeCavalo.FormattingEnabled = true;
            this.cmbNomeCavalo.Location = new System.Drawing.Point(26, 295);
            this.cmbNomeCavalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNomeCavalo.Name = "cmbNomeCavalo";
            this.cmbNomeCavalo.Size = new System.Drawing.Size(180, 28);
            this.cmbNomeCavalo.TabIndex = 5;
            this.cmbNomeCavalo.SelectedIndexChanged += new System.EventHandler(this.cmbNomeCavalo_SelectedIndexChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(26, 368);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(148, 26);
            this.txtIdade.TabIndex = 6;
            // 
            // txtCat
            // 
            this.txtCat.Enabled = false;
            this.txtCat.Location = new System.Drawing.Point(234, 366);
            this.txtCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(148, 26);
            this.txtCat.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(507, 368);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adicionar Cavalo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCavalo
            // 
            this.dgvCavalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCavalo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtNome,
            this.txtAge,
            this.txtCategoria});
            this.dgvCavalo.Location = new System.Drawing.Point(39, 431);
            this.dgvCavalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCavalo.Name = "dgvCavalo";
            this.dgvCavalo.Size = new System.Drawing.Size(514, 231);
            this.dgvCavalo.TabIndex = 9;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(39, 711);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(112, 35);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.HeaderText = "Id Cavalo";
            this.txtId.Name = "txtId";
            // 
            // txtNome
            // 
            this.txtNome.HeaderText = "Nome do Cavalo";
            this.txtNome.Name = "txtNome";
            // 
            // txtAge
            // 
            this.txtAge.HeaderText = "Idade";
            this.txtAge.Name = "txtAge";
            // 
            // txtCategoria
            // 
            this.txtCategoria.HeaderText = "Categoria ";
            this.txtCategoria.Name = "txtCategoria";
            // 
            // FrmCorrida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1170, 749);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.dgvCavalo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.cmbNomeCavalo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtdtCorrida);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCorrida";
            this.Text = "FrmCorrida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCavalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdtCorrida;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.ComboBox cmbNomeCavalo;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCavalo;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoria;
    }
}