using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Conectividade
    {
        #region [Atributos]

        private List<Vertice> listaVertices;

        #endregion Fim [Atributos]

        public Conectividade(List<Vertice> pVertices)
        {
            listaVertices = pVertices;
        }

        public bool VerificarGrafoConexo()
        {
            bool bEhConexo = true;
            Stack pilha = new Stack();
            while (bEhConexo)
            {
                foreach (Vertice vertice in listaVertices.Where(item => item.Id != 0))
                {
                    foreach (Arco arcos in vertice.listaArcos.Where(item => item.Destino.Id != vertice.Id && !item.Destino.Visitado))
                    {
                        pilha.Push(arcos.Destino);
                    }
                }
            }


            return true;
        }
    }
}
