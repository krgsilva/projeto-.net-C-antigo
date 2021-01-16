using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetoXNET.repositorio
{
    class RepositorioTurma : ConexaoBD
    {
        public Boolean verificausuario = false;
        public List<Turma> listaturma()
        {
            List<Turma> retorno = new List<Turma>();

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idTurma, NomeTur FROM Turma";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                while (DbReader.Read())
                {
                    Turma turma = new Turma();
                    turma.IdTurma = (DbReader.GetInt32(DbReader.GetOrdinal("idTurma")));
                    turma.NomeTurma = (DbReader.GetString(DbReader.GetOrdinal("NomeTur")));
                    retorno.Add(turma);

                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception a)
            {
                throw new Exception("Erro no Lista ID Turma:" + a + "");
            }
            return retorno;

        }
        public void VerificaturmaExistenteremover(Turma turma)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT * FROM Aluna where idTurmaalu =  " + turma.IdTurma + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    MessageBox.Show("Essa Turma Esta Sendo Usado por um Aluno, E naõ pode ser Removido");
                    return;
                }
                if (verificausuario == false)
                {
                    this.removerTurma(turma);
                }
                //MessageBox.Show(linhas);
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao Verificar Turma Existente " + e.Message);
            }
        }
        public void VerificaturmaExistenteatualizar(Turma turma)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT * FROM Aluna where idTurmaalu =  " + turma.IdTurma + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    MessageBox.Show("Essa Turma Esta Sendo Usado por um Aluno, E naõ pode ser Atualizar");
                    return;
                }
                if (verificausuario == false)
                {
                    this.atualizarTurma(turma);
                }
                //MessageBox.Show(linhas);
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao Verificar Turma Existente " + e.Message);
            }
        }
        public void removerTurma(Turma turma)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "delete from Turma where idTurma = " + turma.IdTurma + ";";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Delete" + ex + "");
            }
        }

        public void cadastroTurma(Turma turma)
        {

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "insert into Turma( idTurma, NomeTur, Turno) values(" + turma.IdTurma + ",'" + turma.NomeTurma + "','" + turma.TurnoTurma + "');";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Cadastro" + ex + "");
            }
        }
        public void atualizarTurma(Turma turma)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "update turma set "
            + " NomeTur = '" + turma.NomeTurma + "',"
            + " Turno = '" + turma.TurnoTurma + "',"
            + " idTurma = " + turma.IdTurmaNova + ""
            + " WHERE idTurma = " + turma.IdTurma + ";";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Atualizar" + ex + "");
            }
        }

    }
}
