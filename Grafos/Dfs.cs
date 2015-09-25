using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Dfs
    {
        #region [Atributos]

        /// <summary>
        /// Pilha usada para Dfs
        /// </summary>
        private Queue fila = new Queue();

        private Stack pilhaAuxiliar = new Stack();

        private int iContadorVertices = 0;

        private string sGrafo = "";

        private Vertice raiz;

        /// <summary>
        /// Lista de vértices
        /// </summary>
        List<Vertice> listaVertices;

        bool bEhConexo = true;

        bool bContinuarLaco = true;

        bool bVerificarConectividade = true;

        /// <summary>
        /// Retorna se o grafo é conexo
        /// </summary>
        public bool Conexo
        {
            get { return bEhConexo; }
            set { value = bEhConexo; }
        }


        #endregion Fim [Atributos]


        #region [Construtores]
        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Dfs(List<Vertice> pVertices)
        {
            listaVertices = pVertices;
            OrganizarPilha();
        }

        #endregion Fim [Construtores]

        public void AplicarDfs()
        {
            Vertice verticeInicial;

            // verticeInicial = (Vertice) pilhaAuxiliar.Pop();
            // verticeInicial.Visitado = true;
            while (pilhaAuxiliar.Count > 0)
            {
                Vertice node = (Vertice)pilhaAuxiliar.Peek();

                if (!node.Visitado)
                {
                    sGrafo += node.Rotulo + " ";
                    fila.Enqueue(node);
                }

                if (node != null)
                {
                    node.Visitado = true;
                    verticeInicial = ProximoVertice(node);
                    if (verticeInicial != null)
                    {
                        if (!verticeInicial.Visitado)
                            pilhaAuxiliar.Push(verticeInicial);
                    }
                    else
                    {
                        if(listaVertices.AsEnumerable().Where(item => !item.Visitado).Count() > 0)
                        {
                            bEhConexo = false;
                            bVerificarConectividade = false;
                        }
                        pilhaAuxiliar.Pop();
                    }
                }
            }

            if (bVerificarConectividade)
            {
                foreach (Vertice v in fila)
                {
                    VerificarConectividade(v, 0);
                    if (!bEhConexo)
                        break;
                }
            }

        }


        /// <summary>
        /// Retorna o vértice inicial
        /// </summary>
        /// <returns></returns>
        private Vertice BuscarVerticeInicial()
        {
            return (Vertice)pilhaAuxiliar.Peek();
        }

        private void OrganizarPilha()
        {
            Vertice verticeBusca;
            bool bContinuaBusca = true;
            while (bContinuaBusca)
            {
                verticeBusca = listaVertices.Find(item => item.Id == iContadorVertices);
                if (verticeBusca != null)
                {
                    foreach (Arco arcos in verticeBusca.listaArcos.Where(item => item.Destino.Id != verticeBusca.Id))
                    {
                        if (arcos.Destino != null)
                        {
                            iContadorVertices++;
                            bContinuaBusca = false;
                            OrganizarPilha();
                            pilhaAuxiliar.Push(verticeBusca);
                        }
                        else
                            break;
                    }
                    if (verticeBusca.listaArcos.Where(item => item.Destino.Id != verticeBusca.Id).Count() == 0)
                        pilhaAuxiliar.Push(verticeBusca);
                }
                break;
            }
        }

        private Vertice ProximoVertice(Vertice pVertice)
        {
            Vertice verticeRetorno = null;
            foreach (Arco arcos in pVertice.listaArcos.Where(item => item.Destino.Id != pVertice.Id && !item.Destino.Visitado))
            {
                verticeRetorno = arcos.Destino;
                break;
            }

            return verticeRetorno;
        }

        public string GetGrafo()
        {
            return sGrafo;
        }

        private void VerificarConectividade(Vertice pVertice, int pContador)
        {
            raiz = pVertice;
            bool bProxVertice = false;
            Vertice novoVertice = null;
            while (pVertice != null)
            {
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

                if (pContador > fila.Count)
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
        
        }

        public void Limpar()
        {
            sGrafo = "";
            foreach (Vertice vertice in listaVertices)
            {
                vertice.Visitado = false;
            }
        }
    }
}
            
        


