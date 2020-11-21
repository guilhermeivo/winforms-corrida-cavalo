using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Dono
    {
        /// <summary>Primary key</summary> 
        private int idDono;
        private String nomeDn;
        private String telefone;
        private String email;

        // idDono Methods
        public void setIdDono(int idDono)
        {
            this.idDono = idDono;
        }
        public int getIdDono()
        {
            return idDono;
        }
        // nome Methods
        public void setNome(string nomeDn)
        {
            this.nomeDn = nomeDn;
        }
        public string getNome()
        {
            return nomeDn;
        }
        // telefone Methods
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return telefone;
        }
        // email Methods
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
    }
}
