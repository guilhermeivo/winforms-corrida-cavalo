using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Aposta
    {
        /// <summary>Foreign key</summary> 
        private int idApostador;
        /// <summary>Foreign key</summary> 
        private int idCavalo;
        /// <summary>Foreign key</summary> 
        private int idCorrida;
        private double valor;

        // idApostador Methods
        public void setIdApostador(int idApostador)
        {
            this.idApostador = idApostador;
        }
        public int getIdApostador()
        {
            return idApostador;
        }
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
        // valor Methods
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
