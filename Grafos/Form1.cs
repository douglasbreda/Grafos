using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Form1 : Form
    {
        #region [Atributos]

        /// <summary>
        /// Leitor de xml
        /// </summary>
        private LeitorXml xml;

        /// <summary>
        /// Leitor de xml da estrela
        /// </summary>
        private LeitorXmlStar xmlStar;

        private DataGridViewCellStyle oEstiloInicial = new DataGridViewCellStyle();

        private DataGridViewCellStyle oEstiloMuro = new DataGridViewCellStyle();

        private DataGridViewCellStyle oEstiloFinal = new DataGridViewCellStyle();

        private DataGridViewCellStyle oEstiloCaminho = new DataGridViewCellStyle();
        #endregion Fim [Atributos]

        #region [Construtores]
        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            oEstiloInicial.BackColor = Color.Green;
            oEstiloMuro.BackColor = Color.Gray;
            oEstiloFinal.BackColor = Color.Red;
            oEstiloCaminho.BackColor = Color.LightBlue;
        }

        #endregion Fim [Construtores]

        #region [Eventos]
        private void btnAbrirXml_Click(object sender, EventArgs e)
        {
            this.ConfigurarTela();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            if (!txtXml.Text.Equals(""))
            {
                if (!radEstrela.Checked)
                {
                    xml.ExecutarGrafo(radDfs.Checked, radBfs.Checked, radDjikstra.Checked, txtVerticeInicial.Text, txtVerticeBusca.Text, radEstrela.Checked, radPlanar.Checked);
                    pnlExibicao_Paint(null, new PaintEventArgs(pnlExibicao.CreateGraphics(), pnlExibicao.DisplayRectangle));
                    this.lblGrafo.Text = xml.GrafoDefinicao;
                    if (xml.Conexo)
                    {
                        if (xml.GrafoDefinicao != null)
                        {
                            lblConexo.Text = "O grafo é conexo";
                            lblConexo.ForeColor = Color.Green;
                        }
                        else
                            lblConexo.Text = "";
                    }
                    else
                    {
                        if (xml.GrafoDefinicao != null)
                        {
                            lblConexo.Text = "O grafo não é conexo";
                            lblConexo.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblConexo.Text = "";
                        }
                    }
                }
                else
                {
                    xmlStar.ExecutarGrafo();
                    grdEstrela.DataSource = xmlStar.Estrela;
                }
            }
            else
            {
                MessageBox.Show("É necessário informar um xml","", MessageBoxButtons.OK);
            }


        }

        private void radDjikstra_CheckedChanged(object sender, EventArgs e)
        {
            if (radDjikstra.Checked)
            {
                lblVerticeInicial.Visible = true;
                lblVerticeBusca.Visible = true;
                txtVerticeBusca.Visible = true;
                txtVerticeInicial.Visible = true;
            }
            else
            {
                lblVerticeInicial.Visible = false;
                lblVerticeBusca.Visible = false;
                txtVerticeBusca.Visible = false;
                txtVerticeInicial.Visible = false;
            }
        }

        private void pnlExibicao_Paint(object sender, PaintEventArgs e)
        {
            DesenharGrafo(e.Graphics, e.ClipRectangle);
        }

        private void grdEstrela_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1)
                PintarCelulas(e);
        }
        #endregion Fim [Eventos]

        #region [Métodos]

        private void ConfigurarTela()
        {
            if (!radEstrela.Checked)
            {
                xml = new LeitorXml();
                xml.GrafoFromXml();
                this.txtXml.Text = xml.CaminhoXml;
                this.lblConexo.Text = "";
                lblGrafo.Text = "";
            }
            else
            {
                xmlStar = new LeitorXmlStar();
                xmlStar.GrafoFromXml();
                txtXml.Text = xmlStar.CaminhoXml;
            }
        }

        private void DesenharGrafo(Graphics graphics, Rectangle rectangle)
        {
            Pen pen = new Pen(Color.Cyan, 3);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.NoAnchor;
            

            if (xml != null)
            {
                if (xml.grafo.Vertices.Count > 0)
                {
                    foreach (Vertice vertice in xml.grafo.Vertices)
                    {
                        if (xml.GrafoDefinicao != null)
                        {
                            if (!xml.GrafoDefinicao.Contains(vertice.Rotulo))
                                graphics.FillEllipse(Brushes.DarkGreen, vertice.PosX, vertice.PosY, 50, 50);
                            else
                                graphics.FillEllipse(Brushes.Cyan, vertice.PosX, vertice.PosY, 50, 50);
                        }
                        
                        foreach (Arco arco in vertice.listaArcos)
                        {
                            graphics.DrawLine(pen, arco.Origem.PosX + 22, arco.Origem.PosY + 17, arco.Destino.PosX + 22, arco.Destino.PosY + 17);
                        }

                        graphics.DrawString(vertice.Rotulo, this.Font, Brushes.Black, vertice.PosX + 20, vertice.PosY + 17);
                    }
                }
            }
        }

        private void PintarCelulas(DataGridViewCellFormattingEventArgs p)
        {
            if (grdEstrela[p.ColumnIndex, p.RowIndex].Value != null)
            {
                if (grdEstrela[p.ColumnIndex, p.RowIndex].Value.Equals("Inicio"))
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = oEstiloInicial;
                else if (grdEstrela[p.ColumnIndex, p.RowIndex].Value.Equals("Muro"))
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = oEstiloMuro;
                else if (grdEstrela[p.ColumnIndex, p.RowIndex].Value.Equals("Fim"))
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = oEstiloFinal;
                else if (grdEstrela[p.ColumnIndex, p.RowIndex].Value.Equals("X"))
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = oEstiloCaminho;
            }
        }


        #endregion Fim [Métodos]

        
    }
}
