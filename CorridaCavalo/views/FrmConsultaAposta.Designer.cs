namespace CorridaCavalo.views
{
    partial class FrmConsultaAposta
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCosulta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtIDCorrida = new System.Windows.Forms.TextBox();
            this.txtIdCavalo = new System.Windows.Forms.TextBox();
            this.txtIdApostador = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(308, 356);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 27;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(429, 356);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(204, 356);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 25;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCosulta
            // 
            this.btnCosulta.Location = new System.Drawing.Point(103, 356);
            this.btnCosulta.Name = "btnCosulta";
            this.btnCosulta.Size = new System.Drawing.Size(75, 23);
            this.btnCosulta.TabIndex = 24;
            this.btnCosulta.Text = "Consulta";
            this.btnCosulta.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Id Corrida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID Cavalo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id Apostador";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(461, 269);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 19;
            // 
            // txtIDCorrida
            // 
            this.txtIDCorrida.Location = new System.Drawing.Point(331, 269);
            this.txtIDCorrida.Name = "txtIDCorrida";
            this.txtIDCorrida.Size = new System.Drawing.Size(100, 20);
            this.txtIDCorrida.TabIndex = 18;
            // 
            // txtIdCavalo
            // 
            this.txtIdCavalo.Location = new System.Drawing.Point(204, 269);
            this.txtIdCavalo.Name = "txtIdCavalo";
            this.txtIdCavalo.Size = new System.Drawing.Size(100, 20);
            this.txtIdCavalo.TabIndex = 17;
            // 
            // txtIdApostador
            // 
            this.txtIdApostador.Location = new System.Drawing.Point(78, 269);
            this.txtIdApostador.Name = "txtIdApostador";
            this.txtIdApostador.Size = new System.Drawing.Size(100, 20);
            this.txtIdApostador.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAp,
            this.idca,
            this.idco,
            this.valor});
            this.dataGridView1.Location = new System.Drawing.Point(78, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // IdAp
            // 
            this.IdAp.HeaderText = "Id Apostador";
            this.IdAp.Name = "IdAp";
            // 
            // idca
            // 
            this.idca.HeaderText = "Id Cavalo";
            this.idca.Name = "idca";
            // 
            // idco
            // 
            this.idco.HeaderText = "Id Corrida";
            this.idco.Name = "idco";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // ConsultaAposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCosulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtIDCorrida);
            this.Controls.Add(this.txtIdCavalo);
            this.Controls.Add(this.txtIdApostador);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaAposta";
            this.Text = "ConsultaAposta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCosulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtIDCorrida;
        private System.Windows.Forms.TextBox txtIdCavalo;
        private System.Windows.Forms.TextBox txtIdApostador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idco;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}