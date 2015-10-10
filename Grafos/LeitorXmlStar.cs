using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Grafos
{

    public class LeitorXmlStar
    {

        #region [Construtor]
        public LeitorXmlStar()
        {
            ConfigStar = new StarConfig();
        }

        #endregion Fim [Construtor]

        #region [Propriedades]

        /// <summary>
        /// Caminho do arquivo xml
        /// </summary>
        public string CaminhoXml { get; set; }

        /// <summary>
        /// Classe que contém as configurações da estrela
        /// </summary>
        public StarConfig ConfigStar { get; set; }

        /// <summary>
        /// Tabela que retorna a matriz da estrela
        /// </summary>
        public DataTable Estrela { get; set; }

        #endregion Fim [Propriedades]

        #region [Métodos]

        public Object GrafoFromXml()
        {
            XmlDocument xml = new XmlDocument();
            OpenFileDialog janelaArquivos = new OpenFileDialog();
            janelaArquivos.Filter = "XML Files| *.xml";
            FileStream file;

            if (janelaArquivos.ShowDialog() == DialogResult.OK)
            {
                file = new FileStream(janelaArquivos.FileName, FileMode.Open);
                CaminhoXml = janelaArquivos.FileName;
                
                try
                {
                    xml.Load(file);

                    //Número de linhas
                    XmlNodeList nodeLinha = xml.GetElementsByTagName("LINHAS");
                    XmlNode linha = nodeLinha.Item(0);
                    XmlElement elementLinhas = (XmlElement)linha;
                    ConfigStar.Linhas = Convert.ToInt32(elementLinhas.InnerText);

                    //Número de colunas
                    XmlNodeList nodeColuna = xml.GetElementsByTagName("COLUNAS");
                    XmlNode coluna = nodeColuna.Item(0);
                    XmlElement elementColunas = (XmlElement)coluna;
                    ConfigStar.Colunas = Convert.ToInt32(elementColunas.InnerText);

                    //Posição Inicial
                    XmlNodeList nodeInicial = xml.GetElementsByTagName("INICIAL");
                    XmlNode inicial = nodeInicial.Item(0);
                    XmlElement elementInicial = (XmlElement)inicial;
                    ConfigStar.SetPosicaoInicial(elementInicial.InnerText);

                    //Posição Final
                    XmlNodeList nodeFinal = xml.GetElementsByTagName("FINAL");
                    XmlNode final = nodeFinal.Item(0);
                    XmlElement elementFinal = (XmlElement)final;
                    ConfigStar.SetPosicaoFinal(elementFinal.InnerText);

                    //Barreiras
                    XmlNodeList nodesBarreiras = xml.GetElementsByTagName("MURO");
                    for (int i = 0; i < nodesBarreiras.Count; i++)
                    {
                        XmlNode barreira = nodesBarreiras.Item(i);
                        if (barreira.NodeType== XmlNodeType.Element)
                        {
                            XmlElement element = (XmlElement)barreira;
                            ConfigStar.AdicionarMuro(element.InnerText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
            return null;
        }

        public void ExecutarGrafo()
        {
            AStar star = new AStar(ConfigStar);
            Estrela = star.Estrela;
        }

        #endregion Fim [Métodos]
    }
}
