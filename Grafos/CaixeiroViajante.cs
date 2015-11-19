using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class CaixeiroViajante
    {
        #region [Atributos]

        private DataTable dtbAdjacencia = new DataTable();

        private DataTable dtbDuplicada = new DataTable();

        private List<Vertice> listaTestes = new List<Vertice>();

        private List<Vertice> listaAnalise = new List<Vertice>();

        private Vertice vAnalise1 = null;

        private Vertice vAnalise2 = null;

        private Vertice vInicial = null;

        private int iIdFindColuna = -1;

        private int iIdFindLinha = -1;

        private bool bTodosVisitados = false;

        private int iContadorLacos = 0;

        private double nMenorValor = 100000;

        private bool bOrientado = false;

        private int iIndiceInserir = 0;

        #endregion Fim [Atributos]

        #region [Propriedades]

        public List<Vertice> Vertices { get; set; }

        public DataTable TabelaAdjacencia
        {
            get { return dtbAdjacencia; }
        }

        /// <summary>
        /// Retorna o caminho final do grafo
        /// </summary>
        public string CaminhoFinal
        {
            get
            {
                string sRetorno = "";
                foreach (Vertice v in listaAnalise)
                {
                    sRetorno += v.Rotulo + "->";
                }

                sRetorno = sRetorno.Remove(sRetorno.Trim().Length - 2);

                return sRetorno;
            }
        }

        #endregion Fim [Propriedades]

        #region [Construtores]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="pListaVertices"></param>
        public CaixeiroViajante(List<Vertice> pListaVertices, bool pOrientado)
        {
            Vertices = pListaVertices;
            bOrientado = pOrientado;
            MontarTabelaAdjacencia();
            PreencherTabelaAdjacencia();
        }

        #endregion Fim [Construtores]

        #region [Métodos]

        private void PreencherTabelaAdjacencia()
        {
            int iIndiceLinha = 0;
            int iIndiceColuna = 0;

            if (!bOrientado)
            {
                List<Arco> listaAuxiliarArcos = new List<Arco>();
                foreach (Vertice v in Vertices.OrderBy(item => item.Rotulo))
                {
                    listaAuxiliarArcos.Clear();
                    foreach (Arco arcos in v.listaArcos.AsEnumerable().Where(item => item.Destino.Id != v.Id).OrderBy(item => item.Destino.Rotulo))
                    {
                        if (listaAuxiliarArcos.AsEnumerable().Where(item => item.Destino.Id.Equals(v.Id) && item.Origem.Id.Equals(arcos.Destino.Id)).Count() == 0)
                            listaAuxiliarArcos.Add(new Arco(arcos.Destino, v, arcos.Peso));
                    }

                    foreach (Arco arcos in v.listaArcos.AsEnumerable().Where(item => item.Origem.Id != v.Id).OrderBy(item => item.Origem.Rotulo))
                    {
                        if (listaAuxiliarArcos.AsEnumerable().Where(item => item.Destino.Id.Equals(v.Id) && item.Origem.Id.Equals(arcos.Destino.Id)).Count() == 0)
                            listaAuxiliarArcos.Add(new Arco(arcos.Origem, v, arcos.Peso));
                    }

                    foreach (Arco nArco in listaAuxiliarArcos)
                    {
                        v.listaArcos.Add(nArco);
                    }
                }

                //Percorre novamente a lista e atribui valores a tabela de adjacência
                foreach (Vertice v in Vertices.OrderBy(item => item.Rotulo))
                {
                    foreach (Arco arcos in v.listaArcos)
                    {
                        iIndiceLinha = arcos.Origem.Id;
                        iIndiceColuna = arcos.Destino.Id;
                        dtbAdjacencia.Rows[iIndiceLinha][iIndiceColuna] = arcos.Peso;
                        dtbAdjacencia.Rows[iIndiceColuna][iIndiceLinha] = arcos.Peso;
                    }
                }

            }
            else
            {

                foreach (Vertice v in Vertices.OrderBy(item => item.Rotulo))
                {
                    foreach (Arco arcos in v.listaArcos.AsEnumerable().Where(item => item.Destino.Id != v.Id).OrderBy(item => item.Destino.Rotulo))
                    {
                        iIndiceLinha = arcos.Origem.Id;
                        iIndiceColuna = arcos.Destino.Id;
                        dtbAdjacencia.Rows[iIndiceLinha][iIndiceColuna] = arcos.Peso;
                        //dtbAdjacencia.Rows[iIndiceColuna][iIndiceLinha] = arcos.Peso;
                    }
                }
            }

            dtbDuplicada = dtbAdjacencia.Copy();
            DuplicarValores();
            EncontrarMenorValor();
        }

        private void MontarTabelaAdjacencia()
        {
            DataRow drwNovaLinha = null;
            DataColumn dcNovaColuna = null;

            foreach (Vertice v in Vertices.OrderBy(item => item.Rotulo))
            {
                drwNovaLinha = dtbAdjacencia.NewRow();
                dcNovaColuna = new DataColumn(v.Rotulo, typeof(double));

                dtbAdjacencia.Rows.Add(drwNovaLinha);
                dtbAdjacencia.Columns.Add(dcNovaColuna);
            }    
        }

        private void DuplicarValores()
        {
            for (int i = 0; i < dtbAdjacencia.Rows.Count; i++)
            {
                for (int j = 0; j < dtbAdjacencia.Columns.Count; j++)
                {
                    dtbDuplicada.Rows[i][j] = 0;
                }
            
            }

            int contador = 0;
            for (int i = 0; i < dtbAdjacencia.Rows.Count; i++)
            {
                for (int j = contador; j < dtbAdjacencia.Columns.Count; j++)
                {
                    if (dtbAdjacencia.Rows[i][j] != DBNull.Value)
                        dtbDuplicada.Rows[i][j] = Convert.ToDouble(dtbAdjacencia.Rows[i][j]) + Convert.ToDouble(dtbAdjacencia.Rows[j][i]);
                }
                contador++;
            }
        }

        private void EncontrarMenorValor()
        {
            int iLinhaMenorValor = 0;
            int iColunaMenorValor = 0;

            for (int i = 0; i < dtbDuplicada.Rows.Count; i++)
            {
                for (int j = 0; j < dtbDuplicada.Columns.Count; j++)
                {
                    if (dtbDuplicada.Rows[i][j] != DBNull.Value)
                    {
                        if (Convert.ToDouble(dtbDuplicada.Rows[i][j]) > 0)
                        {
                            if (Convert.ToDouble(dtbDuplicada.Rows[i][j]) < nMenorValor)
                            {
                                nMenorValor = Convert.ToDouble(dtbDuplicada.Rows[i][j]);
                                iLinhaMenorValor = i;
                                iColunaMenorValor = j;
                            }
                        }
                    }
                }
            }

            string sLinhaMenorValor = Vertices.AsEnumerable().Where(item => item.Id.Equals(iLinhaMenorValor)).FirstOrDefault().Rotulo;
            string sColunaMenorValor = Vertices.AsEnumerable().Where(item => item.Id.Equals(iColunaMenorValor)).FirstOrDefault().Rotulo;
            iIdFindColuna = iColunaMenorValor;
            iIdFindLinha = iLinhaMenorValor;

            vAnalise1 = Vertices.AsEnumerable().Where(item => item.Id.Equals(iLinhaMenorValor)).FirstOrDefault();
            vAnalise2 = Vertices.AsEnumerable().Where(item => item.Id.Equals(iColunaMenorValor)).FirstOrDefault();
            vInicial = vAnalise1;

            Vertice novoVertice = new Vertice(0, 0, vAnalise1.Id, vAnalise1.Rotulo);
            novoVertice.ValorCaixeiro = vAnalise1.ValorCaixeiro;

            listaAnalise.Add(Vertices.AsEnumerable().Where(item => item.Id.Equals(iIdFindLinha)).FirstOrDefault());//Adiciona o destino
            listaAnalise.Add(Vertices.AsEnumerable().Where(item => item.Id.Equals(iIdFindColuna)).FirstOrDefault());//Adiciona o primeiro
            listaAnalise.Add(novoVertice);//Adiciona o destino

            ReordenarIndices();

            vAnalise1.Visitado = true;

            DefinirValoresPeso(iIdFindLinha, iIdFindColuna);

            PreencherListaTestes(sLinhaMenorValor, sColunaMenorValor);

            AplicarTestes();
        }

        private void PreencherListaTestes(string sLinhaMenorValor, string sColunaMenorValor)
        {
            listaTestes.Clear();
            foreach (Vertice v in Vertices)
            {
                if (!v.Rotulo.Equals(sLinhaMenorValor) && !v.Rotulo.Equals(sColunaMenorValor))
                    listaTestes.Add(v);
            }
        }

        private void AplicarTestes()
        {
            double nMenorCaminho1 = 100000;
            double nMenorCaminho2 = 100000;
            double nCustoTotal = 100000;
            Vertice vRemover = null;
            

            while (listaTestes.Count > 0)
            {
                foreach (Vertice v in listaTestes.OrderBy(item => item.Rotulo))
                {
                    nMenorCaminho1 = 100000;
                    nMenorCaminho2 = 100000;
                    //nCustoTotal = 100000;
                    foreach (Arco arcos in v.listaArcos.AsEnumerable().Where(item => item.Origem.Id == vAnalise1.Id).OrderBy(item => item.Destino.Rotulo))
                    {
                        if (arcos.Peso < nMenorCaminho1)
                            nMenorCaminho1 = arcos.Peso;
                    }

                    foreach (Arco arcos in v.listaArcos.AsEnumerable().Where(item => item.Destino.Id == vAnalise2.Id).OrderBy(item => item.Destino.Rotulo))
                    {
                        if (arcos.Peso < nMenorCaminho2)
                            nMenorCaminho2 = arcos.Peso;

                    }

                    if ((nMenorCaminho1 + nMenorCaminho2 - vAnalise1.ValorCaixeiro) < nCustoTotal)
                    {
                        nCustoTotal = (nMenorCaminho1 + nMenorCaminho2 - vAnalise1.ValorCaixeiro);
                        vRemover = v;
                        iIndiceInserir = vAnalise1.IndiceCaixeiro;
                    }
                }

                iContadorLacos++;
                if (bOrientado || iContadorLacos > 1)
                    BuscarProximosIndices();
                else
                    bTodosVisitados = true;

                    if (bTodosVisitados)
                    {
                        if (vRemover != null)
                        {
                            DefinirPesoNovoVertice(vRemover);
                            listaTestes.Remove(vRemover);
                            OrdenarGrafo(vRemover);
                            nCustoTotal = 100000;

                        }

                        BuscarProximosIndices();
                    }
                
            }
        }

        private void DefinirPesoNovoVertice(Vertice pNovoVertice)
        {
            pNovoVertice.ValorCaixeiro = Convert.ToDouble(dtbAdjacencia.Rows[vAnalise1.Id][pNovoVertice.Id]);
            vAnalise2.ValorCaixeiro = Convert.ToDouble(dtbAdjacencia.Rows[pNovoVertice.Id][vAnalise2.Id]);
        }

        private void BuscarProximosIndices()
        {
            int iNumVertices = 0;
            Vertice vAuxiliar = null;
            iContadorLacos++;

            if (listaAnalise.AsEnumerable().Where(item => !item.Visitado).Count() > 0)
            {
                foreach (Vertice v in listaAnalise)
                {
                    if (!v.Visitado && iNumVertices == 0)
                    {
                        vAuxiliar = vAnalise1;
                        vAnalise1 = v;
                        v.Visitado = true;
                        iNumVertices++;
                    }
                    if (iNumVertices == 1 && !v.Visitado)
                    {
                        vAnalise2 = v;
                        iNumVertices++;
                    }

                    if (iNumVertices == 2)
                    {
                        bTodosVisitados = false;
                        DefinirValoresPeso(vAnalise1.Id, vAnalise2.Id);
                        break;
                    }
                }

                if(iNumVertices == 1)
                {
                    if (listaAnalise.AsEnumerable().Where(item => !item.Visitado).Count() == 0)
                    {
                        bTodosVisitados = true;
                        vAnalise1 = vAuxiliar;
                    }
                }
            }
            else
                bTodosVisitados = true;
        }

        private void DefinirValoresPeso(int pIdLinha, int pIdColuna)
        {
            vAnalise1.ValorCaixeiro = Convert.ToDouble( dtbAdjacencia.Rows[pIdLinha][pIdColuna]);
            vAnalise2.ValorCaixeiro = Convert.ToDouble( dtbAdjacencia.Rows[pIdColuna][pIdLinha]);
        }


        private void OrdenarGrafo(Vertice pVerticeInserir)
        {
            //listaAnalise.Insert(vAnalise1.IndiceCaixeiro + 1, pVerticeInserir);
            listaAnalise.Insert(iIndiceInserir + 1, pVerticeInserir);
            ReordenarIndices();
        }

        /// <summary>
        /// Reordena os indices do caixeiro e desmarca a propriedade visitado de todos os vértices
        /// </summary>
        private void ReordenarIndices()
        {
            int iIndice = 0;

            foreach (Vertice v in listaAnalise)
            {
                v.IndiceCaixeiro = iIndice++;
                v.ValorCaixeiro = 0;
                v.Visitado = false;
            }
        }
        
        #endregion Fim [Métodos]


    }
}

