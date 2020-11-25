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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbNomeCavalo = new System.Windows.Forms.ComboBox();
            this.dgvCavalo = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCadatro = new System.Windows.Forms.Button();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblDataCorrida = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDivisionSideMenu = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtdtCorrida = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCavalo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNomeCavalo
            // 
            this.cmbNomeCavalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cmbNomeCavalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNomeCavalo.ForeColor = System.Drawing.Color.White;
            this.cmbNomeCavalo.FormattingEnabled = true;
            this.cmbNomeCavalo.Location = new System.Drawing.Point(28, 335);
            this.cmbNomeCavalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNomeCavalo.Name = "cmbNomeCavalo";
            this.cmbNomeCavalo.Size = new System.Drawing.Size(200, 28);
            this.cmbNomeCavalo.TabIndex = 5;
            this.cmbNomeCavalo.SelectedIndexChanged += new System.EventHandler(this.cmbNomeCavalo_SelectedIndexChanged);
            // 
            // dgvCavalo
            // 
            this.dgvCavalo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dgvCavalo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCavalo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCavalo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCavalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCavalo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtNome,
            this.txtAge,
            this.txtCategoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCavalo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCavalo.EnableHeadersVisualStyles = false;
            this.dgvCavalo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvCavalo.Location = new System.Drawing.Point(28, 439);
            this.dgvCavalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCavalo.Name = "dgvCavalo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCavalo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCavalo.RowHeadersVisible = false;
            this.dgvCavalo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCavalo.Size = new System.Drawing.Size(651, 187);
            this.dgvCavalo.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.HeaderText = "Cod Cavalo";
            this.txtId.Name = "txtId";
            this.txtId.Width = 50;
            // 
            // txtNome
            // 
            this.txtNome.HeaderText = "Nome do Cavalo";
            this.txtNome.Name = "txtNome";
            this.txtNome.Width = 200;
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
            this.txtCategoria.Width = 200;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 714);
            this.panel1.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtdtCorrida);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.txtCat);
            this.panel5.Controls.Add(this.dgvCavalo);
            this.panel5.Controls.Add(this.txtIdade);
            this.panel5.Controls.Add(this.txtDistancia);
            this.panel5.Controls.Add(this.btnFechar);
            this.panel5.Controls.Add(this.btnConsulta);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btnCadatro);
            this.panel5.Controls.Add(this.cmbNomeCavalo);
            this.panel5.Controls.Add(this.txtLocal);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblLocal);
            this.panel5.Controls.Add(this.lblDistancia);
            this.panel5.Controls.Add(this.lblDataCorrida);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(722, 710);
            this.panel5.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(475, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Idade";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(28, 385);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 35);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Adicionar Cavalo";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCat
            // 
            this.txtCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCat.Enabled = false;
            this.txtCat.ForeColor = System.Drawing.Color.White;
            this.txtCat.Location = new System.Drawing.Point(479, 337);
            this.txtCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(200, 26);
            this.txtCat.TabIndex = 37;
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdade.Enabled = false;
            this.txtIdade.ForeColor = System.Drawing.Color.White;
            this.txtIdade.Location = new System.Drawing.Point(255, 337);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(200, 26);
            this.txtIdade.TabIndex = 36;
            // 
            // txtDistancia
            // 
            this.txtDistancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtDistancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistancia.ForeColor = System.Drawing.Color.White;
            this.txtDistancia.Location = new System.Drawing.Point(28, 262);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(200, 26);
            this.txtDistancia.TabIndex = 35;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(182, 650);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(148, 35);
            this.btnFechar.TabIndex = 34;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnConsulta.Enabled = false;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(532, 650);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(148, 35);
            this.btnConsulta.TabIndex = 33;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 85);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(722, 1);
            this.panel7.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTitle);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(722, 85);
            this.panel6.TabIndex = 31;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(23, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cadastro Corrida";
            // 
            // btnCadatro
            // 
            this.btnCadatro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCadatro.FlatAppearance.BorderSize = 0;
            this.btnCadatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadatro.ForeColor = System.Drawing.Color.White;
            this.btnCadatro.Location = new System.Drawing.Point(357, 650);
            this.btnCadatro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadatro.Name = "btnCadatro";
            this.btnCadatro.Size = new System.Drawing.Size(148, 35);
            this.btnCadatro.TabIndex = 30;
            this.btnCadatro.Text = "Cadastrar";
            this.btnCadatro.UseVisualStyleBackColor = false;
            this.btnCadatro.Click += new System.EventHandler(this.btnCadatro_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocal.ForeColor = System.Drawing.Color.White;
            this.txtLocal.Location = new System.Drawing.Point(28, 192);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(200, 26);
            this.txtLocal.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Saldo";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.ForeColor = System.Drawing.Color.White;
            this.lblLocal.Location = new System.Drawing.Point(24, 167);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(47, 20);
            this.lblLocal.TabIndex = 24;
            this.lblLocal.Text = "Local";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.ForeColor = System.Drawing.Color.White;
            this.lblDistancia.Location = new System.Drawing.Point(24, 237);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(75, 20);
            this.lblDistancia.TabIndex = 23;
            this.lblDistancia.Text = "Distancia";
            // 
            // lblDataCorrida
            // 
            this.lblDataCorrida.AutoSize = true;
            this.lblDataCorrida.ForeColor = System.Drawing.Color.White;
            this.lblDataCorrida.Location = new System.Drawing.Point(24, 102);
            this.lblDataCorrida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataCorrida.Name = "lblDataCorrida";
            this.lblDataCorrida.Size = new System.Drawing.Size(99, 20);
            this.lblDataCorrida.TabIndex = 22;
            this.lblDataCorrida.Text = "Data Corrida";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(2, 712);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 2);
            this.panel4.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 2);
            this.panel3.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(724, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 714);
            this.panel2.TabIndex = 22;
            // 
            // panelDivisionSideMenu
            // 
            this.panelDivisionSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelDivisionSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDivisionSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelDivisionSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDivisionSideMenu.Name = "panelDivisionSideMenu";
            this.panelDivisionSideMenu.Size = new System.Drawing.Size(2, 714);
            this.panelDivisionSideMenu.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 739);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(763, 25);
            this.panel8.TabIndex = 38;
            // 
            // txtdtCorrida
            // 
            this.txtdtCorrida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtdtCorrida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdtCorrida.ForeColor = System.Drawing.Color.White;
            this.txtdtCorrida.Location = new System.Drawing.Point(28, 125);
            this.txtdtCorrida.Mask = "00/00/0000";
            this.txtdtCorrida.Name = "txtdtCorrida";
            this.txtdtCorrida.Size = new System.Drawing.Size(100, 26);
            this.txtdtCorrida.TabIndex = 41;
            this.txtdtCorrida.ValidatingType = typeof(System.DateTime);
            // 
            // FrmCorrida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCorrida";
            this.Text = "FrmCorrida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCavalo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbNomeCavalo;
        private System.Windows.Forms.DataGridView dgvCavalo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCadatro;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblDataCorrida;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDivisionSideMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoria;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.MaskedTextBox txtdtCorrida;
    }
}