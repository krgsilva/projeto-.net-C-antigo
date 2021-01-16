using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoXNET.basica;
using projetoXNET.gui;
using projetoXNET.repositorio;


namespace projetoXNET.Negocio1
{
    class NegocioAluna
    {
        RepositorioAluna repositorioAluna = new RepositorioAluna();


        public void validarRemocaoAluna(Aluno aluna)
        {



            if (aluna.IdAluno <= 0)
            {
                throw new Exception("Campo da Aluna Inválido para Remover");
            }
            this.repositorioAluna.VerificaALUNOExistenteRemover(aluna);

        }
        public void validarcadastroAluna(Aluno aluna)
        {


            if (aluna.BairroAluno == null || aluna.BairroAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Bairro Aluna Inválido para Cadastro");
            }
            if (aluna.CidadeAluno == null || aluna.CidadeAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Cidade Aluna Inválido para Cadastro");
            }
            if (aluna.Comple == null || aluna.Comple.Trim().Equals(""))
            {
                throw new Exception("Campo Complemento Aluna Inválido para Cadastro");
            }
            if (aluna.CpfAluno == null ||aluna.CpfAluno.Trim().Equals(""))
            {
                throw new Exception("Campo CPF Aluna Inválido para Cadastro");
            }
            if (aluna.DmaAluno == null || aluna.DmaAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Data Aluna Inválido para Cadastro");
            }
            if (aluna.EnderecoAluno == null || aluna.EnderecoAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Endereço Aluna Inválido para Cadastro");
            }
            if (aluna.IdAluno <= 0)
            {
                throw new Exception("Campo ID Aluna Inválido para Cadastro");
            }
            if (aluna.Curso == null)
            {
                throw new Exception("Campo ID Curso de  Aluna Inválido para Cadastro");
            }
            if (aluna.Turma == null)
            {
                throw new Exception("Campo ID Turma de  Aluna Inválido para Cadastro");
            }
            if (aluna.LoginAluno == null || aluna.LoginAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Login de  Aluna Inválido para Cadastro");
            }
            if (aluna.NomelAuno == null || aluna.NomelAuno.Trim().Equals(""))
            {
                throw new Exception("Campo Nome de  Aluna Inválido para Cadastro");
            }
            if (aluna.Numero <= 0)
            {
                throw new Exception("Campo Numero de  Aluna Inválido para Cadastro");
            }
            if (aluna.RgAluno == null || aluna.RgAluno.Trim().Equals(""))
            {
                throw new Exception("Campo RG de  Aluna Inválido para Cadastro");
            }
            if (aluna.SenhaAluno == null || aluna.SenhaAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Senha de  Aluna Inválido para Cadastro");
            }
            if (aluna.UfAluno == null || aluna.UfAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Estado de  Aluna Inválido para Cadastro");
            }
            this.repositorioAluna.cadastroAluna(aluna);

        }
        public void validaratualizarAluna(Aluno aluna)
        {


            if (aluna.BairroAluno == null || aluna.BairroAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Bairro Aluna Inválido para Cadastro");
            }
            if (aluna.CidadeAluno == null || aluna.CidadeAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Cidade Aluna Inválido para Cadastro");
            }
            if (aluna.Comple == null || aluna.Comple.Trim().Equals(""))
            {
                throw new Exception("Campo Complemento Aluna Inválido para Cadastro");
            }
            if (aluna.CpfAluno == null || aluna.CpfAluno.Trim().Equals(""))
            {
                throw new Exception("Campo CPF Aluna Inválido para Cadastro");
            }
            if (aluna.DmaAluno == null || aluna.DmaAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Data Aluna Inválido para Cadastro");
            }
            if (aluna.EnderecoAluno == null || aluna.EnderecoAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Endereço Aluna Inválido para Cadastro");
            }
            if (aluna.IdAluno <= 0)
            {
                throw new Exception("Campo ID Aluna Inválido para Cadastro");
            }
            if (aluna.Curso == null)
            {
                throw new Exception("Campo ID Curso de  Aluna Inválido para Cadastro");
            }
            if (aluna.Turma == null)
            {
                throw new Exception("Campo ID Turma de  Aluna Inválido para Cadastro");
            }
            if (aluna.LoginAluno == null || aluna.LoginAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Login de  Aluna Inválido para Cadastro");
            }
            if (aluna.NomelAuno == null || aluna.NomelAuno.Trim().Equals(""))
            {
                throw new Exception("Campo Nome de  Aluna Inválido para Cadastro");
            }
            if (aluna.Numero <= 0)
            {
                throw new Exception("Campo Numero de  Aluna Inválido para Cadastro");
            }
            if (aluna.IdAlunoNova <= 0)
            {
                throw new Exception("Campo ID nova de  Aluna Inválido para Cadastro");
            }
            if (aluna.RgAluno == null || aluna.RgAluno.Trim().Equals(""))
            {
                throw new Exception("Campo RG de  Aluna Inválido para Cadastro");
            }
            if (aluna.SenhaAluno == null || aluna.SenhaAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Senha de  Aluna Inválido para Cadastro");
            }
            if (aluna.UfAluno == null || aluna.UfAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Estado de  Aluna Inválido para Cadastro");
            }
            this.repositorioAluna.VerificaALUNOExistenteatualizar(aluna);

        }
        public void validarloginAluna(Aluno aluna)
        {


            if (aluna.LoginAluno == null || aluna.LoginAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Login de  Aluna Inválido para Login");
            }
            if (aluna.SenhaAluno == null || aluna.SenhaAluno.Trim().Equals(""))
            {
                throw new Exception("Campo Senha de  Aluna Inválido para Login");
            }
            this.repositorioAluna.loginAluna(aluna);

        }
        public void validarListarAluno(Aluno aluna)
        {

            if (aluna.Curso == null)
            {
                throw new Exception("Campo ID Curso de  Aluna Inválido para Cadastro");
            }
            if (aluna.Turma == null)
            {
                throw new Exception("Campo ID Turma de  Aluna Inválido para Cadastro");
            }
           //this.repositorioAluna.ListarAlunospainelprof(aluna);

        }
    }
}

