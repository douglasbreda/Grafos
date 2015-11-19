using System;
using System.Collections.Generic;
using System.Drawing;
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
        public float PosX { get; set; }

        /// <summary>
        /// Posição Y do Vértice
        /// </summary>
        public float PosY { get; set; }

        /// <summary>
        /// Indica se o vértice foi visitado ou não
        /// </summary>
        public bool Visitado { get; set; }

        public int CorVertice { get; set; }

        /// <summary>
        /// Retorna qual é o grau do vertice
        /// </summary>
        public int Grau
        {
            get { return listaArcos.Where(item => item.Origem.Id == Id).Count(); }
        }

        /// <summary>
        /// Retorna a lista com os vértice que são adjacentes ao vértice atual
        /// </summary>
        public List<Vertice> Adjacentes
        {
            get
            {
                List<Vertice> listaRetorno = new List<Vertice>();
                listaArcos.Where(item => item.Origem.Id == Id ).ToList().ForEach(item =>
                {
                    listaRetorno.Add(item.Destino);

                });

                listaArcos.Where(item => item.Destino.Id == Id).ToList().ForEach(item =>
                {
                    listaRetorno.Add(item.Origem);
                });
                return listaRetorno;
            }
        }

        /// <summary>
        /// Define o valor do peso atual a ser usado no cálculo do caixeiro viajante
        /// </summary>
        public double ValorCaixeiro { get; set; }


        /// <summary>
        /// Indice para inserir os vértices na ordem
        /// </summary>
        public int IndiceCaixeiro { get; set; }

        #endregion Fim [Propriedades]

        #region [Construtores]

        /// <summary>
        /// Construtor Principal
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pRotulo"></param>
        public Vertice(float pPosX, float pPosY, int pId, string pRotulo)
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
