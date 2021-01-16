using projetoXNET.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoXNET.Negocio1
{
    class NegocioTurma
    {
        RepositorioTurma repositorioTurma = new RepositorioTurma();

        public void validarRemocaoTurma(Turma turma)
        {

            if (turma.IdTurma <= 0)
            {
                throw new Exception("Campo da ID Turma Inválido para Remover");
            }

            this.repositorioTurma.VerificaturmaExistenteremover(turma);
        }

        public void validarcadastroTurma(Turma turma)
        {

            if (turma.IdTurma <= 0)
            {
                throw new Exception("Campo da ID Turma Inválido para Cadastro");
            }
            if (turma.NomeTurma == null || turma.NomeTurma.Trim().Equals(""))
            {
                throw new Exception("Campo do Nome Turma Inválido para Cadastro");
            }
            if (turma.TurnoTurma == null || turma.TurnoTurma.Trim().Equals(""))
            {
                throw new Exception("Campo Turno da Turma Inválido para Cadastro");
            }

            this.repositorioTurma.cadastroTurma(turma);
        }
        public void validarAtualizarTurma(Turma turma)
        {

            if (turma.IdTurma <= 0)
            {
                throw new Exception("Campo da ID Turma Inválido para Alterar");
            }
            if (turma.IdTurmaNova <= 0)
            {
                throw new Exception("Campo da ID Nova Turma Inválido para Alterar");
            }
            if (turma.NomeTurma == null || turma.NomeTurma.Trim().Equals(""))
            {
                throw new Exception("Campo do Nome Turma Inválido para Alterar");
            }
            if (turma.TurnoTurma == null || turma.TurnoTurma.Trim().Equals(""))
            {
                throw new Exception("Campo Turno da Turma Inválido para Alterar");
            }

            this.repositorioTurma.VerificaturmaExistenteatualizar(turma);
        }
    }
}
