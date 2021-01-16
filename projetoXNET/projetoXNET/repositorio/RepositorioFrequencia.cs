using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoXNET.basica;

namespace projetoXNET.repositorio
{
    class RepositorioFrequencia : ConexaoBD
    {
        public Frequencia visualizarfrequencia(Frequencia frequencia)
        {
            try
            {
                this.abrirConexao();
                Frequencia retorno = new Frequencia();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "select sum(faltas) as faltas from Frequencia where idalunfre = " + frequencia.IdAlunfre.IdAluno + " and idDisciplinafre = " + frequencia.IdDisciplinafre.IdDisc + "";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    retorno.Faltas = (DbReader.GetInt32(DbReader.GetOrdinal("Faltas")));
                }
                DbReader.Close();
                DbCommand.Dispose();
                this.fecharConexao();
                return retorno;
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao executar instrução Visualizar Faltas do Sistema " + e.Message);
            }
        }
        public void cadastrarfrequencia(Frequencia frequencia)
        {

            try
            {
                this.abrirConexao();
                OdbcCommand DbCommand = conn.CreateCommand();
                DbCommand.CommandText = "INSERT INTO Frequencia(faltas,idAlunfre,idDisciplinafre) values(" + frequencia.Faltas + "," + frequencia.IdAlunfre.IdAluno + "," + frequencia.IdDisciplinafre.IdDisc + ");";
                DbCommand.ExecuteNonQuery();
                DbCommand.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no Cadastro da Frequencia : " + ex + "");
            }
        }
    }
}
