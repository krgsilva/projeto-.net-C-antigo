using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Data.Odbc;
using projetoXNET.basica;

namespace projetoXNET
{
    class ConexaoBD
    {
        public OdbcConnection conn;
        private string nomeConexao = "xnet";


        #region abrir conexao
        public void abrirConexao()
        {
            this.conn = new OdbcConnection("DSN=" + nomeConexao);
            try
            {
                this.conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha com conxao" + ex.Message);
            }
        }
        #endregion
        #region fechar conexão
        public void fecharConexao()
        {
            this.conn.Close();
        }

        #endregion


    }
}
