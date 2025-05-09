namespace Cadastro_De_Clientes
{
    partial class FormMenuClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Ações = new System.Windows.Forms.GroupBox();
            this.BtImprimir = new System.Windows.Forms.Button();
            this.BtPdf = new System.Windows.Forms.Button();
            this.BtEdit = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PesqTodos = new System.Windows.Forms.RadioButton();
            this.PesqAtivo = new System.Windows.Forms.RadioButton();
            this.PesqCancelado = new System.Windows.Forms.RadioButton();
            this.PesqGenero = new System.Windows.Forms.ComboBox();
            this.PesqEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PesqDtNasc = new System.Windows.Forms.TextBox();
            this.PesqEndereco = new System.Windows.Forms.TextBox();
            this.PesqDocumento = new System.Windows.Forms.TextBox();
            this.PesqNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PesqId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTotalLocalizado = new System.Windows.Forms.Label();
            this.LblAtivos = new System.Windows.Forms.Label();
            this.LblCancelados = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblNadaEncontrado = new System.Windows.Forms.Label();
            this.Ações.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ações
            // 
            this.Ações.BackColor = System.Drawing.Color.Transparent;
            this.Ações.Controls.Add(this.BtImprimir);
            this.Ações.Controls.Add(this.BtPdf);
            this.Ações.Controls.Add(this.BtEdit);
            this.Ações.Controls.Add(this.BtAdd);
            this.Ações.Location = new System.Drawing.Point(12, 12);
            this.Ações.Name = "Ações";
            this.Ações.Size = new System.Drawing.Size(223, 81);
            this.Ações.TabIndex = 0;
            this.Ações.TabStop = false;
            this.Ações.Text = "Ações";
            this.Ações.Enter += new System.EventHandler(this.Ações_Enter);
            // 
            // BtImprimir
            // 
            this.BtImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtImprimir.Enabled = false;
            this.BtImprimir.FlatAppearance.BorderSize = 0;
            this.BtImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtImprimir.Image")));
            this.BtImprimir.Location = new System.Drawing.Point(168, 23);
            this.BtImprimir.Name = "BtImprimir";
            this.BtImprimir.Size = new System.Drawing.Size(48, 48);
            this.BtImprimir.TabIndex = 1;
            this.BtImprimir.UseVisualStyleBackColor = false;
            // 
            // BtPdf
            // 
            this.BtPdf.BackColor = System.Drawing.Color.Transparent;
            this.BtPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtPdf.FlatAppearance.BorderSize = 0;
            this.BtPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPdf.Image = ((System.Drawing.Image)(resources.GetObject("BtPdf.Image")));
            this.BtPdf.Location = new System.Drawing.Point(114, 23);
            this.BtPdf.Name = "BtPdf";
            this.BtPdf.Size = new System.Drawing.Size(48, 48);
            this.BtPdf.TabIndex = 1;
            this.BtPdf.UseVisualStyleBackColor = false;
            // 
            // BtEdit
            // 
            this.BtEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEdit.Enabled = false;
            this.BtEdit.FlatAppearance.BorderSize = 0;
            this.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtEdit.Image")));
            this.BtEdit.Location = new System.Drawing.Point(60, 23);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(48, 48);
            this.BtEdit.TabIndex = 1;
            this.BtEdit.UseVisualStyleBackColor = false;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAdd.FlatAppearance.BorderSize = 0;
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtAdd.Image")));
            this.BtAdd.Location = new System.Drawing.Point(6, 23);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(48, 48);
            this.BtAdd.TabIndex = 1;
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLista.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.foto,
            this.nome,
            this.documento,
            this.data_nascimento,
            this.rg,
            this.genero,
            this.estado_civil,
            this.email,
            this.telefone,
            this.cep,
            this.endereco,
            this.bairro,
            this.numero_casa,
            this.cidade,
            this.estado,
            this.situacao,
            this.observacao});
            this.dgLista.EnableHeadersVisualStyles = false;
            this.dgLista.Location = new System.Drawing.Point(12, 99);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.RowHeadersWidth = 5;
            this.dgLista.RowTemplate.Height = 30;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLista.Size = new System.Drawing.Size(1680, 703);
            this.dgLista.TabIndex = 1;
            this.dgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellClick);
            this.dgLista.Sorted += new System.EventHandler(this.dgLista_Sorted);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PesqTodos);
            this.groupBox1.Controls.Add(this.PesqAtivo);
            this.groupBox1.Controls.Add(this.PesqCancelado);
            this.groupBox1.Controls.Add(this.PesqGenero);
            this.groupBox1.Controls.Add(this.PesqEstadoCivil);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PesqDtNasc);
            this.groupBox1.Controls.Add(this.PesqEndereco);
            this.groupBox1.Controls.Add(this.PesqDocumento);
            this.groupBox1.Controls.Add(this.PesqNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PesqId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(254, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1438, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de Pesquisas";
            this.groupBox1.Enter += new System.EventHandler(this.Ações_Enter);
            // 
            // PesqTodos
            // 
            this.PesqTodos.AutoSize = true;
            this.PesqTodos.BackColor = System.Drawing.Color.Transparent;
            this.PesqTodos.Checked = true;
            this.PesqTodos.Location = new System.Drawing.Point(1320, 8);
            this.PesqTodos.Name = "PesqTodos";
            this.PesqTodos.Size = new System.Drawing.Size(69, 22);
            this.PesqTodos.TabIndex = 9;
            this.PesqTodos.TabStop = true;
            this.PesqTodos.Text = "Todos";
            this.PesqTodos.UseVisualStyleBackColor = false;
            this.PesqTodos.CheckedChanged += new System.EventHandler(this.PesqTodos_CheckedChanged);
            // 
            // PesqAtivo
            // 
            this.PesqAtivo.AutoSize = true;
            this.PesqAtivo.BackColor = System.Drawing.Color.Transparent;
            this.PesqAtivo.ForeColor = System.Drawing.Color.Green;
            this.PesqAtivo.Location = new System.Drawing.Point(1320, 30);
            this.PesqAtivo.Name = "PesqAtivo";
            this.PesqAtivo.Size = new System.Drawing.Size(58, 22);
            this.PesqAtivo.TabIndex = 9;
            this.PesqAtivo.Text = "Ativo";
            this.PesqAtivo.UseVisualStyleBackColor = false;
            this.PesqAtivo.CheckedChanged += new System.EventHandler(this.PesqAtivo_CheckedChanged);
            // 
            // PesqCancelado
            // 
            this.PesqCancelado.AutoSize = true;
            this.PesqCancelado.BackColor = System.Drawing.Color.Transparent;
            this.PesqCancelado.ForeColor = System.Drawing.Color.Crimson;
            this.PesqCancelado.Location = new System.Drawing.Point(1320, 52);
            this.PesqCancelado.Name = "PesqCancelado";
            this.PesqCancelado.Size = new System.Drawing.Size(97, 22);
            this.PesqCancelado.TabIndex = 9;
            this.PesqCancelado.Text = "Cancelado";
            this.PesqCancelado.UseVisualStyleBackColor = false;
            this.PesqCancelado.CheckedChanged += new System.EventHandler(this.PesqCancelado_CheckedChanged);
            // 
            // PesqGenero
            // 
            this.PesqGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PesqGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PesqGenero.DropDownHeight = 100;
            this.PesqGenero.FormattingEnabled = true;
            this.PesqGenero.IntegralHeight = false;
            this.PesqGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.PesqGenero.Location = new System.Drawing.Point(447, 42);
            this.PesqGenero.Name = "PesqGenero";
            this.PesqGenero.Size = new System.Drawing.Size(172, 26);
            this.PesqGenero.TabIndex = 8;
            this.PesqGenero.TextChanged += new System.EventHandler(this.PesqId_TextChanged);
            // 
            // PesqEstadoCivil
            // 
            this.PesqEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PesqEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PesqEstadoCivil.DropDownHeight = 100;
            this.PesqEstadoCivil.FormattingEnabled = true;
            this.PesqEstadoCivil.IntegralHeight = false;
            this.PesqEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)",
            "Separado(a)",
            "União estável"});
            this.PesqEstadoCivil.Location = new System.Drawing.Point(622, 42);
            this.PesqEstadoCivil.Name = "PesqEstadoCivil";
            this.PesqEstadoCivil.Size = new System.Drawing.Size(172, 26);
            this.PesqEstadoCivil.TabIndex = 8;
            this.PesqEstadoCivil.TextChanged += new System.EventHandler(this.PesqId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(444, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(625, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Estado Civil";
            // 
            // PesqDtNasc
            // 
            this.PesqDtNasc.Location = new System.Drawing.Point(1003, 42);
            this.PesqDtNasc.Name = "PesqDtNasc";
            this.PesqDtNasc.Size = new System.Drawing.Size(197, 24);
            this.PesqDtNasc.TabIndex = 1;
            this.PesqDtNasc.TextChanged += new System.EventHandler(this.PesqNome_TextChanged);
            // 
            // PesqEndereco
            // 
            this.PesqEndereco.Location = new System.Drawing.Point(800, 42);
            this.PesqEndereco.Name = "PesqEndereco";
            this.PesqEndereco.Size = new System.Drawing.Size(197, 24);
            this.PesqEndereco.TabIndex = 1;
            this.PesqEndereco.TextChanged += new System.EventHandler(this.PesqNome_TextChanged);
            // 
            // PesqDocumento
            // 
            this.PesqDocumento.Location = new System.Drawing.Point(286, 44);
            this.PesqDocumento.Name = "PesqDocumento";
            this.PesqDocumento.Size = new System.Drawing.Size(155, 24);
            this.PesqDocumento.TabIndex = 1;
            this.PesqDocumento.TextChanged += new System.EventHandler(this.PesqDocumento_TextChanged);
            // 
            // PesqNome
            // 
            this.PesqNome.Location = new System.Drawing.Point(83, 44);
            this.PesqNome.Name = "PesqNome";
            this.PesqNome.Size = new System.Drawing.Size(197, 24);
            this.PesqNome.TabIndex = 1;
            this.PesqNome.TextChanged += new System.EventHandler(this.PesqNome_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1003, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data de Nascimento";
            // 
            // PesqId
            // 
            this.PesqId.Location = new System.Drawing.Point(9, 44);
            this.PesqId.Name = "PesqId";
            this.PesqId.Size = new System.Drawing.Size(68, 24);
            this.PesqId.TabIndex = 1;
            this.PesqId.TextChanged += new System.EventHandler(this.PesqId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(800, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(283, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF / CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Cliente";
            // 
            // LblTotalLocalizado
            // 
            this.LblTotalLocalizado.AutoSize = true;
            this.LblTotalLocalizado.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalLocalizado.Location = new System.Drawing.Point(15, 805);
            this.LblTotalLocalizado.Name = "LblTotalLocalizado";
            this.LblTotalLocalizado.Size = new System.Drawing.Size(121, 18);
            this.LblTotalLocalizado.TabIndex = 2;
            this.LblTotalLocalizado.Text = "Total Localizado:";
            // 
            // LblAtivos
            // 
            this.LblAtivos.AutoSize = true;
            this.LblAtivos.BackColor = System.Drawing.Color.Transparent;
            this.LblAtivos.Location = new System.Drawing.Point(351, 805);
            this.LblAtivos.Name = "LblAtivos";
            this.LblAtivos.Size = new System.Drawing.Size(121, 18);
            this.LblAtivos.TabIndex = 2;
            this.LblAtivos.Text = "Total Localizado:";
            // 
            // LblCancelados
            // 
            this.LblCancelados.AutoSize = true;
            this.LblCancelados.BackColor = System.Drawing.Color.Transparent;
            this.LblCancelados.Location = new System.Drawing.Point(590, 805);
            this.LblCancelados.Name = "LblCancelados";
            this.LblCancelados.Size = new System.Drawing.Size(121, 18);
            this.LblCancelados.TabIndex = 2;
            this.LblCancelados.Text = "Total Localizado:";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "ID Cliente";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.Image = ((System.Drawing.Image)(resources.GetObject("foto.Image")));
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome do Cliente";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "CPF/CNPJ";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 140;
            // 
            // data_nascimento
            // 
            this.data_nascimento.DataPropertyName = "data_nascimento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.data_nascimento.DefaultCellStyle = dataGridViewCellStyle4;
            this.data_nascimento.HeaderText = "Nascimento";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.ReadOnly = true;
            this.data_nascimento.Width = 120;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rg.DefaultCellStyle = dataGridViewCellStyle5;
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Width = 120;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.genero.DefaultCellStyle = dataGridViewCellStyle6;
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // estado_civil
            // 
            this.estado_civil.DataPropertyName = "estado_civil";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estado_civil.DefaultCellStyle = dataGridViewCellStyle7;
            this.estado_civil.HeaderText = "Estado Civil";
            this.estado_civil.Name = "estado_civil";
            this.estado_civil.ReadOnly = true;
            this.estado_civil.Width = 130;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 220;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.telefone.DefaultCellStyle = dataGridViewCellStyle8;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 130;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cep.DefaultCellStyle = dataGridViewCellStyle9;
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 220;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 150;
            // 
            // numero_casa
            // 
            this.numero_casa.DataPropertyName = "numero_casa";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numero_casa.DefaultCellStyle = dataGridViewCellStyle10;
            this.numero_casa.HeaderText = "Nº da casa";
            this.numero_casa.Name = "numero_casa";
            this.numero_casa.ReadOnly = true;
            this.numero_casa.Width = 80;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cidade.DefaultCellStyle = dataGridViewCellStyle11;
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 150;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estado.DefaultCellStyle = dataGridViewCellStyle12;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 150;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.situacao.DefaultCellStyle = dataGridViewCellStyle13;
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            // 
            // observacao
            // 
            this.observacao.DataPropertyName = "observacao";
            this.observacao.HeaderText = "Observações";
            this.observacao.Name = "observacao";
            this.observacao.ReadOnly = true;
            this.observacao.Width = 250;
            // 
            // LblNadaEncontrado
            // 
            this.LblNadaEncontrado.BackColor = System.Drawing.Color.White;
            this.LblNadaEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.LblNadaEncontrado.ForeColor = System.Drawing.Color.Salmon;
            this.LblNadaEncontrado.Image = ((System.Drawing.Image)(resources.GetObject("LblNadaEncontrado.Image")));
            this.LblNadaEncontrado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblNadaEncontrado.Location = new System.Drawing.Point(12, 140);
            this.LblNadaEncontrado.Name = "LblNadaEncontrado";
            this.LblNadaEncontrado.Padding = new System.Windows.Forms.Padding(0, 0, 0, 150);
            this.LblNadaEncontrado.Size = new System.Drawing.Size(1680, 662);
            this.LblNadaEncontrado.TabIndex = 3;
            this.LblNadaEncontrado.Text = "Sua busca não gerou resultados...";
            this.LblNadaEncontrado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblNadaEncontrado.Visible = false;
            // 
            // FormMenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cadastro_De_Clientes.Properties.Resources.Captura_de_tela_2025_04_23_174547;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1704, 881);
            this.Controls.Add(this.LblNadaEncontrado);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ações);
            this.Controls.Add(this.LblCancelados);
            this.Controls.Add(this.LblAtivos);
            this.Controls.Add(this.LblTotalLocalizado);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Clientes";
            this.Load += new System.EventHandler(this.FormMenuClientes_Load);
            this.Ações.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Ações;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Button BtImprimir;
        private System.Windows.Forms.Button BtPdf;
        private System.Windows.Forms.Button BtEdit;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PesqId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PesqDocumento;
        private System.Windows.Forms.TextBox PesqNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PesqGenero;
        private System.Windows.Forms.ComboBox PesqEstadoCivil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PesqDtNasc;
        private System.Windows.Forms.TextBox PesqEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton PesqTodos;
        private System.Windows.Forms.RadioButton PesqAtivo;
        private System.Windows.Forms.RadioButton PesqCancelado;
        private System.Windows.Forms.Label LblTotalLocalizado;
        private System.Windows.Forms.Label LblAtivos;
        private System.Windows.Forms.Label LblCancelados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_casa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.Label LblNadaEncontrado;
    }
}