using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoXNET.basica;
using projetoXNET.gui;

namespace projetoXNET.repositorio
{
    class RepositorioAdministrador:ConexaoBD
    {
        public void loginAdministrador(Administrador administrador)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT login, senha FROM Admin where login = '" + administrador.Login + "' and senha = '" + administrador.Senha + "'";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                Boolean verificausuario = false;
                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    PainelAdmin l = new PainelAdmin();
                    l.ShowDialog();
                }
                if (verificausuario == false)
                {
                    throw new Exception("Falha no Login do Sistema Administrador");
                }
                //MessageBox.Show(linhas);
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao executar instrução Login do Sistema " + e.Message);
            }
        }
    }
}
