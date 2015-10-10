using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class StarConfig
    {
        #region [Atributos]

        private int iNumLinhas = 0;
        private int iNumColunas = 0;
        private Tuple<int, int> tPosicaoInicial = null;
        private Tuple<int, int> tPosicaoFinal = null;
        private List<Tuple<int, int>> lstMuros = null;

        #endregion Fim [Atributos]

        #region [Propriedades]

        /// <summary>
        /// Retorna o número de linhas da matriz
        /// </summary>
        public int Linhas
        {
            get { return iNumLinhas; }
            set { iNumLinhas = value; }
        }

        /// <summary>
        /// Retorna o número de colunas da matriz
        /// </summary>
        public int Colunas
        {
            get { return iNumColunas; }
            set { iNumColunas = value; }
        }

        /// <summary>
        /// Retorna a posição inicial separadamente
        /// </summary>
        public Tuple<int,int> PosicaoInicial
        {
            get
            {
                return tPosicaoInicial;
            }
        }

        /// <summary>
        /// Retorna a posição final separadamente
        /// </summary>
        public Tuple<int,int> PosicaoFinal
        {
            get
            {
                return tPosicaoFinal;
            }
            
        }

        /// <summary>
        /// Retorna a lista de muros
        /// </summary>
        public List<Tuple<int, int>> Muros
        {
            get { return lstMuros; }
        }

        #endregion Fim [Propriedades]

        #region [Construtor]

        public StarConfig()
        {
            lstMuros = new List<Tuple<int, int>>();
        }

        #endregion Fim [Construtor]

        #region [Métodos]

        /// <summary>
        /// Define a posição inicial
        /// </summary>
        /// <param name="pPosicaoInicial"></param>
        public void SetPosicaoInicial(string pPosicaoInicial)
        {
            string[] sNovaTupla = pPosicaoInicial.Split(new char[] { ',' });
            tPosicaoInicial = new Tuple<int, int>(Convert.ToInt32(sNovaTupla[0]), Convert.ToInt32(sNovaTupla[1]));
        }

        /// <summary>
        /// Define a posição final
        /// </summary>
        /// <param name="pPosicaoFinal"></param>
        public void SetPosicaoFinal(string pPosicaoFinal)
        {
            string[] sNovaTupla = pPosicaoFinal.Split(new char[] { ',' });
            tPosicaoFinal = new Tuple<int, int>(Convert.ToInt32(sNovaTupla[0]), Convert.ToInt32(sNovaTupla[1]));
        }

        /// <summary>
        /// Adiciona uma nova posição de um muro
        /// </summary>
        /// <param name="pPosicao"></param>
        public void AdicionarMuro(string pPosicao)
        {
            string[] sNovaTupla = pPosicao.Split(new char[] { ',' });
            Tuple<int, int> novaTupla = new Tuple<int, int>(Convert.ToInt32(sNovaTupla[0]), Convert.ToInt32(sNovaTupla[1]));
            lstMuros.Add(novaTupla);
        }

        #endregion Fim [Métodos]
    }
}
