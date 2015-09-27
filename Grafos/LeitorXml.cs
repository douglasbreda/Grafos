using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Grafos
{
    public class LeitorXml
    {
        #region [Atributos]

        private Grafo grafo;

        public string Retorno;

        public string GrafoDefinicao { get; set; }

        public bool Conexo { get; set; }

        public string CaminhoXml { get; set; }

        #endregion Fim de [Atributos]

        #region [Construtores]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="pDfs"></param>
        public LeitorXml()
        {
            grafo = new Grafo();
        }

        #endregion Fim [Construtores]

        #region [Métodos]

        /// <summary>
        /// Leitor de Xml
        /// </summary>
        /// <returns></returns>
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
                    XmlNodeList nodes = xml.GetElementsByTagName("Vertice");

                    for (int i = 0; i < nodes.Count; i++)
                    {
                        XmlNode node = nodes.Item(i);
                        if (node.NodeType == XmlNodeType.Element)
                        {
                            XmlElement element = (XmlElement)node;
                            int relId = Convert.ToInt32(element.GetAttribute("relId"));
                            String rotulo = element.GetAttribute("rotulo");
                            int posX = Convert.ToInt32(element.GetAttribute("posX"));
                            int posY = Convert.ToInt32(element.GetAttribute("posY"));
                            //Adicione os vértices ao seu grafo aqui, exemplo:
                            grafo.AdicionarVertice(relId, rotulo, posX, posY);
                            Retorno += "ID: " + relId + " Rótulo: " + rotulo + "\n";

                        }
                    }
                    nodes = xml.GetElementsByTagName("Aresta");
                    Console.WriteLine("Arestas");
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        XmlNode node = nodes.Item(i);
                        if (node.NodeType == XmlNodeType.Element)
                        {
                            XmlElement element = (XmlElement)node;
                            int idVertice1 = Convert.ToInt32(element.GetAttribute("idVertice1"));
                            int idVertice2 = Convert.ToInt32(element.GetAttribute("idVertice2"));
                            double peso = Convert.ToDouble(element.GetAttribute("peso").Remove(element.GetAttribute("peso").IndexOf('.')));
                            //Adicione as arestas ao seu grafo aqui, exemplo:
                            grafo.AdicionarArco(idVertice1, idVertice2, peso);
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

        public void ExecutarGrafo(bool pDfs, bool pBfs, bool pDjikstra)
        {
            if (pDfs)
            {
                Dfs dfs = new Dfs(grafo.Vertices);
                dfs.AplicarDfs();
                GrafoDefinicao = dfs.GetGrafo();
                Conexo = dfs.Conexo;
                dfs.Limpar();
            }
            else if (pBfs)
            {
                Bfs bfs = new Bfs(grafo.Vertices);
                bfs.AplicarBfs();
                GrafoDefinicao = bfs.GetGrafo();
                Conexo = bfs.Conexo;
                bfs.Limpar();
            }
            else
            {
                Djikstra dj = new Djikstra(grafo.Vertices);
                for (int i = 0; i < dj.MatrizAdjacencia.GetLength(0); i++)
                {
                    GrafoDefinicao += "\n";
                    for (int j = 0; j < dj.MatrizAdjacencia.GetLength(1); j++)
                    {
                        GrafoDefinicao += dj.MatrizAdjacencia[i, j].ToString() + "   ";
                    }
                }

                GrafoDefinicao += "\n\n";

                for (int i = 0; i < dj.TabelaFinal.GetLength(0); i++)
                {
                    GrafoDefinicao += dj.TabelaFinal[0, i];
                }
                GrafoDefinicao += "\n";
                for (int j = 0; j < dj.TabelaFinal.GetLength(1); j++)
                {
                    GrafoDefinicao += dj.TabelaFinal[1, j];
                }

            }

        }

        #endregion Fim [Métodos]
    }
}



