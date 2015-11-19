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
        private List<Dictionary<string, string>> listaPosicoes = new List<Dictionary<string, string>>();
        private Dictionary<int, int> posicoesVisitadas = new Dictionary<int, int>();
        private static int iCont = 0;
        private int iIndice = 0;
        private string sVerticeInicial = "";
        private string sVerticeBusca = "";
        private int iIndiceBusca = 0;
        private int iValorCaminho = 0;
        private string sCaminho = "";
        private int iIndiceInicial = 0;
        private Stack<string> caminhoInverso = new Stack<string>();

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

        /// <summary>
        /// Vértice inicial de busca
        /// </summary>
        public string VerticeInicial
        {
            get { return sVerticeInicial; }
            set { sVerticeInicial = value; }
        }

        /// <summary>
        /// Vértice de busca
        /// </summary>
        public string VerticeBusca
        {
            get { return sVerticeBusca; }
            set { sVerticeInicial = value; }
        }

        public string CaminhoGrafo
        {
            get
            {
                while(caminhoInverso.Count > 0)
                {
                    sCaminho += caminhoInverso.Pop();
                }
                return sCaminho + sVerticeBusca;
            }
        }

        #endregion Fim [Propriedades]

        public Djikstra(List<Vertice> pListaVertices, string pVerticeInicial, string pVerticeBusca)
        {
            this.listaVertices = pListaVertices;
            iNumVertices = pListaVertices.Count;
            sVerticeInicial = pVerticeInicial;
            sVerticeBusca = pVerticeBusca;
            matrizAdjacencia = new double[iNumVertices, iNumVertices];
            tabelaFinal = new string[2, iNumVertices];
            iIndiceInicial = listaVertices.AsEnumerable().Where(item => item.Rotulo.Equals(sVerticeInicial)).FirstOrDefault().Id;
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
                    matrizAdjacencia[iIndiceLinha, iIndiceColuna] = arcos.Peso;
                }
            }
            iIndice = BuscarIndicePorRotulo(sVerticeInicial);
            this.ConfigurarTabelaFinal();
            MontarTabelaFinal();
            iIndiceBusca = listaVertices.AsEnumerable().Where(item => item.Rotulo.Equals(sVerticeBusca)).FirstOrDefault().Id;
            if (iIndiceBusca != iIndiceInicial)
                MontarCaminho();
        }


        private void MontarTabelaFinal()
        {
            if (iCont == 0)
            {
                tabelaFinal[0, iIndice] = "0";
                tabelaFinal[1, iIndice] = sVerticeInicial;
                iCont++;
                //posicoesVisitadas.Add(iIndice, iIndice);
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
                                if (!tabelaFinal[1, j].ToString().Equals(sVerticeInicial))
                                {
                                    tabelaFinal[0, j] = (Convert.ToDouble(tabelaFinal[0,i]) + matrizAdjacencia[i, j]).ToString();
                                    tabelaFinal[1, j] = BuscarRotuloPorId(i);
                                }
                            }
                            else if ((Convert.ToDouble(tabelaFinal[0, i]) + matrizAdjacencia[i, j]) < Convert.ToDouble(tabelaFinal[0, j]))
                            {
                                tabelaFinal[0, j] = (Convert.ToDouble(tabelaFinal[0, i]) + matrizAdjacencia[i, j]).ToString();
                                tabelaFinal[1, j] = BuscarRotuloPorId(i);
                            }
                        }
                    }
                }

                MarcarVisitado(iIndice);
            }

            if (VerificarExistemItensNaoVisitados())
            {
                iIndice = BuscarProximoIndice();
                MontarTabelaFinal();
            }

        }

        /// <summary>
        /// Retorna o indice da coluna de acordo com id do vértice
        /// </summary>
        /// <param name="pIndice"></param>
        /// <returns></returns>
        private int BuscarIndiceColuna(int pIndice)
        {
            listaVerticesOrdenada = listaVertices;
            return listaVerticesOrdenada.IndexOf(listaVerticesOrdenada.OrderBy(item => item.Rotulo).Where(item => item.Id.Equals(pIndice)).FirstOrDefault());
        }

        /// <summary>
        /// Retorna o rótulo do vértice de acordo com o id passado por parâmetro
        /// </summary>
        /// <param name="pIndice"></param>
        /// <returns></returns>
        private string BuscarRotuloPorId(int pIndice)
        {
            return listaVertices.AsEnumerable().Where(item => item.Id.Equals(pIndice)).FirstOrDefault().Rotulo.ToString();
        }

        /// <summary>
        /// Retorna o indice do rótulo buscado
        /// </summary>
        /// <param name="pRotulo"></param>
        /// <returns></returns>
        private int BuscarIndicePorRotulo(string pRotulo)
        {
            return listaVertices.AsEnumerable().Where(item => item.Rotulo.Equals(pRotulo)).FirstOrDefault().Id;
        }

        /// <summary>
        /// Método necessário para iniciar a tabela com final com valores zerados para evitar erros ao realizar conversão de valores
        /// </summary>
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

        /// <summary>
        /// Verifica qual o menor caminho encontrado na análise do vértice e retorna qual deve ser o próximo vértice a ser visitado
        /// </summary>
        /// <returns></returns>
        private int BuscarProximoIndice()
        {
            double iNumRetorno = 100000;
            int iIndiceRetorno = 0;
            for (int i = 0; i < tabelaFinal.GetLength(1); i++)
            {
                if (tabelaFinal[0, i] != null)
                {
                    if (Convert.ToDouble(tabelaFinal[0, i]) > 0)
                    {
                        if (!VerificarSeItemVisitado(i))
                        {
                            if (Convert.ToDouble(tabelaFinal[0, i]) < iNumRetorno)
                            {
                                iNumRetorno = Convert.ToDouble(tabelaFinal[0, i]);
                                iIndiceRetorno = i;
                            }
                        }
                    }
                }
            }
            return iIndiceRetorno;
        }
            

        /// <summary>
        /// Verifica se a lista de vértices possui algum vértice que ainda não foi visitado
        /// </summary>
        /// <returns></returns>
        private bool VerificarExistemItensNaoVisitados()
        {
            return listaVertices.AsEnumerable().Where(item => !item.Visitado).Count() > 0;
        }

        /// <summary>
        /// Marca o vertice que foi analisado como visitado
        /// </summary>
        /// <param name="pIndice"></param>
        private void MarcarVisitado(int pIndice)
        {
            listaVertices.AsEnumerable().ToList().ForEach(item =>
            {
                if (item.Id == pIndice)
                    item.Visitado = true;
            });
        }

        private bool VerificarSeItemVisitado(int pIndice)
        {
            return listaVertices.AsEnumerable().Where(item => item.Id == pIndice).FirstOrDefault().Visitado;
        }


        private void MontarCaminho()
        {
            iValorCaminho = Convert.ToInt32(tabelaFinal[0, iIndiceBusca]);
            caminhoInverso.Push(tabelaFinal[1, iIndiceBusca] + "  ");
            iIndiceBusca = listaVertices.AsEnumerable().Where(item => item.Rotulo.Equals(tabelaFinal[1, iIndiceBusca])).FirstOrDefault().Id;
            if (iIndiceBusca != iIndiceInicial)
                MontarCaminho();
        }
    }
}
