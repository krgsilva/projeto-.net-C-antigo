using projetoXNET.basica;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetoXNET.repositorio
{
    class RepositorioCurso:ConexaoBD
    {
        public Boolean verificurso;
        public void VerificacursoExistenteremover(Curso curso)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT * FROM Aluna where idCursoalu =  " + curso.IdCurso + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    verificurso = true;
                    break;
                }
                if (verificurso == true)
                {
                    MessageBox.Show("Esse Curso Esta Sendo Usado por um Aluno, E naõ pode ser Removido");
                }
                if (verificurso == false)
                {
                    this.removerCurso(curso);
                }
                //MessageBox.Show(linhas);
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao Verifica Curso Existente " + e.Message);
            }
        }
        public List<Curso> listacurso()
        {
            List<Curso> retorno = new List<Curso>();

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idCurso, nomeCurso FROM Curso";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                while (DbReader.Read())
                {
                    Curso curso = new Curso();
                    curso.IdCurso = (DbReader.GetInt32(DbReader.GetOrdinal("idCurso")));
                    curso.NomeCurso = (DbReader.GetString(DbReader.GetOrdinal("nomeCurso")));
                    retorno.Add(curso);

                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception a)
            {
                throw new Exception("Erro no Lista ID curso:"+a+"");
            }
            return retorno;

        }
        public void removerCurso(Curso curso)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "delete from Curso where idCurso = " + curso.IdCurso + ";";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
                verificurso = false;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Delete" + ex + "");
            }
        }

        public void cadastroCurso(Curso curso)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "insert into Curso(duracao,idCurso,nomeCurso,termino,inicio,valor) values ('" + curso.DuracaoCurso + "'," + curso.IdCurso + ",'" + curso.NomeCurso + "','" + curso.TerminoCurso + "','" + curso.InicioCurso + "','" + curso.ValorCurso + "');";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Cadastrar" + ex + "");
            }
        }
        public void VerificacursoExistenteatualizar(Curso curso)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT * FROM Aluna where idCursoalu =  " + curso.IdCurso + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                
                while (DbReader.Read())
                {
                    verificurso = true;
                    break;
                }
                if (verificurso == true)
                {
                    MessageBox.Show("Esse Curso Esta Sendo Usado por um Aluno, E naõ pode ser Atualizado");
                }
                if (verificurso == false)
                {
                    this.atualizarCurso(curso);
                }
                //MessageBox.Show(linhas);
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao Verifica Curso Existente" + e.Message);
            }
        }
        public void atualizarCurso(Curso curso)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "update curso set "
            + " idcurso = " + curso.IdNovoCurso + ","
            + " nomecurso = '" + curso.NomeCurso + "',"
            + " termino = '" + curso.TerminoCurso + "',"
            + " inicio = '" + curso.InicioCurso + "',"
            + " valor = '" + curso.ValorCurso + "',"
            + " duracao = '" + curso.DuracaoCurso + "'"
            + " WHERE idcurso = '" + curso.IdCurso + "';";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
                verificurso = false;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Atualizar" + ex + "");
            }
        }
    }
}
