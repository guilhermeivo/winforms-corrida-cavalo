using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Aposta
    {
        private int idapostador;
        private int idcavalo;
        private int idcorrida;
        private double valor;

        public void setIdApostador(int idapostador)
        {
            this.idapostador = idapostador;
        }

        public int getIdApostador()
        {
            return idapostador;
        }

        public void setIdCavalo(int idcavalo)
        {
            this.idcavalo = idcavalo;
        }

        public int getIdCavalo()
        {
            return idcavalo;
        }

        public void setIdCorrida(int idcorrida)
        {
            this.idcorrida = idcorrida;
        }

        public int getIdCorrida()
        {
            return idcorrida;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double getValor()
        {
            return valor;
        }
    }
}
