using CorridaCavalo.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaCavalo.dao
{
    class ApostadorDAO
    {
        SqlConnection conn = ConexionDataBase.obterConexao();

        public void criarApostador(Apostador apostador)
        {
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("insert int Apostador (nome, telefone, email, valor) values (@nome, @telefone, @email, @valor", conn);
                cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 100).Value = apostador.getNome();
                cmd.Parameters.Add("@telefone", SqlDbType.NVarChar, 11).Value = apostador.getTelefone();
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = apostador.getEmail();
                cmd.Parameters.Add("@valor", SqlDbType.Money).Value = apostador.getValor();

                ConexionDataBase.fecharConexao();

                MessageBox.Show("Registro inserido");
            }
        }
    }
}
