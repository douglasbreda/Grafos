namespace Grafos
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlEstrela = new System.Windows.Forms.Panel();
            this.grdEstrela = new System.Windows.Forms.DataGridView();
            this.pnlLegendas = new System.Windows.Forms.Panel();
            this.grpLegendas = new System.Windows.Forms.GroupBox();
            this.lblVisitados = new System.Windows.Forms.Label();
            this.pnlVisitados = new System.Windows.Forms.Panel();
            this.lblCaminhos = new System.Windows.Forms.Label();
            this.pnlCaminhos = new System.Windows.Forms.Panel();
            this.lblPontoFinal = new System.Windows.Forms.Label();
            this.lblPontoInicial = new System.Windows.Forms.Label();
            this.lblCorMuro = new System.Windows.Forms.Label();
            this.pnlFinal = new System.Windows.Forms.Panel();
            this.pnlInical = new System.Windows.Forms.Panel();
            this.pnlCorMuro = new System.Windows.Forms.Panel();
            this.pnlExibicao = new System.Windows.Forms.Panel();
            this.pnlConectividade = new System.Windows.Forms.Panel();
            this.lblConexo = new System.Windows.Forms.Label();
            this.lblGrafo = new System.Windows.Forms.Label();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.lblCusto = new System.Windows.Forms.Label();
            this.cboTipoCusto = new System.Windows.Forms.ComboBox();
            this.txtCustoTotal = new System.Windows.Forms.TextBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVerticeInicial = new System.Windows.Forms.Label();
            this.txtVerticeBusca = new System.Windows.Forms.TextBox();
            this.lblVerticeBusca = new System.Windows.Forms.Label();
            this.txtVerticeInicial = new System.Windows.Forms.TextBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.grpOpcoes = new System.Windows.Forms.GroupBox();
            this.radCaixeiro = new System.Windows.Forms.RadioButton();
            this.radColoracao = new System.Windows.Forms.RadioButton();
            this.radPlanar = new System.Windows.Forms.RadioButton();
            this.radEstrela = new System.Windows.Forms.RadioButton();
            this.radDjikstra = new System.Windows.Forms.RadioButton();
            this.radBfs = new System.Windows.Forms.RadioButton();
            this.radDfs = new System.Windows.Forms.RadioButton();
            this.btnAbrirXml = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlPrincipal.SuspendLayout();
            this.pnlEstrela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstrela)).BeginInit();
            this.pnlLegendas.SuspendLayout();
            this.grpLegendas.SuspendLayout();
            this.pnlExibicao.SuspendLayout();
            this.pnlConectividade.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlEstrela);
            this.pnlPrincipal.Controls.Add(this.pnlExibicao);
            this.pnlPrincipal.Controls.Add(this.pnlConfig);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(960, 544);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlEstrela
            // 
            this.pnlEstrela.Controls.Add(this.grdEstrela);
            this.pnlEstrela.Controls.Add(this.pnlLegendas);
            this.pnlEstrela.Location = new System.Drawing.Point(366, 29);
            this.pnlEstrela.Name = "pnlEstrela";
            this.pnlEstrela.Size = new System.Drawing.Size(548, 150);
            this.pnlEstrela.TabIndex = 2;
            // 
            // grdEstrela
            // 
            this.grdEstrela.AllowUserToResizeColumns = false;
            this.grdEstrela.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.grdEstrela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdEstrela.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstrela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdEstrela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstrela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEstrela.GridColor = System.Drawing.Color.LightGray;
            this.grdEstrela.Location = new System.Drawing.Point(0, 0);
            this.grdEstrela.Name = "grdEstrela";
            this.grdEstrela.RowHeadersVisible = false;
            this.grdEstrela.RowTemplate.Height = 40;
            this.grdEstrela.Size = new System.Drawing.Size(548, 96);
            this.grdEstrela.TabIndex = 2;
            this.grdEstrela.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdEstrela_CellFormatting);
            // 
            // pnlLegendas
            // 
            this.pnlLegendas.Controls.Add(this.grpLegendas);
            this.pnlLegendas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLegendas.Location = new System.Drawing.Point(0, 96);
            this.pnlLegendas.Name = "pnlLegendas";
            this.pnlLegendas.Size = new System.Drawing.Size(548, 54);
            this.pnlLegendas.TabIndex = 1;
            // 
            // grpLegendas
            // 
            this.grpLegendas.Controls.Add(this.lblVisitados);
            this.grpLegendas.Controls.Add(this.pnlVisitados);
            this.grpLegendas.Controls.Add(this.lblCaminhos);
            this.grpLegendas.Controls.Add(this.pnlCaminhos);
            this.grpLegendas.Controls.Add(this.lblPontoFinal);
            this.grpLegendas.Controls.Add(this.lblPontoInicial);
            this.grpLegendas.Controls.Add(this.lblCorMuro);
            this.grpLegendas.Controls.Add(this.pnlFinal);
            this.grpLegendas.Controls.Add(this.pnlInical);
            this.grpLegendas.Controls.Add(this.pnlCorMuro);
            this.grpLegendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLegendas.Location = new System.Drawing.Point(0, 0);
            this.grpLegendas.Name = "grpLegendas";
            this.grpLegendas.Size = new System.Drawing.Size(548, 54);
            this.grpLegendas.TabIndex = 0;
            this.grpLegendas.TabStop = false;
            this.grpLegendas.Text = "Legendas";
            // 
            // lblVisitados
            // 
            this.lblVisitados.AutoSize = true;
            this.lblVisitados.Location = new System.Drawing.Point(500, 27);
            this.lblVisitados.Name = "lblVisitados";
            this.lblVisitados.Size = new System.Drawing.Size(49, 13);
            this.lblVisitados.TabIndex = 8;
            this.lblVisitados.Text = "Visitados";
            // 
            // pnlVisitados
            // 
            this.pnlVisitados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVisitados.Location = new System.Drawing.Point(452, 19);
            this.pnlVisitados.Name = "pnlVisitados";
            this.pnlVisitados.Size = new System.Drawing.Size(42, 26);
            this.pnlVisitados.TabIndex = 7;
            // 
            // lblCaminhos
            // 
            this.lblCaminhos.AutoSize = true;
            this.lblCaminhos.Location = new System.Drawing.Point(393, 27);
            this.lblCaminhos.Name = "lblCaminhos";
            this.lblCaminhos.Size = new System.Drawing.Size(53, 13);
            this.lblCaminhos.TabIndex = 6;
            this.lblCaminhos.Text = "Caminhos";
            // 
            // pnlCaminhos
            // 
            this.pnlCaminhos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCaminhos.Location = new System.Drawing.Point(345, 19);
            this.pnlCaminhos.Name = "pnlCaminhos";
            this.pnlCaminhos.Size = new System.Drawing.Size(42, 26);
            this.pnlCaminhos.TabIndex = 5;
            // 
            // lblPontoFinal
            // 
            this.lblPontoFinal.AutoSize = true;
            this.lblPontoFinal.Location = new System.Drawing.Point(279, 27);
            this.lblPontoFinal.Name = "lblPontoFinal";
            this.lblPontoFinal.Size = new System.Drawing.Size(60, 13);
            this.lblPontoFinal.TabIndex = 4;
            this.lblPontoFinal.Text = "Ponto Final";
            // 
            // lblPontoInicial
            // 
            this.lblPontoInicial.AutoSize = true;
            this.lblPontoInicial.Location = new System.Drawing.Point(157, 27);
            this.lblPontoInicial.Name = "lblPontoInicial";
            this.lblPontoInicial.Size = new System.Drawing.Size(65, 13);
            this.lblPontoInicial.TabIndex = 3;
            this.lblPontoInicial.Text = "Ponto Inicial";
            // 
            // lblCorMuro
            // 
            this.lblCorMuro.AutoSize = true;
            this.lblCorMuro.Location = new System.Drawing.Point(54, 27);
            this.lblCorMuro.Name = "lblCorMuro";
            this.lblCorMuro.Size = new System.Drawing.Size(36, 13);
            this.lblCorMuro.TabIndex = 2;
            this.lblCorMuro.Text = "Muros";
            // 
            // pnlFinal
            // 
            this.pnlFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFinal.Location = new System.Drawing.Point(231, 19);
            this.pnlFinal.Name = "pnlFinal";
            this.pnlFinal.Size = new System.Drawing.Size(42, 26);
            this.pnlFinal.TabIndex = 2;
            // 
            // pnlInical
            // 
            this.pnlInical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInical.Location = new System.Drawing.Point(109, 19);
            this.pnlInical.Name = "pnlInical";
            this.pnlInical.Size = new System.Drawing.Size(42, 26);
            this.pnlInical.TabIndex = 1;
            // 
            // pnlCorMuro
            // 
            this.pnlCorMuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCorMuro.Location = new System.Drawing.Point(6, 19);
            this.pnlCorMuro.Name = "pnlCorMuro";
            this.pnlCorMuro.Size = new System.Drawing.Size(42, 26);
            this.pnlCorMuro.TabIndex = 0;
            // 
            // pnlExibicao
            // 
            this.pnlExibicao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExibicao.Controls.Add(this.txtLog);
            this.pnlExibicao.Controls.Add(this.pnlConectividade);
            this.pnlExibicao.Controls.Add(this.lblGrafo);
            this.pnlExibicao.Location = new System.Drawing.Point(366, 227);
            this.pnlExibicao.Name = "pnlExibicao";
            this.pnlExibicao.Size = new System.Drawing.Size(570, 305);
            this.pnlExibicao.TabIndex = 1;
            this.pnlExibicao.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlExibicao_Paint);
            // 
            // pnlConectividade
            // 
            this.pnlConectividade.Controls.Add(this.lblConexo);
            this.pnlConectividade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConectividade.Location = new System.Drawing.Point(0, 245);
            this.pnlConectividade.Name = "pnlConectividade";
            this.pnlConectividade.Size = new System.Drawing.Size(566, 31);
            this.pnlConectividade.TabIndex = 1;
            // 
            // lblConexo
            // 
            this.lblConexo.AutoSize = true;
            this.lblConexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexo.Location = new System.Drawing.Point(171, 3);
            this.lblConexo.Name = "lblConexo";
            this.lblConexo.Size = new System.Drawing.Size(0, 26);
            this.lblConexo.TabIndex = 0;
            // 
            // lblGrafo
            // 
            this.lblGrafo.AutoSize = true;
            this.lblGrafo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafo.Location = new System.Drawing.Point(0, 276);
            this.lblGrafo.Name = "lblGrafo";
            this.lblGrafo.Size = new System.Drawing.Size(0, 25);
            this.lblGrafo.TabIndex = 0;
            this.lblGrafo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGrafo.Visible = false;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.lblCusto);
            this.pnlConfig.Controls.Add(this.cboTipoCusto);
            this.pnlConfig.Controls.Add(this.txtCustoTotal);
            this.pnlConfig.Controls.Add(this.txtResposta);
            this.pnlConfig.Controls.Add(this.groupBox1);
            this.pnlConfig.Controls.Add(this.btnLer);
            this.pnlConfig.Controls.Add(this.txtXml);
            this.pnlConfig.Controls.Add(this.grpOpcoes);
            this.pnlConfig.Controls.Add(this.btnAbrirXml);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(330, 544);
            this.pnlConfig.TabIndex = 0;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.Location = new System.Drawing.Point(3, 349);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(48, 17);
            this.lblCusto.TabIndex = 12;
            this.lblCusto.Text = "Custo ";
            // 
            // cboTipoCusto
            // 
            this.cboTipoCusto.FormattingEnabled = true;
            this.cboTipoCusto.Items.AddRange(new object[] {
            "km",
            "m",
            "milhas",
            "cm",
            "mm"});
            this.cboTipoCusto.Location = new System.Drawing.Point(163, 349);
            this.cboTipoCusto.Name = "cboTipoCusto";
            this.cboTipoCusto.Size = new System.Drawing.Size(130, 21);
            this.cboTipoCusto.TabIndex = 11;
            // 
            // txtCustoTotal
            // 
            this.txtCustoTotal.Location = new System.Drawing.Point(57, 349);
            this.txtCustoTotal.Name = "txtCustoTotal";
            this.txtCustoTotal.ReadOnly = true;
            this.txtCustoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCustoTotal.TabIndex = 10;
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(3, 272);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.ReadOnly = true;
            this.txtResposta.Size = new System.Drawing.Size(324, 57);
            this.txtResposta.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVerticeInicial);
            this.groupBox1.Controls.Add(this.txtVerticeBusca);
            this.groupBox1.Controls.Add(this.lblVerticeBusca);
            this.groupBox1.Controls.Add(this.txtVerticeInicial);
            this.groupBox1.Location = new System.Drawing.Point(3, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblVerticeInicial
            // 
            this.lblVerticeInicial.AutoSize = true;
            this.lblVerticeInicial.Location = new System.Drawing.Point(6, 16);
            this.lblVerticeInicial.Name = "lblVerticeInicial";
            this.lblVerticeInicial.Size = new System.Drawing.Size(70, 13);
            this.lblVerticeInicial.TabIndex = 6;
            this.lblVerticeInicial.Text = "Vértice Inicial";
            // 
            // txtVerticeBusca
            // 
            this.txtVerticeBusca.Location = new System.Drawing.Point(9, 74);
            this.txtVerticeBusca.Name = "txtVerticeBusca";
            this.txtVerticeBusca.Size = new System.Drawing.Size(100, 20);
            this.txtVerticeBusca.TabIndex = 5;
            // 
            // lblVerticeBusca
            // 
            this.lblVerticeBusca.AutoSize = true;
            this.lblVerticeBusca.Location = new System.Drawing.Point(9, 55);
            this.lblVerticeBusca.Name = "lblVerticeBusca";
            this.lblVerticeBusca.Size = new System.Drawing.Size(65, 13);
            this.lblVerticeBusca.TabIndex = 7;
            this.lblVerticeBusca.Text = "Vértice Final";
            // 
            // txtVerticeInicial
            // 
            this.txtVerticeInicial.Location = new System.Drawing.Point(9, 32);
            this.txtVerticeInicial.Name = "txtVerticeInicial";
            this.txtVerticeInicial.Size = new System.Drawing.Size(100, 20);
            this.txtVerticeInicial.TabIndex = 4;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(3, 233);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 3;
            this.btnLer.Text = "Iniciar";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(3, 3);
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(290, 20);
            this.txtXml.TabIndex = 2;
            // 
            // grpOpcoes
            // 
            this.grpOpcoes.Controls.Add(this.radCaixeiro);
            this.grpOpcoes.Controls.Add(this.radColoracao);
            this.grpOpcoes.Controls.Add(this.radPlanar);
            this.grpOpcoes.Controls.Add(this.radEstrela);
            this.grpOpcoes.Controls.Add(this.radDjikstra);
            this.grpOpcoes.Controls.Add(this.radBfs);
            this.grpOpcoes.Controls.Add(this.radDfs);
            this.grpOpcoes.Location = new System.Drawing.Point(3, 29);
            this.grpOpcoes.Name = "grpOpcoes";
            this.grpOpcoes.Size = new System.Drawing.Size(290, 92);
            this.grpOpcoes.TabIndex = 1;
            this.grpOpcoes.TabStop = false;
            this.grpOpcoes.Text = "Opções";
            // 
            // radCaixeiro
            // 
            this.radCaixeiro.AutoSize = true;
            this.radCaixeiro.Checked = true;
            this.radCaixeiro.Location = new System.Drawing.Point(181, 19);
            this.radCaixeiro.Name = "radCaixeiro";
            this.radCaixeiro.Size = new System.Drawing.Size(103, 17);
            this.radCaixeiro.TabIndex = 6;
            this.radCaixeiro.TabStop = true;
            this.radCaixeiro.Text = "Caixeiro Viajante";
            this.radCaixeiro.UseVisualStyleBackColor = true;
            // 
            // radColoracao
            // 
            this.radColoracao.AutoSize = true;
            this.radColoracao.Location = new System.Drawing.Point(102, 65);
            this.radColoracao.Name = "radColoracao";
            this.radColoracao.Size = new System.Drawing.Size(73, 17);
            this.radColoracao.TabIndex = 5;
            this.radColoracao.Text = "Coloração";
            this.radColoracao.UseVisualStyleBackColor = true;
            // 
            // radPlanar
            // 
            this.radPlanar.AutoSize = true;
            this.radPlanar.Location = new System.Drawing.Point(102, 42);
            this.radPlanar.Name = "radPlanar";
            this.radPlanar.Size = new System.Drawing.Size(55, 17);
            this.radPlanar.TabIndex = 4;
            this.radPlanar.Text = "Planar";
            this.radPlanar.UseVisualStyleBackColor = true;
            // 
            // radEstrela
            // 
            this.radEstrela.AutoSize = true;
            this.radEstrela.Location = new System.Drawing.Point(102, 19);
            this.radEstrela.Name = "radEstrela";
            this.radEstrela.Size = new System.Drawing.Size(36, 17);
            this.radEstrela.TabIndex = 3;
            this.radEstrela.Text = "A*";
            this.radEstrela.UseVisualStyleBackColor = true;
            this.radEstrela.CheckedChanged += new System.EventHandler(this.radEstrela_CheckedChanged);
            // 
            // radDjikstra
            // 
            this.radDjikstra.AutoSize = true;
            this.radDjikstra.Location = new System.Drawing.Point(9, 65);
            this.radDjikstra.Name = "radDjikstra";
            this.radDjikstra.Size = new System.Drawing.Size(77, 17);
            this.radDjikstra.TabIndex = 2;
            this.radDjikstra.Text = "DJIKSTRA";
            this.radDjikstra.UseVisualStyleBackColor = true;
            this.radDjikstra.CheckedChanged += new System.EventHandler(this.radDjikstra_CheckedChanged);
            // 
            // radBfs
            // 
            this.radBfs.AutoSize = true;
            this.radBfs.Location = new System.Drawing.Point(9, 42);
            this.radBfs.Name = "radBfs";
            this.radBfs.Size = new System.Drawing.Size(45, 17);
            this.radBfs.TabIndex = 1;
            this.radBfs.Text = "BFS";
            this.radBfs.UseVisualStyleBackColor = true;
            // 
            // radDfs
            // 
            this.radDfs.AutoSize = true;
            this.radDfs.Location = new System.Drawing.Point(9, 19);
            this.radDfs.Name = "radDfs";
            this.radDfs.Size = new System.Drawing.Size(46, 17);
            this.radDfs.TabIndex = 0;
            this.radDfs.Text = "DFS";
            this.radDfs.UseVisualStyleBackColor = true;
            // 
            // btnAbrirXml
            // 
            this.btnAbrirXml.FlatAppearance.BorderSize = 0;
            this.btnAbrirXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirXml.Image = global::Grafos.Properties.Resources._7547_16x16;
            this.btnAbrirXml.Location = new System.Drawing.Point(299, 1);
            this.btnAbrirXml.Name = "btnAbrirXml";
            this.btnAbrirXml.Size = new System.Drawing.Size(28, 23);
            this.btnAbrirXml.TabIndex = 0;
            this.btnAbrirXml.UseVisualStyleBackColor = true;
            this.btnAbrirXml.Click += new System.EventHandler(this.btnAbrirXml_Click);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(566, 245);
            this.txtLog.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 544);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "Form1";
            this.Text = "-- Grafos --";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlEstrela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEstrela)).EndInit();
            this.pnlLegendas.ResumeLayout(false);
            this.grpLegendas.ResumeLayout(false);
            this.grpLegendas.PerformLayout();
            this.pnlExibicao.ResumeLayout(false);
            this.pnlExibicao.PerformLayout();
            this.pnlConectividade.ResumeLayout(false);
            this.pnlConectividade.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOpcoes.ResumeLayout(false);
            this.grpOpcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlExibicao;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.GroupBox grpOpcoes;
        private System.Windows.Forms.RadioButton radBfs;
        private System.Windows.Forms.RadioButton radDfs;
        private System.Windows.Forms.Button btnAbrirXml;
        private System.Windows.Forms.Label lblGrafo;
        private System.Windows.Forms.Panel pnlConectividade;
        private System.Windows.Forms.Label lblConexo;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.RadioButton radDjikstra;
        private System.Windows.Forms.Label lblVerticeBusca;
        private System.Windows.Forms.Label lblVerticeInicial;
        private System.Windows.Forms.TextBox txtVerticeBusca;
        private System.Windows.Forms.TextBox txtVerticeInicial;
        private System.Windows.Forms.RadioButton radEstrela;
        private System.Windows.Forms.Panel pnlEstrela;
        private System.Windows.Forms.RadioButton radPlanar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radColoracao;
        private System.Windows.Forms.Panel pnlLegendas;
        private System.Windows.Forms.GroupBox grpLegendas;
        private System.Windows.Forms.Label lblPontoFinal;
        private System.Windows.Forms.Label lblPontoInicial;
        private System.Windows.Forms.Label lblCorMuro;
        private System.Windows.Forms.Panel pnlFinal;
        private System.Windows.Forms.Panel pnlInical;
        private System.Windows.Forms.Panel pnlCorMuro;
        private System.Windows.Forms.Label lblCaminhos;
        private System.Windows.Forms.Panel pnlCaminhos;
        private System.Windows.Forms.DataGridView grdEstrela;
        private System.Windows.Forms.Label lblVisitados;
        private System.Windows.Forms.Panel pnlVisitados;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.RadioButton radCaixeiro;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.ComboBox cboTipoCusto;
        private System.Windows.Forms.TextBox txtCustoTotal;
        private System.Windows.Forms.TextBox txtLog;
    }
}

