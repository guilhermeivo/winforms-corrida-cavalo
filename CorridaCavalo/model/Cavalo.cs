using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Cavalo
    {
        /// <summary>Primary key</summary> 
        private int idCavalo;
        /// <summary>Foreign key</summary> 
        private int idDono;
        /// <summary>Foreign key</summary> 
        private int idStatus;
        private String nome;
        private int idade;

        // idCavalo Methods
        public void setIdCavalo(int idCavalo)
        {
            this.idCavalo = idCavalo;
        }
        public int getIdCavalo()
        {
            return idCavalo;
        }
        // idDono Methods
        public void setIdNono(int idDono)
        {
            this.idDono = idDono;
        }
        public int getIdNono()
        {
            return idDono;
        }
        // idStatus Methods
        public void setIdStatus(int idStatus)
        {
            this.idStatus = idStatus;
        }
        public int getIdStatus()
        {
            return idStatus;
        }
        // nome Methods
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return nome;
        }
        // idade Methods
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getIdade()
        {
            return idade;
        }
    }
}
