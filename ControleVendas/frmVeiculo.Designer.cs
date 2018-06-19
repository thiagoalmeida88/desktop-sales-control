namespace ControleVendas
{
    partial class frmVeiculo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtAnoVeiculo = new System.Windows.Forms.TextBox();
            this.txtAnoFabricacao = new System.Windows.Forms.TextBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAbs = new System.Windows.Forms.CheckBox();
            this.chkAr = new System.Windows.Forms.CheckBox();
            this.cmbAirBag = new System.Windows.Forms.ComboBox();
            this.cmbDirecao = new System.Windows.Forms.ComboBox();
            this.cmbNumPortas = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupboxPesquisar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlacaPesquisa = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupboxPesquisar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.txtAnoVeiculo);
            this.groupBox1.Controls.Add(this.txtAnoFabricacao);
            this.groupBox1.Controls.Add(this.cmbModelo);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerais";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(312, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(43, 24);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.Visible = false;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(145, 210);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(209, 24);
            this.txtKm.TabIndex = 5;
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Location = new System.Drawing.Point(145, 180);
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(209, 24);
            this.txtAnoVeiculo.TabIndex = 4;
            // 
            // txtAnoFabricacao
            // 
            this.txtAnoFabricacao.Location = new System.Drawing.Point(146, 150);
            this.txtAnoFabricacao.Name = "txtAnoFabricacao";
            this.txtAnoFabricacao.Size = new System.Drawing.Size(209, 24);
            this.txtAnoFabricacao.TabIndex = 3;
            // 
            // cmbModelo
            // 
            this.cmbModelo.DisplayMember = "nome_modelo";
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(145, 114);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(208, 26);
            this.cmbModelo.TabIndex = 2;
            this.cmbModelo.ValueMember = "cod_modelo";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DisplayMember = "nome_marca";
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(146, 77);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(208, 26);
            this.cmbMarca.TabIndex = 1;
            this.cmbMarca.ValueMember = "cod_marca";
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(145, 43);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(209, 24);
            this.txtPlaca.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "KM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ano Veículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ano Fabricação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Placa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAbs);
            this.groupBox2.Controls.Add(this.chkAr);
            this.groupBox2.Controls.Add(this.cmbAirBag);
            this.groupBox2.Controls.Add(this.cmbDirecao);
            this.groupBox2.Controls.Add(this.cmbNumPortas);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbCor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(423, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 277);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Adicionais";
            // 
            // chkAbs
            // 
            this.chkAbs.AutoSize = true;
            this.chkAbs.Location = new System.Drawing.Point(140, 238);
            this.chkAbs.Name = "chkAbs";
            this.chkAbs.Size = new System.Drawing.Size(15, 14);
            this.chkAbs.TabIndex = 5;
            this.chkAbs.UseVisualStyleBackColor = true;
            // 
            // chkAr
            // 
            this.chkAr.AutoSize = true;
            this.chkAr.Location = new System.Drawing.Point(140, 203);
            this.chkAr.Name = "chkAr";
            this.chkAr.Size = new System.Drawing.Size(15, 14);
            this.chkAr.TabIndex = 4;
            this.chkAr.UseVisualStyleBackColor = true;
            // 
            // cmbAirBag
            // 
            this.cmbAirBag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAirBag.FormattingEnabled = true;
            this.cmbAirBag.Items.AddRange(new object[] {
            "Nenhum",
            "Duplo",
            "Duplo e Lateral"});
            this.cmbAirBag.Location = new System.Drawing.Point(140, 150);
            this.cmbAirBag.Name = "cmbAirBag";
            this.cmbAirBag.Size = new System.Drawing.Size(221, 26);
            this.cmbAirBag.TabIndex = 3;
            // 
            // cmbDirecao
            // 
            this.cmbDirecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirecao.FormattingEnabled = true;
            this.cmbDirecao.Items.AddRange(new object[] {
            "Mecânica",
            "Hidráulica",
            "Elétrica"});
            this.cmbDirecao.Location = new System.Drawing.Point(140, 114);
            this.cmbDirecao.Name = "cmbDirecao";
            this.cmbDirecao.Size = new System.Drawing.Size(221, 26);
            this.cmbDirecao.TabIndex = 2;
            // 
            // cmbNumPortas
            // 
            this.cmbNumPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumPortas.FormattingEnabled = true;
            this.cmbNumPortas.Items.AddRange(new object[] {
            "2",
            "4"});
            this.cmbNumPortas.Location = new System.Drawing.Point(140, 77);
            this.cmbNumPortas.Name = "cmbNumPortas";
            this.cmbNumPortas.Size = new System.Drawing.Size(221, 26);
            this.cmbNumPortas.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Freio-ABS:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Ar Condicionado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Airbag:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Direção:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Num. de portas:";
            // 
            // cmbCor
            // 
            this.cmbCor.DisplayMember = "nome_cor";
            this.cmbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCor.FormattingEnabled = true;
            this.cmbCor.Location = new System.Drawing.Point(140, 41);
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(221, 26);
            this.cmbCor.TabIndex = 0;
            this.cmbCor.ValueMember = "cod_cor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cor:";
            // 
            // groupboxPesquisar
            // 
            this.groupboxPesquisar.Controls.Add(this.label1);
            this.groupboxPesquisar.Controls.Add(this.txtPlacaPesquisa);
            this.groupboxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxPesquisar.Location = new System.Drawing.Point(821, 12);
            this.groupboxPesquisar.Name = "groupboxPesquisar";
            this.groupboxPesquisar.Size = new System.Drawing.Size(521, 96);
            this.groupboxPesquisar.TabIndex = 0;
            this.groupboxPesquisar.TabStop = false;
            this.groupboxPesquisar.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa:";
            // 
            // txtPlacaPesquisa
            // 
            this.txtPlacaPesquisa.Location = new System.Drawing.Point(80, 39);
            this.txtPlacaPesquisa.Name = "txtPlacaPesquisa";
            this.txtPlacaPesquisa.Size = new System.Drawing.Size(404, 24);
            this.txtPlacaPesquisa.TabIndex = 0;
            this.txtPlacaPesquisa.TextChanged += new System.EventHandler(this.txtPlacaPesquisa_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtObs);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.btnSalvar);
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.cmbSituacao);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtValorVenda);
            this.groupBox4.Controls.Add(this.txtValorCompra);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 325);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados para Venda";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvar.Location = new System.Drawing.Point(434, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 30);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(328, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo",
            "Vendido"});
            this.cmbSituacao.Location = new System.Drawing.Point(166, 93);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(209, 26);
            this.cmbSituacao.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(90, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 18);
            this.label16.TabIndex = 17;
            this.label16.Text = "Situação:";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(563, 49);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(209, 24);
            this.txtValorVenda.TabIndex = 1;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(166, 49);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(209, 24);
            this.txtValorCompra.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "Valor da Compra:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(444, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "Valor da Venda:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grdResultado);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(819, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(523, 505);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultado da pesquisa";
            // 
            // grdResultado
            // 
            this.grdResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(6, 23);
            this.grdResultado.MultiSelect = false;
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResultado.Size = new System.Drawing.Size(511, 476);
            this.grdResultado.TabIndex = 0;
            this.grdResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdResultado_CellClick);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(575, 626);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 30);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(67, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 18);
            this.label17.TabIndex = 18;
            this.label17.Text = "Observação:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(166, 141);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(606, 24);
            this.txtObs.TabIndex = 19;
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 668);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupboxPesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículo";
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupboxPesquisar.ResumeLayout(false);
            this.groupboxPesquisar.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupboxPesquisar;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtAnoVeiculo;
        private System.Windows.Forms.TextBox txtAnoFabricacao;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlacaPesquisa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkAbs;
        private System.Windows.Forms.CheckBox chkAr;
        private System.Windows.Forms.ComboBox cmbAirBag;
        private System.Windows.Forms.ComboBox cmbDirecao;
        private System.Windows.Forms.ComboBox cmbNumPortas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label17;
    }
}