using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Dono
    {
        private int idDono;
        private String nomeDn;
        private String telefone;
        private String email;
        private double valor;

        public void setIdDono(int idDono)
        {
            this.idDono = idDono;
        }

        public int getIdDono()
        {
            return idDono;
        }

        public void setNome(string nomeDn)
        {
            this.nomeDn = nomeDn;
        }

        public string getNome()
        {
            return nomeDn;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getTelefone()
        {
            return telefone;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return email;
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
