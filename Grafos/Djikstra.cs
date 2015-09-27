using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Djikstra
    {

        #region [Atributos]

        private List<Vertice> listaVertices = new List<Vertice>();
        private List<Vertice> listaVerticesOrdenada = new List<Vertice>();
        private static int iNumVertices = 0;
        private double[,] matrizAdjacencia = null;
        private string[,] tabelaFinal = null;
        List<Dictionary<string, string>> listaPosicoes = new List<Dictionary<string, string>>();
        string pInicio = "A";
        string pFim = "G";
        Dictionary<int, int> posicoesVisitadas = new Dictionary<int, int>();
        static int iCont = 0;

        #endregion Fim [Atributos]

        #region [Propriedades]

        /// <summary>
        /// Matriz Adjacente
        /// </summary>
        public double[,] MatrizAdjacencia
        {
            get { return matrizAdjacencia; }
            set { matrizAdjacencia = value; }
        }

        /// <summary>
        /// Tabela final de djikstra
        /// </summary>
        public string[,] TabelaFinal
        {
            get { return tabelaFinal; }
            set { tabelaFinal = value; }
        }

        #endregion Fim [Propriedades]

        public Djikstra(List<Vertice> pListaVertices)
        {
            this.listaVertices = pListaVertices;
            iNumVertices = pListaVertices.Count;
            matrizAdjacencia = new double[iNumVertices,iNumVertices];
            tabelaFinal = new string[2, iNumVertices];
            this.MontarMatrizAdjacencia();
        }

        private void MontarMatrizAdjacencia()
        {
            int iIndiceLinha = 0;
            int iIndiceColuna = 0;
            Dictionary<string, string> dicionario = null;
            foreach (Vertice v in listaVertices.OrderBy(item => item.Rotulo))
            {
                foreach (Arco arcos in v.listaArcos.AsEnumerable().Where(item => item.Destino.Id != v.Id))
                {
                    iIndiceLinha = arcos.Origem.Id;
                    iIndiceColuna = arcos.Destino.Id;
                    matrizAdjacencia[iIndiceLinha,iIndiceColuna] = arcos.Peso;
                }
            }
            iIndice = BuscarIndicePorRotulo(pInicio);
            this.ConfigurarTabelaFinal();
            MontarTabelaFinal();
        }

        int iIndice = 0;
        string pProximoRotulo = "";
        private void MontarTabelaFinal()
        {
            if (iCont == 0)
            {
                tabelaFinal[0, iIndice] = "0";
                tabelaFinal[1, iIndice] = pInicio;
                iCont++;
                posicoesVisitadas.Add(iIndice, iIndice);
                MontarTabelaFinal();
            }
            else
            {
                for (int i = iIndice; i == iIndice; i++)
                {
                    for (int j = 0; j < matrizAdjacencia.GetLength(1); j++)
                    {
                        if (Convert.ToDouble(matrizAdjacencia[i, j]) > 0)
                        {
                            if (Convert.ToDouble(tabelaFinal[0, j]) == 0)
                            {
                                if (!tabelaFinal[1, j].ToString().Equals(pInicio))
                                {
                                    tabelaFinal[0, j] = matrizAdjacencia[i, j].ToString();
                                    tabelaFinal[1, j] = BuscarRotuloPorId(i);
                                }
                            }
                            else if (matrizAdjacencia[i, j] < Convert.ToDouble(tabelaFinal[0, i]))
                            {
                                tabelaFinal[0, j] = matrizAdjacencia[i, j].ToString();
                                tabelaFinal[1, j] = BuscarRotuloPorId(i);
                            }
                        }
                    }
                }
            }
        }

        private int BuscarIndiceColuna(int pIndice)
        {
            listaVerticesOrdenada = listaVertices;
            return listaVerticesOrdenada.IndexOf(listaVerticesOrdenada.OrderBy(item => item.Rotulo).Where(item => item.Id.Equals(pIndice)).FirstOrDefault());
        }

        private string BuscarRotuloPorId(int pIndice)
        {
            return listaVertices.AsEnumerable().Where(item => item.Id.Equals(pIndice)).FirstOrDefault().Rotulo.ToString();
        }

        private int BuscarIndicePorRotulo(string pRotulo)
        {
            return listaVertices.AsEnumerable().Where(item => item.Rotulo.Equals(pRotulo)).FirstOrDefault().Id;
        }

        private void ConfigurarTabelaFinal()
        {
            for (int i = 0; i < tabelaFinal.GetLength(0); i++)
            {
                for (int j = 0; j < tabelaFinal.GetLength(1); j++)
                {
                    tabelaFinal[i, j] = "0";
                }
            }
        }
        
    }
}
