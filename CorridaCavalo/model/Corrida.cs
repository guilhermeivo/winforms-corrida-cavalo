using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Corrida
    {
        private int idcorrida;
        private string dtcorrida;
        private string local;
        private string distancia;

        public void setIdCorrida(int idcorrida)
        {
            this.idcorrida = idcorrida;
        }

        public int getIdCorrida()
        {
            return idcorrida;
        }

        public void setDtCorrida(string dtcorrida)
        {
            this.dtcorrida = dtcorrida;
        }

        public string getDtCorrida()
        {
            return dtcorrida;
        }

        public void setLocal(string local)
        {
            this.local = local;
        }

        public string getLocal()
        {
            return local;
        }

        public void setDistancia(string distancia)
        {
            this.distancia = distancia;
        }

        public string getDistancia()
        {
            return distancia;
        }
    }
}
