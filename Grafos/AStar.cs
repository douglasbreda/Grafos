
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class AStar
    {
        #region [Atributos]

        private DataTable dtbControle = new DataTable();
        private DataTable dtbEstrela = new DataTable();
        private StarConfig oConfigStar;
        private int F = 0;
        private int H = 0;
        private int G = 0;
        private Tuple<int, int> posicaoAtual;
        private int iValorFAtual = 0;
        List<Tuple<int, int, int>> listaPosicoesAtuais = new List<Tuple<int, int, int>>();

        #endregion Fim [Atributos]

        #region [Propriedades]

        public DataTable Estrela
        {
            get { return dtbEstrela; }
            set { dtbEstrela = value; }
        }

        #endregion Fim [Propriedades]

        #region [Construtor]

        public AStar(StarConfig pConfiguracoes)
        {
            this.oConfigStar = pConfiguracoes;
            PreencherEstrela();
        }

        #endregion Fim [Construtor]

        #region [Métodos]

        private void DefinirColunas()
        {
            DataColumn colx = new DataColumn("X", typeof(int));
            DataColumn coly = new DataColumn("Y", typeof(int));
            DataColumn colv = new DataColumn("V", typeof(bool));

            dtbControle.Columns.Add(colx);
            dtbControle.Columns.Add(coly);
            dtbControle.Columns.Add(colv);
        }

        private void PreencherEstrela()
        {
            DataColumn dcNovaColuna = null;
            DataRow drwNovaLinha = null;

            //Montar Tabela (Linhas)
            for (int c = 0; c < oConfigStar.Colunas; c++)
            {
                dcNovaColuna = new DataColumn(c.ToString(), typeof(string));
                dtbEstrela.Columns.Add(dcNovaColuna);
            }

            //Montar Tabela (Colunas)
            for (int l = 0; l < oConfigStar.Linhas; l++)
            {
                drwNovaLinha = dtbEstrela.NewRow();
                dtbEstrela.Rows.Add(drwNovaLinha);
            }

            //Posição Inicial
            dtbEstrela.Rows[oConfigStar.PosicaoInicial.Item1][oConfigStar.PosicaoInicial.Item2] = "Inicio";

            //Posição Final
            dtbEstrela.Rows[oConfigStar.PosicaoFinal.Item1][oConfigStar.PosicaoFinal.Item2] = "Fim";

            //Muros
            for (int i = 0; i < oConfigStar.Muros.Count; i++)
            {
                dtbEstrela.Rows[oConfigStar.Muros[i].Item1][oConfigStar.Muros[i].Item2] = "Muro";
            }

            posicaoAtual = new Tuple<int, int>(oConfigStar.PosicaoInicial.Item1, oConfigStar.PosicaoInicial.Item2);
            G = 0;
            CalcularH(oConfigStar.PosicaoInicial.Item1, oConfigStar.PosicaoInicial.Item2);
            CalcularProximaPosicao();
        }

        private int CalcularH(int pXInicial, int pYInicial)
        {
            return (Math.Abs(pXInicial - oConfigStar.PosicaoFinal.Item1) + Math.Abs(pYInicial - oConfigStar.PosicaoFinal.Item2)) * 10;
        }

        private void CalcularProximaPosicao()
        {
            H = CalcularH(posicaoAtual.Item1, posicaoAtual.Item2);
            listaPosicoesAtuais.Clear();
            BuscarValorHAbaixo();
            BuscarValorHAcima();
            BuscarValorHDireita();
            BuscarValorHEsquerda();
            BuscarValorHDiagonalBaixoEsquerda();
            BuscarValorHDiagonalBaixoDireita();
            BuscarValorHDiagonalCimaEsquerda();
            BuscarValorHDiagonalCimaDireita();
            ProximoIndice();

            if(posicaoAtual.Item1 == oConfigStar.PosicaoFinal.Item1 && posicaoAtual.Item2 == oConfigStar.PosicaoFinal.Item2)
            {

            }
            else
            {
                CalcularProximaPosicao();
            }
        }

        private void BuscarValorHAcima()
        {
            if (!dtbEstrela.Rows[posicaoAtual.Item1 - 1][posicaoAtual.Item2].ToString().Equals("Muro"))
            {
                int iValor = CalcularH(posicaoAtual.Item1 - 1, posicaoAtual.Item2);
                iValor = iValor + 10;
                listaPosicoesAtuais.Add(new Tuple<int, int, int>(posicaoAtual.Item1 - 1, posicaoAtual.Item2, iValor));
            }
        }

        private void BuscarValorHDireita()
        {
            if (!dtbEstrela.Rows[posicaoAtual.Item1][posicaoAtual.Item2 + 1].ToString().Equals("Muro"))
            {
                int iValor = CalcularH(posicaoAtual.Item1, posicaoAtual.Item2 + 1);
                iValor = iValor + 10;
                listaPosicoesAtuais.Add(new Tuple<int, int, int>(posicaoAtual.Item1, posicaoAtual.Item2 + 1, iValor));
            }
        }

        private void BuscarValorHEsquerda()
        {
            if (!dtbEstrela.Rows[posicaoAtual.Item1][posicaoAtual.Item2 - 1].ToString().Equals("Muro"))
            {
                int iValor = CalcularH(posicaoAtual.Item1, posicaoAtual.Item2 - 1);
                iValor = iValor + 10;
                listaPosicoesAtuais.Add(new Tuple<int, int, int>(posicaoAtual.Item1, posicaoAtual.Item2 - 1, iValor));
            }
        }

        private void BuscarValorHAbaixo()
        {
            if (!dtbEstrela.Rows[posicaoAtual.Item1 + 1][posicaoAtual.Item2].ToString().Equals("Muro"))
            {
                int iValor = CalcularH(posicaoAtual.Item1 + 1, posicaoAtual.Item2);
                iValor = iValor + 10;
                listaPosicoesAtuais.Add(new Tuple<int, int, int>(posicaoAtual.Item1 + 1, posicaoAtual.Item2, iValor));
            }
        }

        private void BuscarValorHDiagonalBaixoEsquerda()
        {
            if (!dtbEstrela.Rows[posicaoAtual.Item1 + 1][posicaoAtual.Item2 + 1].ToString().Equals("Muro"))
            {
                int iValor = CalcularH(posicaoAtual.Item1 + 1, posicaoAtual.Item2 + 1);
                iValor = iValor + 14;
                listaPosicoesAtuais.Add(new Tuple<int, int, int>(posicaoAtual.Item1 + 1, posicaoAtual.Item2 + 1, iValor));
            }
        }

        private void BuscarValorHDiagonalBaixoDireita()
        {
            if (!dtbEstrela.Rows[posicaoAtual.Item1 + 1][posicaoAtual.Item2 - 1].ToString().Equals("Muro"))
            {
                int iValor = CalcularH(posicaoAtual.Item1 + 1, posicaoAtual.Item2 - 1);
                iValor = iValor + 14;
                listaPosicoesAtuais.Add(new Tuple<int, int, int>(posicaoAtual.Item1 + 1, posicaoAtual.Item2 - 1, iValor));
            }
        }

        private void BuscarValorHDiagonalCimaEsquerda()
        {
            if (!dtbEstrela.Rows[posicaoAtual.Item1 - 1][posicaoAtual.Item2 - 1].ToString().Equals("Muro"))
            {
                int iValor = CalcularH(posicaoAtual.Item1 - 1, posicaoAtual.Item2 - 1);
                iValor = iValor + 14;
                listaPosicoesAtuais.Add(new Tuple<int, int, int>(posicaoAtual.Item1 - 1, posicaoAtual.Item2 - 1, iValor));
            }
        }

        private void BuscarValorHDiagonalCimaDireita()
        {
            if (!dtbEstrela.Rows[posicaoAtual.Item1 - 1][posicaoAtual.Item2 + 1].ToString().Equals("Muro"))
            {
                int iValor = CalcularH(posicaoAtual.Item1 - 1, posicaoAtual.Item2 + 1);
                iValor = iValor + 14;
                listaPosicoesAtuais.Add(new Tuple<int, int, int>(posicaoAtual.Item1 - 1, posicaoAtual.Item2 + 1, iValor));
            }
        }

        private void ProximoIndice()
        {
            int iMenorValor = listaPosicoesAtuais.AsEnumerable().Min(item => item.Item3);

            listaPosicoesAtuais.AsEnumerable().ToList().ForEach(tupla =>
            {
                if (tupla.Item3 == iMenorValor)
                {
                    posicaoAtual = new Tuple<int, int>(tupla.Item1, tupla.Item2);
                    if (!dtbEstrela.Rows[posicaoAtual.Item1][posicaoAtual.Item2].ToString().Equals("Fim"))
                        dtbEstrela.Rows[posicaoAtual.Item1][posicaoAtual.Item2] = "X";
                }
            });
        }


        #endregion Fim [Métodos]
    }
}
