using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoXNET.basica
{
    public class Aluno
    {
        private int idAlunoNova;

        public int IdAlunoNova
        {
            get { return idAlunoNova; }
            set { idAlunoNova = value; }
        }
        private int idAluno;

        public int IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }
        private Turma turma;

        public Turma Turma
        {
            get { return turma; }
            set { turma = value; }
        }
        private Curso curso;

        public Curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        private String nomelAuno;

        public String NomelAuno
        {
            get { return nomelAuno; }
            set { nomelAuno = value; }
        }
        private String dmaAluno;  //data de nascimento

        public String DmaAluno
        {
            get { return dmaAluno; }
            set { dmaAluno = value; }
        }
        private String rgAluno;

        public String RgAluno
        {
            get { return rgAluno; }
            set { rgAluno = value; }
        }
        private String cpfAluno;

        public String CpfAluno
        {
            get { return cpfAluno; }
            set { cpfAluno = value; }
        }
        private int matriculaAluno;

        public int MatriculaAluno
        {
            get { return matriculaAluno; }
            set { matriculaAluno = value; }
        }
        private String enderecoAluno;

        public String EnderecoAluno
        {
            get { return enderecoAluno; }
            set { enderecoAluno = value; }
        }
        private String ufAluno;

        public String UfAluno
        {
            get { return ufAluno; }
            set { ufAluno = value; }
        }
        private String bairroAluno;

        public String BairroAluno
        {
            get { return bairroAluno; }
            set { bairroAluno = value; }
        }
        private String cidadeAluno;

        public String CidadeAluno
        {
            get { return cidadeAluno; }
            set { cidadeAluno = value; }
        }
        private String loginAluno;

        public String LoginAluno
        {
            get { return loginAluno; }
            set { loginAluno = value; }
        }
        private String senhaAluno;

        public String SenhaAluno
        {
            get { return senhaAluno; }
            set { senhaAluno = value; }
        }
        private String comple;

        public String Comple
        {
            get { return comple; }
            set { comple = value; }
        }

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Aluno()
        {
            curso = new Curso();
            turma = new Turma();
        }
        
    }
}
