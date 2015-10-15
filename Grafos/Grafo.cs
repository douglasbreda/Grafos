using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Grafo
    {
        #region [Propriedades]

        /// <summary>
        /// Lista com os vértices do grafo
        /// </summary>
        public List<Vertice> Vertices { get; set; }

        /// <summary>
        /// Lista com os arcos do grafo
        /// </summary>
        public List<Arco> Arcos { get; set; }

        /// <summary>
        /// Define se um grafo é orientado
        /// </summary>
        public bool Orientado { get; set; }

        #endregion Fim [Propriedades]

        #region [Atributos]

        private Vertice novoVertice;

        private Arco novoArco;

        #endregion Fim [Atributos]

        #region [Construtores]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Grafo()
        {
            Vertices = new List<Vertice>();
            Arcos = new List<Arco>();
        }

        #endregion Fim [Construtores]

        #region [Métodos]

        /// <summary>
        /// Adiciona um novo arco
        /// </summary>
        /// <param name="pIdOrigem"></param>
        /// <param name="pIdDestino"></param>
        /// <param name="pPeso"></param>
        public void AdicionarArco(int pIdOrigem, int pIdDestino, double pPeso)
        {
            Vertice Origem;
            Vertice Destino;

            Origem = Vertices.Find(item => item.Id == pIdOrigem);
            Destino = Vertices.Find(item => item.Id == pIdDestino);

            novoArco = new Arco(Origem, Destino, pPeso);
            Arcos.Add(novoArco);
        }

        public void AdicionarVertice(int pId, string pRotulo, float pPosX, float pPosY)
        {
            novoVertice = new Vertice(pPosX, pPosY, pId, pRotulo);
            Vertices.Add(novoVertice);
        }

        #endregion Fim [Métodos]
    }
}
