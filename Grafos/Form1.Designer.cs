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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlExibicao = new System.Windows.Forms.Panel();
            this.pnlConectividade = new System.Windows.Forms.Panel();
            this.lblConexo = new System.Windows.Forms.Label();
            this.lblGrafo = new System.Windows.Forms.Label();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.btnLer = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.grpOpcoes = new System.Windows.Forms.GroupBox();
            this.radBfs = new System.Windows.Forms.RadioButton();
            this.radDfs = new System.Windows.Forms.RadioButton();
            this.btnAbrirXml = new System.Windows.Forms.Button();
            this.radDjikstra = new System.Windows.Forms.RadioButton();
            this.pnlPrincipal.SuspendLayout();
            this.pnlExibicao.SuspendLayout();
            this.pnlConectividade.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.grpOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlExibicao);
            this.pnlPrincipal.Controls.Add(this.pnlConfig);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(541, 361);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlExibicao
            // 
            this.pnlExibicao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExibicao.Controls.Add(this.pnlConectividade);
            this.pnlExibicao.Controls.Add(this.lblGrafo);
            this.pnlExibicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExibicao.Location = new System.Drawing.Point(0, 84);
            this.pnlExibicao.Name = "pnlExibicao";
            this.pnlExibicao.Size = new System.Drawing.Size(541, 277);
            this.pnlExibicao.TabIndex = 1;
            // 
            // pnlConectividade
            // 
            this.pnlConectividade.Controls.Add(this.lblConexo);
            this.pnlConectividade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConectividade.Location = new System.Drawing.Point(0, 242);
            this.pnlConectividade.Name = "pnlConectividade";
            this.pnlConectividade.Size = new System.Drawing.Size(537, 31);
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
            this.pnlConfig.Controls.Add(this.btnLer);
            this.pnlConfig.Controls.Add(this.txtXml);
            this.pnlConfig.Controls.Add(this.grpOpcoes);
            this.pnlConfig.Controls.Add(this.btnAbrirXml);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(541, 84);
            this.pnlConfig.TabIndex = 0;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(463, 56);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 3;
            this.btnLer.Text = "Ler Grafo";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(137, 29);
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(320, 20);
            this.txtXml.TabIndex = 2;
            // 
            // grpOpcoes
            // 
            this.grpOpcoes.Controls.Add(this.radDjikstra);
            this.grpOpcoes.Controls.Add(this.radBfs);
            this.grpOpcoes.Controls.Add(this.radDfs);
            this.grpOpcoes.Location = new System.Drawing.Point(3, 3);
            this.grpOpcoes.Name = "grpOpcoes";
            this.grpOpcoes.Size = new System.Drawing.Size(128, 75);
            this.grpOpcoes.TabIndex = 1;
            this.grpOpcoes.TabStop = false;
            this.grpOpcoes.Text = "Opções";
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
            this.btnAbrirXml.Location = new System.Drawing.Point(463, 27);
            this.btnAbrirXml.Name = "btnAbrirXml";
            this.btnAbrirXml.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirXml.TabIndex = 0;
            this.btnAbrirXml.Text = "Abrir Xml";
            this.btnAbrirXml.UseVisualStyleBackColor = true;
            this.btnAbrirXml.Click += new System.EventHandler(this.btnAbrirXml_Click);
            // 
            // radDjikstra
            // 
            this.radDjikstra.AutoSize = true;
            this.radDjikstra.Location = new System.Drawing.Point(9, 42);
            this.radDjikstra.Name = "radDjikstra";
            this.radDjikstra.Size = new System.Drawing.Size(60, 17);
            this.radDjikstra.TabIndex = 2;
            this.radDjikstra.TabStop = true;
            this.radDjikstra.Text = "Djikstra";
            this.radDjikstra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 361);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlPrincipal.ResumeLayout(false);
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
    }
}

