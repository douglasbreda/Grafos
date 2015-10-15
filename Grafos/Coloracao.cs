using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Coloracao
    {
        #region [Atributos]

        private double[,] matrizAdjacencia = null;
        private List<Vertice> listaVertices = new List<Vertice>();
        private Queue<Vertice> fila = new Queue<Vertice>();
        private List<int> vetorCores = new List<int>();
        private int iContadorCores = 1;
        private bool bGrafoDirigido = false;

        #endregion Fim [Atributos]

        #region [Propriedades]

        public double[,] MatrizAdjacencia
        {
            get { return matrizAdjacencia; }
            set { matrizAdjacencia = value; }
        }

        public List<int> Cores
        {
            get { return vetorCores; }
        }


        #endregion Fim [Propriedades]

        #region [Construtores]

        public Coloracao(List<Vertice> pListaVertices, bool pDirigido)
        {
            listaVertices = pListaVertices;
            MontarMatrizAdjacencia();
            bGrafoDirigido = pDirigido;
            IniciarColoracao();
        }

        #endregion Fim [Construtores]

        #region [Métodos]

        private void MontarMatrizAdjacencia()
        {
            int iIndiceLinha = 0;
            int iIndiceColuna = 0;

            matrizAdjacencia = new double[listaVertices.Count, listaVertices.Count];

            foreach (Vertice v in listaVertices.OrderBy(item => item.Rotulo))
            {
                foreach (Arco arcos in v.listaArcos.AsEnumerable().Where(item => item.Destino.Id != v.Id))
                {
                    iIndiceLinha = arcos.Origem.Id;
                    iIndiceColuna = arcos.Destino.Id;
                    matrizAdjacencia[iIndiceLinha, iIndiceColuna] = arcos.Peso;
                }
            }
        }

        /// <summary>
        /// Inicia o processo de coloração
        /// </summary>
        private void IniciarColoracao()
        {
            Vertice vMaiorGrau = listaVertices.Where(item => item.Id == BuscarVerticeMaiorGrau()).FirstOrDefault();
            ColorirVertice(vMaiorGrau);
            fila.Enqueue(vMaiorGrau);
            while(fila.Count > 0)
            {
                Vertice v = fila.Dequeue();
                foreach (Vertice vert in v.Adjacentes)
                {
                    if (vert.CorVertice == 0)
                    {
                        ColorirVertice(vert);
                        fila.Enqueue(vert);
                    }
                }
            }
        }

        private int BuscarVerticeMaiorGrau()
        {
            int iArcos = 0;
            int idVertice = 0;
            foreach (Vertice v in listaVertices.OrderByDescending(item => item.Rotulo))
            {
                if(v.Grau >= iArcos)
                {
                    iArcos = v.Grau;
                    idVertice = v.Id;
                }
            }

            return idVertice;
        }

        private void ColorirVertice(Vertice pVertice)
        {
            if(pVertice.CorVertice == 0)
            {
                int iCor = BuscarCorApropriada(pVertice);
                if (iCor == 0)
                {
                    vetorCores.Add(iContadorCores);
                    pVertice.CorVertice = iContadorCores;
                    iContadorCores++;
                }
                else
                {
                    pVertice.CorVertice = iCor;
                }
            }
        }

        private int BuscarCorApropriada(Vertice pVertice)
        {
            int iCor = 0;
            List<int> listaExcecao = new List<int>();
            List<int> listaFinal = new List<int>();
            foreach (Vertice grau in pVertice.Adjacentes)
            {
                if(grau.CorVertice > 0)
                    listaExcecao.Add(grau.CorVertice);
            }

            if (listaExcecao.Count > 0)
            {
                for (int i = 0; i < vetorCores.Count; i++)
                {

                    if (!listaExcecao.Contains(vetorCores[i]))
                        listaFinal.Add(vetorCores[i]);
                }
            }
            

            if (listaFinal.Count > 0)
                iCor = listaFinal[0];

            return iCor;
        }

        #endregion Fim [Métodos]

    }
}
