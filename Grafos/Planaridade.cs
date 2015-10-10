using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Planaridade
    {
        #region [Atributos]

        private List<Vertice> listaVertices = new List<Vertice>();

        private List<Arco> listaArcos = new List<Arco>();

        private string sRotuloInicial = "";

        private int iCount = 0;

        private bool bPlanar = false;

        #endregion Fim [Atributos]

        #region [Construtores]

        public Planaridade(List<Vertice> pListaVertices, List<Arco> pListaArcos)
        {
            listaVertices = pListaVertices;
            listaArcos = pListaArcos;
        }

        public void VerificarPlanaridade()
        {
            int E = listaArcos.Count;

            if (listaVertices.Count >= 3)
            {
                if (E <= ((3 * listaVertices.Count) - 6))
                {
                    sRotuloInicial = listaVertices.AsEnumerable().OrderBy(item => item.Rotulo).FirstOrDefault().Rotulo;
                    if (!PossuiCiclo(sRotuloInicial))
                    {
                        if (E <= ((2 * listaVertices.Count) - 4))
                            bPlanar = true;
                    }
                    else
                        bPlanar = false;
                }
                else
                    bPlanar = false;
            }
            
        }

        private bool PossuiCiclo(string pRotulo)
        {

            foreach (Vertice item in listaVertices.AsEnumerable().Where(v => v.Rotulo.Equals(pRotulo)))
            {

                foreach (Arco arco in listaArcos.Where(arc => arc.Destino.Id != item.Id))
                {
                    if (iCount < 3)
                    {
                        iCount++;
                        PossuiCiclo(arco.Destino.Rotulo);
                    }
                    else
                    {
                        if (arco.Destino.Rotulo.Equals(sRotuloInicial))
                        {
                            bPlanar = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return bPlanar;
        }

        #endregion Fim [Construtores]
    }
}
