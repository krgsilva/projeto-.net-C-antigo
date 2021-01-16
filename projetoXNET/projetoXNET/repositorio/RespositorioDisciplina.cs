using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoXNET.basica;

namespace projetoXNET.repositorio
{
    class RespositorioDisciplina:ConexaoBD

    {
        public Boolean verificausuario = false;
        public void VerificaDisciplinaExistenteremover(Disciplina disciplina)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idDisciplinafre FROM Frequencia WHERE idDisciplinafre =  " + disciplina.IdDisc + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    MessageBox.Show("Essa Disciplina Esta Sendo Usado por Frequencia, E naõ pode ser Removido");
                    verificausuario = true;
                }
                if (verificausuario == false)
                {
                    this.removerDisciplina(disciplina);
                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao Verifica Disciplina Existente " + e.Message);
            }
        }
        public void VerificaDisciplinaExistenteAtualizar(Disciplina disciplina)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idDisciplinafre FROM Frequencia WHERE idDisciplinafre =  " + disciplina.IdDisc + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    verificausuario = true;
                    break;
                }
                if (verificausuario == true)
                {
                    MessageBox.Show("Essa Disciplina Esta Sendo Usado por Frequencia, E naõ pode ser Atualizado");
                }
                if (verificausuario == false)
                {
                    this.atualizarDisciplina(disciplina);
                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao Verifica Disciplina Existente " + e.Message);
            }
        }
        public void atualizarDisciplina(Disciplina disciplina)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "update disciplina set "
            + " nomeDisc = '" + disciplina.NomeDisc + "',"
            + " horaEntrada = '" + disciplina.HoraEntradaDisc + "',"
            + " cargaHor = '" + disciplina.CargaHorDisc + "',"
            + " horaSaida = '" + disciplina.HoraSaidaDisc + "',"
            + " idDisciplina = " + disciplina.IdDiscnova + ","
            + " idProfdis = " + disciplina.Prof.IdProf + ""
            + " where idDisciplina = " + disciplina.IdDisc + ";";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
                verificausuario = false;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Atualizar" + ex + "");
            }
        }
        public void removerDisciplina(Disciplina disciplina)
        {
            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "delete from Disciplina where idDisciplina  = " + disciplina.IdDisc + ";";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
                verificausuario = false;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Delete" + ex + "");
            }
        }
        public void cadastroDisciplina(Disciplina disciplina)
        {

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "insert into Disciplina( nomeDisc, horaEntrada, cargaHor, horaSaida, idDisciplina, idProfdis) values('" + disciplina.NomeDisc + "','" + disciplina.HoraEntradaDisc + "'," + disciplina.CargaHorDisc + ",'" + disciplina.HoraSaidaDisc + "'," + disciplina.IdDisc + "," + disciplina.Prof.IdProf + ");";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Instrução Cadastrar" + ex + "");
            }
        }
        public List<Disciplina> listaDisciplina()
        {
            List<Disciplina> retorno = new List<Disciplina>();

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "SELECT idDisciplina, nomeDisc FROM Disciplina";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                while (DbReader.Read())
                {
                    Disciplina disciplina = new Disciplina();
                    disciplina.IdDisc = (DbReader.GetInt32(DbReader.GetOrdinal("idDisciplina")));
                    disciplina.NomeDisc = (DbReader.GetString(DbReader.GetOrdinal("nomeDisc")));
                    retorno.Add(disciplina);

                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception a)
            {
                throw new Exception("Erro no Lista ID Disciplina:" + a + "");
            }
            return retorno;

        }
    }
}
