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

        private DataGridViewCellStyle oEstiloVisitados = new DataGridViewCellStyle();

        private List<Tuple<int, Brush>> listaCores = new List<Tuple<int, Brush>>();

        #endregion Fim [Atributos]

        #region [Construtores]
        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            
            ConfigurarPaineis();

            ConfigurarCoresEstilos();

            ConfigurarCamposDjikstra();
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
                    xml.ExecutarGrafo(radDfs.Checked, radBfs.Checked, radDjikstra.Checked, txtVerticeInicial.Text, txtVerticeBusca.Text, radEstrela.Checked, radPlanar.Checked, radColoracao.Checked);
                    pnlExibicao_Paint(null, new PaintEventArgs(pnlExibicao.CreateGraphics(), pnlExibicao.DisplayRectangle));
                    //this.lblGrafo.Text = xml.GrafoDefinicao;
                    txtResposta.Clear();
                    this.txtResposta.Text = xml.GrafoDefinicao;
                    //if (xml.Conexo)
                    //{
                    //    if (xml.GrafoDefinicao != null)
                    //    {
                    //        lblConexo.Text = "O grafo é conexo";
                    //        lblConexo.ForeColor = Color.Green;
                    //    }
                    //    else
                    //        lblConexo.Text = "";
                    //}
                    //else
                    //{
                    //    if (xml.GrafoDefinicao != null)
                    //    {
                    //        lblConexo.Text = "O grafo não é conexo";
                    //        lblConexo.ForeColor = Color.Red;
                    //    }
                    //    else
                    //    {
                    //        lblConexo.Text = "";
                    //    }
                    //}
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
            ConfigurarCamposDjikstra();
        }

        private void pnlExibicao_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.Control);
            DesenharGrafo(e.Graphics, e.ClipRectangle);
        }

        private void grdEstrela_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1)
                PintarCelulas(e);
        }

        private void radEstrela_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarPaineis();
            if (radEstrela.Checked)
                txtXml.Clear();
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
            Pen pen = new Pen(Color.LightBlue, 3);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.NoAnchor;
            

            if (xml != null)
            {
                if (xml.grafo.Vertices.Count > 0)
                {

                    if (radColoracao.Checked)
                        DefinirCorColoracao();

                    foreach (Vertice vertice in xml.grafo.Vertices)
                    {
                        if (xml.GrafoDefinicao != null)
                        {
                            if (!xml.GrafoDefinicao.Contains(vertice.Rotulo))
                            {
                                if (!radColoracao.Checked)
                                {
                                    if (radDjikstra.Checked)
                                    {
                                        if (xml.GrafoDefinicao.Contains(vertice.Rotulo))
                                            graphics.FillEllipse(Brushes.LightGreen, vertice.PosX, vertice.PosY, 50, 50);
                                    }
                                    else
                                        graphics.FillEllipse(Brushes.Yellow, vertice.PosX, vertice.PosY, 50, 50);
                                }
                                else
                                    graphics.FillEllipse(BuscarCor(vertice.CorVertice), vertice.PosX, vertice.PosY, 50, 50);
                            }
                            else
                                if (!radColoracao.Checked)
                            {
                                if (radDjikstra.Checked)
                                {
                                    if (xml.GrafoDefinicao.Contains(vertice.Rotulo))
                                        graphics.FillEllipse(Brushes.LightGreen, vertice.PosX, vertice.PosY, 50, 50);
                                }
                                else
                                    graphics.FillEllipse(Brushes.LightBlue, vertice.PosX, vertice.PosY, 50, 50);
                            }
                            else
                                graphics.FillEllipse(BuscarCor(vertice.CorVertice), vertice.PosX, vertice.PosY, 50, 50);
                        }
                        
                        foreach (Arco arco in vertice.listaArcos)
                        {
                            if (radDjikstra.Checked)
                            {
                                if (xml.GrafoDefinicao != null)
                                {
                                    if (xml.GrafoDefinicao.Contains(arco.Origem.Rotulo))
                                    {
                                        graphics.DrawLine(Pens.Red, arco.Origem.PosX + 22, arco.Origem.PosY + 17, arco.Destino.PosX + 22, arco.Destino.PosY + 17);
                                    }
                                    else
                                        graphics.DrawLine(pen, arco.Origem.PosX + 22, arco.Origem.PosY + 17, arco.Destino.PosX + 22, arco.Destino.PosY + 17);
                                }
                            }
                            else
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
                {
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = oEstiloInicial;
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Value = "";
                }
                else if (grdEstrela[p.ColumnIndex, p.RowIndex].Value.Equals("Muro"))
                {
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = oEstiloMuro;
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Value = "";
                }
                else if (grdEstrela[p.ColumnIndex, p.RowIndex].Value.Equals("Fim"))
                {
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = oEstiloFinal;
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Value = "";
                }
                else if (grdEstrela[p.ColumnIndex, p.RowIndex].Value.Equals("X"))
                {
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = oEstiloCaminho;
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Value = "";
                }
                else if (grdEstrela[p.ColumnIndex, p.RowIndex].Value.Equals("li"))
                {
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = new DataGridViewCellStyle();
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Value = "";
                }
                else if(grdEstrela[p.ColumnIndex, p.RowIndex].Value.Equals("Visitado"))
                {
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Style = oEstiloVisitados;
                    grdEstrela.Rows[p.RowIndex].Cells[p.ColumnIndex].Value = " ";
                }
            }
        }

        private void ConfigurarPaineis()
        {
            if (radEstrela.Checked)
            {
                pnlExibicao.Visible = false;
                pnlEstrela.Visible = true;
                pnlEstrela.Dock = DockStyle.Fill;
            }
            else
            {
                pnlEstrela.Visible = false;
                pnlExibicao.Visible = true;
                pnlExibicao.Dock = DockStyle.Fill;
            }

        }

        private void ConfigurarCoresEstilos()
        {
            oEstiloInicial.BackColor =
            pnlInical.BackColor = Color.Green;

            oEstiloMuro.BackColor =
            pnlCorMuro.BackColor = Color.Gray; 

            oEstiloFinal.BackColor = 
            pnlFinal.BackColor = Color.Red;

            oEstiloCaminho.BackColor = 
            pnlCaminhos.BackColor = Color.LightBlue;

            oEstiloVisitados.BackColor =
            pnlVisitados.BackColor = Color.Yellow;

        }
        private void ConfigurarCamposDjikstra()
        {
            if (radDjikstra.Checked)
            {
                lblVerticeInicial.Enabled = true;
                lblVerticeBusca.Enabled = true;
                txtVerticeBusca.Enabled = true;
                txtVerticeInicial.Enabled = true;
            }
            else
            {
                lblVerticeInicial.Enabled = false;
                lblVerticeBusca.Enabled = false;
                txtVerticeBusca.Enabled = false;
                txtVerticeInicial.Enabled = false;
            }
        }

        private void DefinirCorColoracao()
        {
            Brush[] brushes = new Brush[] { Brushes.AliceBlue,
                Brushes.AntiqueWhite,
                Brushes.Aqua,
                Brushes.YellowGreen,
                Brushes.Red,
                Brushes.Plum,
                Brushes.Salmon,
                Brushes.Blue,
                Brushes.Black,
                Brushes.Bisque,
                Brushes.FloralWhite,
                Brushes.LightGreen,
                Brushes.Olive,
                Brushes.Orange,
                Brushes.MediumAquamarine,
                Brushes.Moccasin,
                Brushes.PaleGreen,
                Brushes.Sienna,
                Brushes.Teal,
                Brushes.White,
                Brushes.Orchid,
                Brushes.NavajoWhite,
                Brushes.Goldenrod,
                Brushes.DarkSlateGray,
                Brushes.BlueViolet,
                Brushes.Brown,
                Brushes.Crimson,
                Brushes.Cyan,
                Brushes.Khaki,
                Brushes.Beige,
                Brushes.DarkBlue,
                Brushes.Linen,
                Brushes.Lime
            };
            Random r = new Random();
            if (xml.CoresColoracao != null)
            {
                for (int i = 0; i < xml.CoresColoracao.Count; i++)
                {
                    listaCores.Add(new Tuple<int, Brush>(xml.CoresColoracao[i], brushes[r.Next(brushes.Length)]));
                }
            }
        }

        private Brush BuscarCor(int iCor)
        {
            return listaCores.Find(item => item.Item1 == iCor).Item2;
        }

        private void LimparPaineis()
        {
            
        }
        
        #endregion Fim [Métodos]
    }
}
