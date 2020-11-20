using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaCavalo.model
{
    class Categoria
    {
        private int idcat;
        private string cat;

        public void setIdCategoria(int idcat)
        {
            this.idcat = idcat;
        }

        public int getIdCategoria()
        {
            return idcat;
        }

        public void setDescCategoria(string cat)
        {
            this.cat = cat;
        }

        public string getDescCategoria()
        {
            return cat;
        }

    }
}
