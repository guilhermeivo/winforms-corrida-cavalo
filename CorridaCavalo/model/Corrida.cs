using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Corrida
    {
        /// <summary>Primary key</summary> 
        private int idCorrida;
        private string dtCorrida;
        private string local;
        private string distancia;

        // idCorrida Methods
        public void setIdCorrida(int idCorrida)
        {
            this.idCorrida = idCorrida;
        }
        public int getIdCorrida()
        {
            return idCorrida;
        }
        // dtCorrida Methods
        public void setDtCorrida(string dtCorrida)
        {
            this.dtCorrida = dtCorrida;
        }
        public string getDtCorrida()
        {
            return dtCorrida;
        }
        // local Methods
        public void setLocal(string local)
        {
            this.local = local;
        }
        public string getLocal()
        {
            return local;
        }
        // distancia Methods
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
