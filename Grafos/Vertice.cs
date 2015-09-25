using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grafos
{
    public class Vertice
    {
        #region [Propriedades]

        /// <summary>
        /// Id do Vértice
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Rótulo do Vértice
        /// </summary>
        public string Rotulo { get; set; }

        /// <summary>
        /// Retorna os arcos ligados ao vértice
        /// </summary>
        public List<Arco> listaArcos { get; set; }

        /// <summary>
        /// Posição X do Vértice
        /// </summary>
        public double PosX { get; set; }

        /// <summary>
        /// Posição Y do Vértice
        /// </summary>
        public double PosY { get; set; }

        /// <summary>
        /// Indica se o vértice foi visitado ou não
        /// </summary>
        public bool Visitado { get; set; }

        #endregion Fim [Propriedades]

        #region [Construtores]

        /// <summary>
        /// Construtor Principal
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pRotulo"></param>
        public Vertice(double pPosX, double pPosY, int pId, string pRotulo)
        {
            this.PosX = pPosX;
            this.PosY = pPosY;
            this.Id = pId;
            this.Rotulo = pRotulo;
            listaArcos = new List<Arco>();
        }

        #endregion Fim [Construtores]

        #region [Métodos]

        /// <summary>
        /// Adiciona o arco à lista de arcos
        /// </summary>
        /// <param name="pArco"></param>
        public void AdicionarArco(Arco pArco)
        {
            listaArcos.Add(pArco);
        }

        #endregion Fim [Métodos]

    }
}
