using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Categoria
    {
        /// <summary>Primary key</summary>
        private int idCategoria;
        private string categoria;

        // idCategoria Methods
        public void setIdCategoria(int idCategoria)
        {
            this.idCategoria = idCategoria;
        }
        public int getIdCategoria()
        {
            return idCategoria;
        }
        // idDescricao
        public void setDescCategoria(string categoria)
        {
            this.categoria = categoria;
        }
        public string getDescCategoria()
        {
            return categoria;
        }
    }
}
