using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Apostador
    {
        private int idApostador;
        private String nome;
        private String telefone;
        private String email;
        private Double valor;

        // idApostador Methods
        public void setIdApostador(int idApostador)
        {
            this.idApostador = idApostador;
        }
        public int getIdApostador()
        {
            return idApostador;
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
        // telefone Methods
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }
        public String getTelefone()
        {
            return telefone;
        }
        // email Methods
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return email;
        }
        // valor Methods
        public void setValor(Double valor)
        {
            this.valor = valor;
        }
        public Double getValor()
        {
            return valor;
        }
    }
}
