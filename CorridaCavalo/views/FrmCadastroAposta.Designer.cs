namespace CorridaCavalo.views
{
    partial class FrmCadastroAposta
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCosulta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtIDCorrida = new System.Windows.Forms.TextBox();
            this.txtIdCavalo = new System.Windows.Forms.TextBox();
            this.txtIdApostador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(305, 202);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 38;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(201, 202);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 37;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCosulta
            // 
            this.btnCosulta.Location = new System.Drawing.Point(100, 202);
            this.btnCosulta.Name = "btnCosulta";
            this.btnCosulta.Size = new System.Drawing.Size(75, 23);
            this.btnCosulta.TabIndex = 36;
            this.btnCosulta.Text = "Consulta";
            this.btnCosulta.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Id Corrida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "ID Cavalo";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(458, 115);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 31;
            // 
            // txtIDCorrida
            // 
            this.txtIDCorrida.Location = new System.Drawing.Point(328, 115);
            this.txtIDCorrida.Name = "txtIDCorrida";
            this.txtIDCorrida.Size = new System.Drawing.Size(100, 20);
            this.txtIDCorrida.TabIndex = 30;
            // 
            // txtIdCavalo
            // 
            this.txtIdCavalo.Location = new System.Drawing.Point(201, 115);
            this.txtIdCavalo.Name = "txtIdCavalo";
            this.txtIdCavalo.Size = new System.Drawing.Size(100, 20);
            this.txtIdCavalo.TabIndex = 29;
            // 
            // txtIdApostador
            // 
            this.txtIdApostador.Location = new System.Drawing.Point(75, 115);
            this.txtIdApostador.Name = "txtIdApostador";
            this.txtIdApostador.Size = new System.Drawing.Size(100, 20);
            this.txtIdApostador.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id Apostador";
            // 
            // CadastroAposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
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
            this.Name = "CadastroAposta";
            this.Text = "CadastroAposta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCosulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtIDCorrida;
        private System.Windows.Forms.TextBox txtIdCavalo;
        private System.Windows.Forms.TextBox txtIdApostador;
        private System.Windows.Forms.Label label2;
    }
}