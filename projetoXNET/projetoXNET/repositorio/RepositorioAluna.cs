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
    class RepositorioAluna:ConexaoBD{
        public Boolean verificausuario = false;
        public void removerAluna(Aluno aluna)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "delete from Aluno where idAlun = " + aluna.IdAluno + ";";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex )
            {

                throw new Exception("Erro na Instrução Delete"+ex+"");
            }

        }
        public void atualizarAluno(Aluno aluna)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "update aluna set "
            + " idAlun = " + aluna.IdAlunoNova + ","
            + " nomeAlun = '" + aluna.NomelAuno + "',"
            + " cpfAlun = '" + aluna.CpfAluno + "',"
            + " logradouroAlun = '" + aluna.EnderecoAluno + "',"
            + " numeroAlun = " + aluna.Numero + ","
            + " rgAlun = '" + aluna.RgAluno + "',"
            + " ufAlun = '" + aluna.UfAluno + "',"
            + " complementoAlun = '" + aluna.Comple + "',"
            + " bairroAlun = '" + aluna.BairroAluno + "',"
            + " cidadeAlun = '" + aluna.CidadeAluno + "',"
            + " idCursoalu = " + aluna.Curso.IdCurso + ","
            + " idTurmaalu = " + aluna.Turma.IdTurma + ","
            + " senha_sistema = '" + aluna.SenhaAluno + "',"
            + " login_sistema = '" + aluna.LoginAluno + "'"
            + " WHERE idAlun = " + aluna.IdAluno + ";";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Atualizar" + ex + "");
            }
        }

        public void cadastroAluna(Aluno aluna)
        {

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "insert into Aluna( nomeAlun, dataNascAlun, cpfAlun, logradouroAlun, numeroAlun, rgAlun, ufAlun, idAlun, complementoAlun, bairroAlun, cidadeAlun, idCursoalu, idTurmaalu,login_sistema, senha_sistema) values('" + aluna.NomelAuno + "','" + aluna.DmaAluno + "','" + aluna.CpfAluno + "','" + aluna.EnderecoAluno + "'," + aluna.Numero + ",'" + aluna.RgAluno + "','" + aluna.UfAluno + "'," + aluna.IdAluno + ",'" + aluna.Comple + "','" + aluna.BairroAluno + "','" + aluna.CidadeAluno + "'," + aluna.Curso.IdCurso + "," + aluna.Turma.IdTurma + ",'" + aluna.LoginAluno + "','" + aluna.SenhaAluno + "');";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Cadastrar" + ex + "");
            }
        }
        public void loginAluna(Aluno aluna)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT login_sistema, senha_sistema FROM Aluna where login_sistema = '" + aluna.LoginAluno + "' and senha_sistema = '" + aluna.SenhaAluno + "'";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                Boolean verificausuario = false;
                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    PainelAluno l = new PainelAluno();
                    l.ShowDialog();
                }
                if (verificausuario == false)
                {
                    throw new Exception("Falha no Login do Sistema Aluno");
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
        public List<Aluno> listaaluno()
        {
            List<Aluno> retorno = new List<Aluno>();

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idAlun, nomeAlun FROM Aluna";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                while (DbReader.Read())
                {
                    Aluno aluna = new Aluno();
                    aluna.IdAluno = (DbReader.GetInt32(DbReader.GetOrdinal("idAlun")));
                    aluna.NomelAuno = (DbReader.GetString(DbReader.GetOrdinal("nomeAlun")));
                    retorno.Add(aluna);

                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception a)
            {
                throw new Exception("Erro no Lista ID Aluno:" + a + "");
            }
            return retorno;

        }
        public void ListarAlunospainelprof(ListView list,Aluno aluna)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idAlun,nomeAlun FROM Aluna where idCursoalu = " + aluna.Curso.IdCurso + " and idTurmaalu =" + aluna.Turma.IdTurma+ "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                while (DbReader.Read())
                {
                    ListViewItem item = list.Items.Add("" + DbReader.GetInt32(DbReader.GetOrdinal("idAlun")));
                    item.SubItems.Add(DbReader.GetString(DbReader.GetOrdinal("nomeAlun")));
                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao executar instrução select " + e.Message);
            }

        }
        public void VerificaALUNOExistenteatualizar(Aluno aluna)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idAlunfre FROM Frequencia WHERE idAlunfre =  " + aluna.IdAluno + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    MessageBox.Show("Esse Aluno Esta Sendo Usado por um Frequencia, E naõ pode ser Atualizado");
                    return;
                }
                if (verificausuario == false)
                {
                    this.atualizarAluno(aluna);
                }
                //MessageBox.Show(linhas);
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao Verifica Aluno Existente" + e.Message);
            }
        }
        public void VerificaALUNOExistenteRemover(Aluno aluna)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idAlunfre FROM Frequencia WHERE idAlunfre =  " + aluna.IdAluno + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    MessageBox.Show("Esse Aluno Esta Sendo Usado por um Frequencia, E naõ pode ser Removido");
                    return;
                }
                if (verificausuario == false)
                {
                    this.removerAluna(aluna);
                }
                //MessageBox.Show(linhas);
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao Verifica Aluno Existente" + e.Message);
            }
        }
    }
}
