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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtIDCorrida = new System.Windows.Forms.TextBox();
            this.txtIdCavalo = new System.Windows.Forms.TextBox();
            this.txtIdApostador = new System.Windows.Forms.TextBox();
            this.lblCodCorrida = new System.Windows.Forms.Label();
            this.lblCodCavalo = new System.Windows.Forms.Label();
            this.lblCodApostador = new System.Windows.Forms.Label();
            this.dgvConsultaAposta = new System.Windows.Forms.DataGridView();
            this.IdApostador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCavalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAposta)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.panel15);
            this.panel8.Location = new System.Drawing.Point(25, 25);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(726, 598);
            this.panel8.TabIndex = 56;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtValor);
            this.panel9.Controls.Add(this.lblValor);
            this.panel9.Controls.Add(this.txtIDCorrida);
            this.panel9.Controls.Add(this.txtIdCavalo);
            this.panel9.Controls.Add(this.txtIdApostador);
            this.panel9.Controls.Add(this.lblCodCorrida);
            this.panel9.Controls.Add(this.lblCodCavalo);
            this.panel9.Controls.Add(this.lblCodApostador);
            this.panel9.Controls.Add(this.dgvConsultaAposta);
            this.panel9.Controls.Add(this.button1);
            this.panel9.Controls.Add(this.btnConsultar);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.button2);
            this.panel9.Controls.Add(this.btnEditar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(2, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(722, 594);
            this.panel9.TabIndex = 25;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(220, 485);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(148, 26);
            this.txtValor.TabIndex = 58;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(216, 460);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 57;
            this.lblValor.Text = "Valor";
            // 
            // txtIDCorrida
            // 
            this.txtIDCorrida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtIDCorrida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDCorrida.ForeColor = System.Drawing.Color.White;
            this.txtIDCorrida.Location = new System.Drawing.Point(34, 485);
            this.txtIDCorrida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDCorrida.Name = "txtIDCorrida";
            this.txtIDCorrida.Size = new System.Drawing.Size(148, 26);
            this.txtIDCorrida.TabIndex = 56;
            // 
            // txtIdCavalo
            // 
            this.txtIdCavalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtIdCavalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCavalo.ForeColor = System.Drawing.Color.White;
            this.txtIdCavalo.Location = new System.Drawing.Point(31, 411);
            this.txtIdCavalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCavalo.Name = "txtIdCavalo";
            this.txtIdCavalo.Size = new System.Drawing.Size(151, 26);
            this.txtIdCavalo.TabIndex = 55;
            // 
            // txtIdApostador
            // 
            this.txtIdApostador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtIdApostador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdApostador.ForeColor = System.Drawing.Color.White;
            this.txtIdApostador.Location = new System.Drawing.Point(31, 338);
            this.txtIdApostador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdApostador.Name = "txtIdApostador";
            this.txtIdApostador.Size = new System.Drawing.Size(151, 26);
            this.txtIdApostador.TabIndex = 54;
            // 
            // lblCodCorrida
            // 
            this.lblCodCorrida.AutoSize = true;
            this.lblCodCorrida.ForeColor = System.Drawing.Color.White;
            this.lblCodCorrida.Location = new System.Drawing.Point(30, 460);
            this.lblCodCorrida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodCorrida.Name = "lblCodCorrida";
            this.lblCodCorrida.Size = new System.Drawing.Size(114, 20);
            this.lblCodCorrida.TabIndex = 53;
            this.lblCodCorrida.Text = "Código Corrida";
            // 
            // lblCodCavalo
            // 
            this.lblCodCavalo.AutoSize = true;
            this.lblCodCavalo.ForeColor = System.Drawing.Color.White;
            this.lblCodCavalo.Location = new System.Drawing.Point(27, 386);
            this.lblCodCavalo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodCavalo.Name = "lblCodCavalo";
            this.lblCodCavalo.Size = new System.Drawing.Size(111, 20);
            this.lblCodCavalo.TabIndex = 52;
            this.lblCodCavalo.Text = "Código Cavalo";
            // 
            // lblCodApostador
            // 
            this.lblCodApostador.AutoSize = true;
            this.lblCodApostador.ForeColor = System.Drawing.Color.White;
            this.lblCodApostador.Location = new System.Drawing.Point(27, 313);
            this.lblCodApostador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodApostador.Name = "lblCodApostador";
            this.lblCodApostador.Size = new System.Drawing.Size(137, 20);
            this.lblCodApostador.TabIndex = 51;
            this.lblCodApostador.Text = "Código Apostador";
            // 
            // dgvConsultaAposta
            // 
            this.dgvConsultaAposta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dgvConsultaAposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaAposta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaAposta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaAposta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsultaAposta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdApostador,
            this.idCavalo,
            this.idCorrida,
            this.valorCell});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaAposta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaAposta.EnableHeadersVisualStyles = false;
            this.dgvConsultaAposta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvConsultaAposta.Location = new System.Drawing.Point(32, 106);
            this.dgvConsultaAposta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsultaAposta.Name = "dgvConsultaAposta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaAposta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaAposta.RowHeadersVisible = false;
            this.dgvConsultaAposta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultaAposta.Size = new System.Drawing.Size(651, 187);
            this.dgvConsultaAposta.TabIndex = 2;
            // 
            // IdApostador
            // 
            this.IdApostador.HeaderText = "Código Apostador";
            this.IdApostador.Name = "IdApostador";
            // 
            // idCavalo
            // 
            this.idCavalo.HeaderText = "Código Cavalo";
            this.idCavalo.Name = "idCavalo";
            this.idCavalo.Width = 50;
            // 
            // idCorrida
            // 
            this.idCorrida.HeaderText = "Código Corrida";
            this.idCorrida.Name = "idCorrida";
            this.idCorrida.Width = 50;
            // 
            // valorCell
            // 
            this.valorCell.HeaderText = "Valor";
            this.valorCell.Name = "valorCell";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(34, 536);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 50;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(201, 536);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(148, 35);
            this.btnConsultar.TabIndex = 49;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 85);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(722, 1);
            this.panel10.TabIndex = 32;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lblTitle);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(722, 85);
            this.panel11.TabIndex = 31;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(29, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Consulta Aposta";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(535, 536);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 35);
            this.button2.TabIndex = 46;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(368, 536);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 35);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(2, 596);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(722, 2);
            this.panel12.TabIndex = 24;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(2, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(722, 2);
            this.panel13.TabIndex = 23;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(724, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(2, 598);
            this.panel14.TabIndex = 22;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(2, 598);
            this.panel15.TabIndex = 21;
            // 
            // FrmConsultaAposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.Controls.Add(this.panel8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConsultaAposta";
            this.Text = "ConsultaAposta";
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAposta)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgvConsultaAposta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtIDCorrida;
        private System.Windows.Forms.TextBox txtIdCavalo;
        private System.Windows.Forms.TextBox txtIdApostador;
        private System.Windows.Forms.Label lblCodCorrida;
        private System.Windows.Forms.Label lblCodCavalo;
        private System.Windows.Forms.Label lblCodApostador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdApostador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCavalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCell;
    }
}