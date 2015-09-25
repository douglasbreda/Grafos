using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Bfs
    {
        #region [Atributos]

        private Queue fila = new Queue();

        private Queue filaAuxiliar = new Queue();

        private List<Vertice> listaVertices;

        private int iContadorVertices = 0;

        private string sGrafo = "";

        private bool bEhConexo = true;

        private bool bVerificarConectividade = true;

        public bool Conexo
        {
            get { return bEhConexo; }
            set { value = bEhConexo; }
        }

        private Vertice raiz;

        private bool bContinuarLaco = true;

        #endregion Fim [Atributos]

        #region [Construtores]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="pVertices"></param>
        public Bfs(List<Vertice> pVertices)
        {
            listaVertices = pVertices;
            fila.Enqueue(this.BuscarVerticeInicial());
            OrganizarFila();
        }

        #endregion Fim [Construtores]

        #region [Métodos]

        public void AplicarBfs()
        {
            while (fila.Count > 0)
            {
                Vertice node = (Vertice)fila.Dequeue();
                if (node != null)
                {
                    if (!node.Visitado)
                    {
                        sGrafo += node.Rotulo + " ";
                        filaAuxiliar.Enqueue(node);
                    }
                    node.Visitado = true;
                }
                else
                {
                    if (listaVertices.AsEnumerable().Where(item => !item.Visitado).Count() > 0)
                    {
                        bEhConexo = false;
                        bVerificarConectividade = false;
                    }
                }

            }

            if (bVerificarConectividade)
            {
                foreach (Vertice v in filaAuxiliar)
                {
                    VerificarConectividade(v, 0);
                    if (!bEhConexo)
                        break;
                }
            }
        }

        private void OrganizarFila()
        {
            Vertice verticeBusca;
            bool bContinuaBUsca = true;
            while (bContinuaBUsca)
            {
                verticeBusca = listaVertices.Find(item => item.Id == iContadorVertices);
                if (verticeBusca != null)
                {
                    iContadorVertices++;
                    foreach (Arco arcos in verticeBusca.listaArcos.Where(item => item.Destino.Id != verticeBusca.Id))
                    {
                        if (arcos.Destino != null)
                            fila.Enqueue(arcos.Destino);
                        else
                            break;
                    }
                    OrganizarFila();
                }
                bContinuaBUsca = false;
                break;
            }
        }

        /// <summary>
        /// Retorna o primeiro vértice
        /// </summary>
        /// <returns></returns>
        private Vertice BuscarVerticeInicial()
        {
            return listaVertices.Find(item => item.Id == 0);
        }

        /// <summary>
        /// Retorna o grafo
        /// </summary>
        /// <returns></returns>
        public string GetGrafo()
        {
            return this.sGrafo;
        }

        private void VerificarConectividade(Vertice pVertice, int pContador)
        {
            raiz = pVertice;
            bool bProxVertice = false;
            Vertice novoVertice = null;
            while (pVertice != null)
            {
                if (pVertice.listaArcos.Where(item => item.Destino.Id != pVertice.Id).Count() > 0) {
                    foreach (Arco dest in pVertice.listaArcos.Where(item => item.Destino.Id != pVertice.Id))
                    {
                        pContador++;
                        if (dest.Destino.Id == raiz.Id)
                        {
                            bProxVertice = false;
                            novoVertice = null;
                            pVertice = null;
                            break;
                        }
                        else
                        {
                            bProxVertice = true;
                            novoVertice = dest.Destino;
                        }
                    }

                    if (pContador > filaAuxiliar.Count)
                    {
                        bContinuarLaco = false;
                        pVertice = null;
                        bEhConexo = false;
                    }
                    else if (bProxVertice)
                    {
                        pVertice = novoVertice;
                        bProxVertice = false;
                    }
                }
                else
                {
                    bProxVertice = false;
                    novoVertice = null;
                    pVertice = null;
                    bEhConexo = false;
                    break;

                }
            }

        }

        public void Limpar()
        {
            sGrafo = "";
            foreach (Vertice vertice in listaVertices)
            {
                vertice.Visitado = false;
            }
        }

        #endregion Fim [Métodos]
    }
}
