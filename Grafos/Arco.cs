using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Arco
    {

        #region [Propriedades]
        /// <summary>
        /// Vértice de origem
        /// </summary>
        public Vertice Origem { get; set; }

        /// <summary>
        /// Vértice de destino
        /// </summary>
        public Vertice Destino { get; set; }

        /// <summary>
        /// Custo do arco
        /// </summary>
        public double Peso { get; set; }

        #endregion Fim [Propriedades]

        public Arco(Vertice pOrigem, Vertice pDestino, double pPeso)
        {
            this.Origem = pOrigem;
            this.Destino = pDestino;
            this.Peso = pPeso;
            Origem.AdicionarArco(this);//Verificar se é necessário
            Destino.AdicionarArco(this);//Verificar se é necessário
        }
    }
}
