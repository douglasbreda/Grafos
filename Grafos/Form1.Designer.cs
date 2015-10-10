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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlEstrela = new System.Windows.Forms.Panel();
            this.grdEstrela = new System.Windows.Forms.DataGridView();
            this.pnlExibicao = new System.Windows.Forms.Panel();
            this.pnlConectividade = new System.Windows.Forms.Panel();
            this.lblConexo = new System.Windows.Forms.Label();
            this.lblGrafo = new System.Windows.Forms.Label();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.lblVerticeBusca = new System.Windows.Forms.Label();
            this.lblVerticeInicial = new System.Windows.Forms.Label();
            this.txtVerticeBusca = new System.Windows.Forms.TextBox();
            this.txtVerticeInicial = new System.Windows.Forms.TextBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.grpOpcoes = new System.Windows.Forms.GroupBox();
            this.radPlanar = new System.Windows.Forms.RadioButton();
            this.radEstrela = new System.Windows.Forms.RadioButton();
            this.radDjikstra = new System.Windows.Forms.RadioButton();
            this.radBfs = new System.Windows.Forms.RadioButton();
            this.radDfs = new System.Windows.Forms.RadioButton();
            this.btnAbrirXml = new System.Windows.Forms.Button();
            this.pnlPrincipal.SuspendLayout();
            this.pnlEstrela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstrela)).BeginInit();
            this.pnlExibicao.SuspendLayout();
            this.pnlConectividade.SuspendLayout();
            this.pnlConfig.SuspendLayout();
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
            this.pnlEstrela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstrela.Location = new System.Drawing.Point(948, 100);
            this.pnlEstrela.Name = "pnlEstrela";
            this.pnlEstrela.Size = new System.Drawing.Size(12, 444);
            this.pnlEstrela.TabIndex = 2;
            // 
            // grdEstrela
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdEstrela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEstrela.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstrela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdEstrela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstrela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEstrela.GridColor = System.Drawing.Color.LightGray;
            this.grdEstrela.Location = new System.Drawing.Point(0, 0);
            this.grdEstrela.Name = "grdEstrela";
            this.grdEstrela.RowHeadersVisible = false;
            this.grdEstrela.Size = new System.Drawing.Size(12, 444);
            this.grdEstrela.TabIndex = 0;
            this.grdEstrela.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdEstrela_CellFormatting);
            // 
            // pnlExibicao
            // 
            this.pnlExibicao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExibicao.Controls.Add(this.pnlConectividade);
            this.pnlExibicao.Controls.Add(this.lblGrafo);
            this.pnlExibicao.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlExibicao.Location = new System.Drawing.Point(0, 100);
            this.pnlExibicao.Name = "pnlExibicao";
            this.pnlExibicao.Size = new System.Drawing.Size(948, 444);
            this.pnlExibicao.TabIndex = 1;
            this.pnlExibicao.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlExibicao_Paint);
            // 
            // pnlConectividade
            // 
            this.pnlConectividade.Controls.Add(this.lblConexo);
            this.pnlConectividade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConectividade.Location = new System.Drawing.Point(0, 409);
            this.pnlConectividade.Name = "pnlConectividade";
            this.pnlConectividade.Size = new System.Drawing.Size(944, 31);
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
            this.lblGrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafo.Location = new System.Drawing.Point(3, 1);
            this.lblGrafo.Name = "lblGrafo";
            this.lblGrafo.Size = new System.Drawing.Size(0, 25);
            this.lblGrafo.TabIndex = 0;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.lblVerticeBusca);
            this.pnlConfig.Controls.Add(this.lblVerticeInicial);
            this.pnlConfig.Controls.Add(this.txtVerticeBusca);
            this.pnlConfig.Controls.Add(this.txtVerticeInicial);
            this.pnlConfig.Controls.Add(this.btnLer);
            this.pnlConfig.Controls.Add(this.txtXml);
            this.pnlConfig.Controls.Add(this.grpOpcoes);
            this.pnlConfig.Controls.Add(this.btnAbrirXml);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(960, 100);
            this.pnlConfig.TabIndex = 0;
            // 
            // lblVerticeBusca
            // 
            this.lblVerticeBusca.AutoSize = true;
            this.lblVerticeBusca.Location = new System.Drawing.Point(467, 35);
            this.lblVerticeBusca.Name = "lblVerticeBusca";
            this.lblVerticeBusca.Size = new System.Drawing.Size(65, 13);
            this.lblVerticeBusca.TabIndex = 7;
            this.lblVerticeBusca.Text = "Vértice Final";
            this.lblVerticeBusca.Visible = false;
            // 
            // lblVerticeInicial
            // 
            this.lblVerticeInicial.AutoSize = true;
            this.lblVerticeInicial.Location = new System.Drawing.Point(364, 35);
            this.lblVerticeInicial.Name = "lblVerticeInicial";
            this.lblVerticeInicial.Size = new System.Drawing.Size(70, 13);
            this.lblVerticeInicial.TabIndex = 6;
            this.lblVerticeInicial.Text = "Vértice Inicial";
            this.lblVerticeInicial.Visible = false;
            // 
            // txtVerticeBusca
            // 
            this.txtVerticeBusca.Location = new System.Drawing.Point(470, 51);
            this.txtVerticeBusca.Name = "txtVerticeBusca";
            this.txtVerticeBusca.Size = new System.Drawing.Size(100, 20);
            this.txtVerticeBusca.TabIndex = 5;
            this.txtVerticeBusca.Visible = false;
            // 
            // txtVerticeInicial
            // 
            this.txtVerticeInicial.Location = new System.Drawing.Point(364, 51);
            this.txtVerticeInicial.Name = "txtVerticeInicial";
            this.txtVerticeInicial.Size = new System.Drawing.Size(100, 20);
            this.txtVerticeInicial.TabIndex = 4;
            this.txtVerticeInicial.Visible = false;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(3, 73);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 3;
            this.btnLer.Text = "Ler Grafo";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(3, 3);
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(492, 20);
            this.txtXml.TabIndex = 2;
            // 
            // grpOpcoes
            // 
            this.grpOpcoes.Controls.Add(this.radPlanar);
            this.grpOpcoes.Controls.Add(this.radEstrela);
            this.grpOpcoes.Controls.Add(this.radDjikstra);
            this.grpOpcoes.Controls.Add(this.radBfs);
            this.grpOpcoes.Controls.Add(this.radDfs);
            this.grpOpcoes.Location = new System.Drawing.Point(3, 29);
            this.grpOpcoes.Name = "grpOpcoes";
            this.grpOpcoes.Size = new System.Drawing.Size(355, 42);
            this.grpOpcoes.TabIndex = 1;
            this.grpOpcoes.TabStop = false;
            this.grpOpcoes.Text = "Opções";
            // 
            // radPlanar
            // 
            this.radPlanar.AutoSize = true;
            this.radPlanar.Location = new System.Drawing.Point(235, 19);
            this.radPlanar.Name = "radPlanar";
            this.radPlanar.Size = new System.Drawing.Size(55, 17);
            this.radPlanar.TabIndex = 4;
            this.radPlanar.TabStop = true;
            this.radPlanar.Text = "Planar";
            this.radPlanar.UseVisualStyleBackColor = true;
            // 
            // radEstrela
            // 
            this.radEstrela.AutoSize = true;
            this.radEstrela.Location = new System.Drawing.Point(193, 19);
            this.radEstrela.Name = "radEstrela";
            this.radEstrela.Size = new System.Drawing.Size(36, 17);
            this.radEstrela.TabIndex = 3;
            this.radEstrela.TabStop = true;
            this.radEstrela.Text = "A*";
            this.radEstrela.UseVisualStyleBackColor = true;
            // 
            // radDjikstra
            // 
            this.radDjikstra.AutoSize = true;
            this.radDjikstra.Location = new System.Drawing.Point(110, 19);
            this.radDjikstra.Name = "radDjikstra";
            this.radDjikstra.Size = new System.Drawing.Size(77, 17);
            this.radDjikstra.TabIndex = 2;
            this.radDjikstra.TabStop = true;
            this.radDjikstra.Text = "DJIKSTRA";
            this.radDjikstra.UseVisualStyleBackColor = true;
            this.radDjikstra.CheckedChanged += new System.EventHandler(this.radDjikstra_CheckedChanged);
            // 
            // radBfs
            // 
            this.radBfs.AutoSize = true;
            this.radBfs.Location = new System.Drawing.Point(61, 19);
            this.radBfs.Name = "radBfs";
            this.radBfs.Size = new System.Drawing.Size(45, 17);
            this.radBfs.TabIndex = 1;
            this.radBfs.Text = "BFS";
            this.radBfs.UseVisualStyleBackColor = true;
            // 
            // radDfs
            // 
            this.radDfs.AutoSize = true;
            this.radDfs.Checked = true;
            this.radDfs.Location = new System.Drawing.Point(9, 19);
            this.radDfs.Name = "radDfs";
            this.radDfs.Size = new System.Drawing.Size(46, 17);
            this.radDfs.TabIndex = 0;
            this.radDfs.TabStop = true;
            this.radDfs.Text = "DFS";
            this.radDfs.UseVisualStyleBackColor = true;
            // 
            // btnAbrirXml
            // 
            this.btnAbrirXml.FlatAppearance.BorderSize = 0;
            this.btnAbrirXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirXml.Image = global::Grafos.Properties.Resources._7547_16x16;
            this.btnAbrirXml.Location = new System.Drawing.Point(501, 0);
            this.btnAbrirXml.Name = "btnAbrirXml";
            this.btnAbrirXml.Size = new System.Drawing.Size(28, 23);
            this.btnAbrirXml.TabIndex = 0;
            this.btnAbrirXml.UseVisualStyleBackColor = true;
            this.btnAbrirXml.Click += new System.EventHandler(this.btnAbrirXml_Click);
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
            this.pnlExibicao.ResumeLayout(false);
            this.pnlExibicao.PerformLayout();
            this.pnlConectividade.ResumeLayout(false);
            this.pnlConectividade.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
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
        private System.Windows.Forms.DataGridView grdEstrela;
        private System.Windows.Forms.RadioButton radPlanar;
    }
}

