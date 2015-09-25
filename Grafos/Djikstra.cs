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
        private static int iNumVertices = 0;
        private double[,] matrizAdjacencia = null;

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

        #endregion Fim [Propriedades]

        public Djikstra(List<Vertice> pListaVertices)
        {
            this.listaVertices = pListaVertices;
            iNumVertices = pListaVertices.Count;
            matrizAdjacencia = new double[iNumVertices,iNumVertices];
            this.MontarMatrizAdjacencia();
        }

        private void MontarMatrizAdjacencia()
        {
            int iIndiceLinha = 0;
            int iIndiceColuna = 0;
            foreach (Vertice v in listaVertices.OrderBy(item => item.Rotulo))
            {
                foreach (Arco arcos in v.listaArcos.AsEnumerable().Where(item => item.Destino.Id != v.Id))
                {
                    iIndiceLinha = arcos.Origem.Id;
                    iIndiceColuna = arcos.Destino.Id;
                    matrizAdjacencia[iIndiceLinha,iIndiceColuna] = arcos.Peso;
                }
            }
        }
    }
}
