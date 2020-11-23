using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class CoridaCavalo
    {
        /// <summary>Foreign key</summary> 
        private int idCavalo;
        /// <summary>Foreign key</summary> 
        private int idCorrida;

        // idCavalo Methods
        public void setIdCavalo(int idCavalo)
        {
            this.idCavalo = idCavalo;
        }
        public int getIdCavalo()
        {
            return idCavalo;
        }
        // idCorrida Methods
        public void setIdCorrida(int idCorrida)
        {
            this.idCorrida = idCorrida;
        }
        public int getIdCorrida()
        {
            return idCorrida;
        }
    }
}
