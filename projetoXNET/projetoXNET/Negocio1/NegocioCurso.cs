using projetoXNET.basica;
using projetoXNET.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoXNET.Negocio1
{
    class NegocioCurso
    {
            RepositorioCurso repositorioCurso = new RepositorioCurso();

    public void validarRemocaoCurso(Curso curso){

        if (curso.IdCurso <= 0) {
            throw new Exception("Campo da ID Curso Inválido para Remover");
             

        }
        this.repositorioCurso.VerificacursoExistenteremover(curso);
    }

        public void validarcadastroCurso(Curso curso){

        if (curso.IdCurso <= 0) {
            throw new Exception("Campo da ID Curso Inválido para Cadastro");
        }
        if (curso.NomeCurso == null || curso.NomeCurso.Trim().Equals("")) {
            throw new Exception("Campo do Nome Curso Inválido para Cadastro");
        }
        if (curso.DuracaoCurso == null || curso.DuracaoCurso.Trim().Equals("")) {
            throw new Exception("Campo Ducação Curso Inválido para Cadastro");
        }
        if (curso.InicioCurso == null || curso.InicioCurso.Trim().Equals("")) {
            throw new Exception("Campo Inicio Curso Inválido para Cadastro");
        }
        if (curso.TerminoCurso == null || curso.TerminoCurso.Trim().Equals("")) {
            throw new Exception("Campo Termino Curso Inválido para Cadastro");
        }
        if (curso.ValorCurso == null || curso.ValorCurso.Trim().Equals("")) {
            throw new Exception("Campo Valor Curso Inválido para Cadastro");
        }
        this.repositorioCurso.cadastroCurso(curso);
    }
        public void validaratualizarCurso(Curso curso)
        {

            if (curso.IdCurso <= 0)
            {
                throw new Exception("Campo da ID Curso Inválido para Cadastro");
            }
            if (curso.IdNovoCurso <= 0)
            {
                throw new Exception("Campo da ID Nova Curso Inválido para Cadastro");
            }
            if (curso.NomeCurso == null || curso.NomeCurso.Trim().Equals(""))
            {
                throw new Exception("Campo do Nome Curso Inválido para Cadastro");
            }
            if (curso.DuracaoCurso == null || curso.DuracaoCurso.Trim().Equals(""))
            {
                throw new Exception("Campo Ducação Curso Inválido para Cadastro");
            }
            if (curso.InicioCurso == null || curso.InicioCurso.Trim().Equals(""))
            {
                throw new Exception("Campo Inicio Curso Inválido para Cadastro");
            }
            if (curso.TerminoCurso == null || curso.TerminoCurso.Trim().Equals(""))
            {
                throw new Exception("Campo Termino Curso Inválido para Cadastro");
            }
            if (curso.ValorCurso == null || curso.ValorCurso.Trim().Equals(""))
            {
                throw new Exception("Campo Valor Curso Inválido para Cadastro");
            }
            this.repositorioCurso.VerificacursoExistenteatualizar(curso);
        }


    }
    }

