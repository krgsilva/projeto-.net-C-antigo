using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using projetoXNET.repositorio;


namespace projetoXNET.Negocio1
{
    class NegocioProfessor
    {
        RepositorioProfessor repositorioProfessor = new RepositorioProfessor();


        public void validarRemocaoProfessor(Professor professor)
        {

            if (professor.IdProf == 0)
            {
                throw new Exception("Campo da ID Professor Inválido para Remover");
            }

            this.repositorioProfessor.VerificaProfessorExistenteremover(professor);
        }

        public void validarcadastrarProfessor(Professor professor)
        {


            if (professor.BairroProf == null || professor.BairroProf.Trim().Equals(""))
            {
                throw new Exception("Campo Bairro Professor Inválido para Cadastro");
            }
            if (professor.CidadeProf == null || professor.CidadeProf.Trim().Equals(""))
            {
                throw new Exception("Campo Cidade Professor Inválido para Cadastro");
            }
            if (professor.ComplementoProf == null || professor.ComplementoProf.Trim().Equals(""))
            {
                throw new Exception("Campo Complemento Professor Inválido para Cadastro");
            }
            if (professor.CpfProf == null || professor.CpfProf.Trim().Equals(""))
            {
                throw new Exception("Campo CPF Professor Inválido para Cadastro");
            }
            if (professor.DataNascProf == null || professor.DataNascProf.Trim().Equals(""))
            {
                throw new Exception("Campo Data Professor Inválido para Cadastro");
            }
            if (professor.LogradouroProf == null || professor.LogradouroProf.Trim().Equals(""))
            {
                throw new Exception("Campo Endereço Professor Inválido para Cadastro");
            }
            if (professor.IdProf == 0)
            {
               throw new Exception("Campo ID Professor Inválido para Cadastro");
           }
            if (professor.LoginProf == null || professor.LoginProf.Trim().Equals(""))
            {
                throw new Exception("Campo Login Professor Inválido para Cadastro");
            }
            if (professor.NumeroProf <= 0)
           {
              throw new Exception("Campo Numero Professor Inválido para Cadastro");
           }
            if (professor.RgProf == null || professor.RgProf.Trim().Equals(""))
            {
                throw new Exception("Campo RG Professor Inválido para Cadastro");
            }
            if (professor.SalarioProf == null || professor.SalarioProf.Trim().Equals(""))
            {
                throw new Exception("Campo Salario Professor Inválido para Cadastro");
            }
            if (professor.SenhaProf == null || professor.SenhaProf.Trim().Equals(""))
            {
                throw new Exception("Campo Senha Professor Inválido para Cadastro");
            }
            if (professor.UfProf == null || professor.UfProf.Trim().Equals(""))
            {
                throw new Exception("Campo UF Professor Inválido para Cadastro");
            }
            this.repositorioProfessor.cadastroProfessor(professor);
        }
        public void validarloginProfessor(Professor professor)
        {

            if (professor.SenhaProf == null || professor.SenhaProf.Trim().Equals(""))
            {
                throw new Exception("Campo Senha Professor Inválido para Login");
            }
            if (professor.LoginProf == null || professor.LoginProf.Trim().Equals(""))
            {
                throw new Exception("Campo Login Professor Inválido para Login");
            }

            this.repositorioProfessor.loginProfessor(professor);
        }
        public void validaratualizarProfessor(Professor professor)
        {


            if (professor.BairroProf == null || professor.BairroProf.Trim().Equals(""))
            {
                throw new Exception("Campo Bairro Professor Inválido para Atualizar");
            }
            if (professor.CidadeProf == null || professor.CidadeProf.Trim().Equals(""))
            {
                throw new Exception("Campo Cidade Professor Inválido para Atualizar");
            }
            if (professor.ComplementoProf == null || professor.ComplementoProf.Trim().Equals(""))
            {
                throw new Exception("Campo Complemento Professor Inválido para Atualizar");
            }
            if (professor.CpfProf == null || professor.CpfProf.Trim().Equals(""))
            {
                throw new Exception("Campo CPF Professor Inválido para Atualizar");
            }
            if (professor.DataNascProf == null || professor.DataNascProf.Trim().Equals(""))
            {
                throw new Exception("Campo Data Professor Inválido para Atualizar");
            }
            if (professor.LogradouroProf == null || professor.LogradouroProf.Trim().Equals(""))
            {
                throw new Exception("Campo Endereço Professor Inválido para Atualizar");
            }
            if (professor.IdProf == 0)
            {
                throw new Exception("Campo ID Professor Inválido para Atualizar");
            }
            if (professor.IdProfnova == 0)
            {
                throw new Exception("Campo ID Nova Professor Inválido para Atualizar");
            }
            if (professor.LoginProf == null || professor.LoginProf.Trim().Equals(""))
            {
                throw new Exception("Campo Login Professor Inválido para Atualizar");
            }
            if (professor.NumeroProf <= 0)
            {
                throw new Exception("Campo Numero Professor Inválido para Atualizar");
            }
            if (professor.RgProf == null || professor.RgProf.Trim().Equals(""))
            {
                throw new Exception("Campo RG Professor Inválido para Atualizar");
            }
            if (professor.SalarioProf == null || professor.SalarioProf.Trim().Equals(""))
            {
                throw new Exception("Campo Salario Professor Inválido para Atualizar");
            }
            if (professor.SenhaProf == null || professor.SenhaProf.Trim().Equals(""))
            {
                throw new Exception("Campo Senha Professor Inválido para Atualizar");
            }
            if (professor.UfProf == null || professor.UfProf.Trim().Equals(""))
            {
                throw new Exception("Campo UF Professor Inválido para Atualizar");
            }
            this.repositorioProfessor.VerificaProfessorExistenteAtualizar(professor);
        }
    }
}
