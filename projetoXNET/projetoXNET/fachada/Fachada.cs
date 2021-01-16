
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using projetoXNET.basica;
using projetoXNET.Negocio1;

namespace projetoXNET.fachada
{
    public class Fachada
    {
        NegocioAluna negocioAluna = new NegocioAluna();
        NegocioProfessor negocioProfessor = new NegocioProfessor();
        NegocioCurso negocioCurso = new NegocioCurso();
        NegocioDisciplina negocioDisciplina = new NegocioDisciplina();
        NegocioTurma negocioTurma = new NegocioTurma();
        NegocioAdministrador negocioAdministrador = new NegocioAdministrador();
        NegocioFrequencia negocioFrequencia = new NegocioFrequencia();


        public void removerAluna(Aluno aluna)
        {
            this.negocioAluna.validarRemocaoAluna(aluna);

        }

        public void removerProfessor(Professor professor)
        {
            this.negocioProfessor.validarRemocaoProfessor(professor);

        }

        public void removerCurso(Curso curso)
        {
            this.negocioCurso.validarRemocaoCurso(curso);

        }

        public void removerDisciplina(Disciplina disciplina)
        {
            this.negocioDisciplina.validarRemocaoDisciplina(disciplina);

        }

        public void removerTurma(Turma turma)
        {
            this.negocioTurma.validarRemocaoTurma(turma);

        }

        public void cadastrarAluna(Aluno aluna)
        {
            this.negocioAluna.validarcadastroAluna(aluna);

        }
        public void cadastrarCurso(Curso curso)
        {
            this.negocioCurso.validarcadastroCurso(curso);

        }
        public void cadastrarProfessor(Professor professor)
        {
            this.negocioProfessor.validarcadastrarProfessor(professor);
        }

        public void cadastrarDisciplina(Disciplina disciplina)
        {
            this.negocioDisciplina.validarcadastrarDisciplina(disciplina);

        }
        public void cadastrarTurma(Turma turma)
        {
            this.negocioTurma.validarcadastroTurma(turma);

        }
        public void loginAluna(Aluno aluna)
        {
            this.negocioAluna.validarloginAluna(aluna);

        }
        public void loginProfessor(Professor professor)
        {
            this.negocioProfessor.validarloginProfessor(professor);
        }
        public void loginAdministrador(Administrador administrador)
        {
            this.negocioAdministrador.validarloginAdministrador(administrador);
        }
        public Frequencia visualizarFrequencia(Frequencia frequencia)
        {
            return this.negocioFrequencia.validarvisualizarfrequencia(frequencia);
        }
        public void cadastrarFrequencia(Frequencia frequencia)
        {
            this.negocioFrequencia.validarcadastrarfrequencia(frequencia);
        }
        public void listaraluno(Aluno aluna)
        {
            this.negocioAluna.validarListarAluno(aluna);

        }
        public void atualizarCurso(Curso curso)
        {
            this.negocioCurso.validaratualizarCurso(curso);

        }
        public void atualizarTurma(Turma turma)
        {
            this.negocioTurma.validarAtualizarTurma(turma);

        }
        public void atualizarProfessor(Professor professor)
        {
            this.negocioProfessor.validaratualizarProfessor(professor);

        }
        public void atualizarAluna(Aluno aluna)
        {
            this.negocioAluna.validaratualizarAluna(aluna);

        }
        public void atualizarDisciplina(Disciplina disciplina)
        {
            this.negocioDisciplina.validaratualizarDisciplina(disciplina);

        }

    }
}
