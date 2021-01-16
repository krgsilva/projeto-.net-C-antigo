using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoXNET.gui;

namespace projetoXNET.repositorio
{
    class RepositorioProfessor:ConexaoBD
    {
        public Boolean verificausuario = false;
        public void VerificaProfessorExistenteremover(Professor professor)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT * FROM Disciplina where idProfdis =  " + professor.IdProf + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    MessageBox.Show("Esse Professor Esta Sendo Usado por uma Disciplina, E naõ pode ser Removido");
                }
                if (verificausuario == false)
                {
                    this.removerProfessor(professor);
                }
                //MessageBox.Show(linhas);
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao executar instrução Verifica Professor Existente " + e.Message);
            }
        }
        public List<Professor> listaprofessor()
        {
            List<Professor> retorno = new List<Professor>();

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idProf, nomeProf FROM Professor";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                while (DbReader.Read())
                {
                    Professor professor = new Professor();
                    professor.IdProf = (DbReader.GetInt32(DbReader.GetOrdinal("idProf")));
                    professor.NomeProf = (DbReader.GetString(DbReader.GetOrdinal("nomeProf")));
                    retorno.Add(professor);

                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception a)
            {
                throw new Exception("Erro no Lista ID Professor:" + a + "");
            }
            return retorno;

        }
        public void VerificaProfessorExistenteAtualizar(Professor professor)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT * FROM Disciplina where idProfdis =  " + professor.IdProf + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    MessageBox.Show("Esse Professor Esta Sendo Usado por uma Disciplina, E naõ pode ser Atualizado");
                    return;
                }
                if (verificausuario == false)
                {
                    this.atualizarProfessor(professor);
                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao executar instrução Verifica Professor Existente  " + e.Message);
            }
        }
        public void atualizarProfessor(Professor professor)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "update professor set "
            + " idProf = " + professor.IdProfnova + ","
            + " nomeProf = '" + professor.NomeProf + "',"
            + " cpfProf = '" + professor.CpfProf + "',"
            + " logradouroProf = '" + professor.LogradouroProf + "',"
            + " numeroProf = " + professor.NumeroProf + ","
            + " rgProf = '" + professor.RgProf + "',"
            + " ufProf = '" + professor.UfProf + "',"
            + " complementoProf = '" + professor.ComplementoProf + "',"
            + " bairroProf = '" + professor.BairroProf + "',"
            + " cidadeProf = '" + professor.CidadeProf + "',"
            + " senha_senha = '" + professor.SenhaProf + "',"
            + " login_sistema = '" + professor.LoginProf + "',"
            + " salario = '" + professor.SalarioProf + "'"
            + " WHERE idProf = " + professor.IdProf + ";";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Atualizar" + ex + "");
            }
        }
        public void removerProfessor(Professor professor)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "delete from Professor where idProf = " + professor.IdProf + ";";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Delete" + ex + "");
            }
        }

        public void cadastroProfessor(Professor professor)
        {

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "insert into Professor( nomeProf, salario, rgProf, logradouroProf, cpfProf, dataNascProf, complementoProf, bairroProf, cidadeProf, numeroProf, idProf, ufProf, login_sistema, senha_senha) values('" + professor.NomeProf + "','" + professor.SalarioProf + "','" + professor.RgProf + "','" + professor.LogradouroProf + "','" + professor.CpfProf + "','" + professor.DataNascProf + "','" + professor.ComplementoProf + "','" + professor.BairroProf + "','" + professor.CidadeProf + "'," + professor.NumeroProf + "," + professor.IdProf + ",'" + professor.UfProf + "','" + professor.LoginProf + "','" + professor.SenhaProf + "');";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Delete" + ex + "");
            }
        }
        public void loginProfessor(Professor professor)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT login_sistema, senha_senha FROM Professor where login_sistema = '" + professor.LoginProf + "' and senha_senha = '" + professor.SenhaProf + "'";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                Boolean verificausuario = false;
                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    PainelProfessor l = new PainelProfessor();
                    l.ShowDialog();
                }
                if (verificausuario == false)
                {
                    throw new Exception("Falha no Login do Sistema Professor");
                }
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
