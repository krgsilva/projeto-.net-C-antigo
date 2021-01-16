using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using projetoXNET.basica;
using projetoXNET.repositorio;

namespace projetoXNET.Negocio1
{
    class NegocioDisciplina
    {
        RespositorioDisciplina repositorioDisciplina = new RespositorioDisciplina();

    public void validarRemocaoDisciplina(Disciplina disciplina){

        if (disciplina.IdDisc <= 0) {
            throw new Exception("Campo da ID Disciplina Inválido para Remover");
        }

        this.repositorioDisciplina.VerificaDisciplinaExistenteremover(disciplina);
        
    }
    public void validarcadastrarDisciplina(Disciplina disciplina)
    {

        if (disciplina.IdDisc <= 0)
        {
            throw new Exception("Campo da ID Disciplina Inválido para Cadastro");
        }
        if (disciplina.NomeDisc == null || disciplina.NomeDisc.Trim().Equals(""))
        {
            throw new Exception("Campo do Nome Disciplina Inválido para Cadastro");
        }
        if (disciplina.CargaHorDisc <= 0)
        {
            throw new Exception("Campo Carga Horaria Inválido para Cadastro");
        }
        if (disciplina.HoraEntradaDisc == null || disciplina.HoraEntradaDisc.Trim().Equals(""))
        {
            throw new Exception("Campo Hora de Entrada Inválido para Cadastro");
        }
        if (disciplina.HoraSaidaDisc == null || disciplina.HoraSaidaDisc.Trim().Equals(""))
        {
            throw new Exception("Campo Hora de Saida Inválido para Cadastro");
        }
        if (disciplina.Prof == null || disciplina.Prof.Equals(""))
        {
            throw new Exception("Campo Professor Inválido para Cadastro");
        }
        this.repositorioDisciplina.cadastroDisciplina(disciplina);
    }
    public void validaratualizarDisciplina(Disciplina disciplina)
    {

        if (disciplina.IdDisc <= 0)
        {
            throw new Exception("Campo da ID Disciplina Inválido para Atualizar");
        }
        if (disciplina.NomeDisc == null || disciplina.NomeDisc.Trim().Equals(""))
        {
            throw new Exception("Campo do Nome Disciplina Inválido para Atualizar");
        }
        if (disciplina.CargaHorDisc <= 0)
        {
            throw new Exception("Campo Carga Horaria Inválido para Atualizar");
        }
        if (disciplina.IdDiscnova <= 0)
        {
            throw new Exception("Campo ID nova  Inválido para Atualizar");
        }
        if (disciplina.HoraEntradaDisc == null || disciplina.HoraEntradaDisc.Trim().Equals(""))
        {
            throw new Exception("Campo Hora de Entrada Inválido para Atualizar");
        }
        if (disciplina.HoraSaidaDisc == null || disciplina.HoraSaidaDisc.Trim().Equals(""))
        {
            throw new Exception("Campo Hora de Saida Inválido para Atualizar");
        }
        if (disciplina.Prof == null || disciplina.Prof.Equals(""))
        {
            throw new Exception("Campo Professor Inválido para Atualizar");
        }
        this.repositorioDisciplina.VerificaDisciplinaExistenteAtualizar(disciplina);
    }


    }
}
