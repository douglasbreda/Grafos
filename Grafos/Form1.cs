using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        /// leitor de xml
        /// </summary>
        private LeitorXml xml;

        #endregion Fim [Atributos]

        #region [Construtores]
        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Form1()
        {
            InitializeComponent();
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
                xml.ExecutarGrafo(radDfs.Checked, radBfs.Checked, radDjikstra.Checked);
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
                MessageBox.Show("É necessário informar um xml","", MessageBoxButtons.OK);
            }
        }

        #endregion Fim [Eventos]

        #region [Métodos]

        private void ConfigurarTela()
        {
            xml = new LeitorXml();
            xml.GrafoFromXml();
            this.txtXml.Text = xml.CaminhoXml;
            this.lblConexo.Text = "";
            lblGrafo.Text = "";
        }

        #endregion Fim [Métodos]

      
    }
}
