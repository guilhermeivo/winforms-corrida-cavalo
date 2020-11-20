using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class CorridaCavalo
    {
        private int idcavalo;
        private int idcorrida;

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
    }
}
