using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using projetoXNET.basica;
using projetoXNET.repositorio;

namespace projetoXNET.Negocio1
{
    public class NegocioFrequencia
    {
        RepositorioFrequencia repositorioFrequencia = new RepositorioFrequencia();
        public Frequencia validarvisualizarfrequencia(Frequencia frequencia)
        {

            if (frequencia.IdAlunfre.IdAluno <= 0)
            {
                throw new Exception("Campo da Aluna Inválido para Visualizar");
            }
            if (frequencia.IdDisciplinafre.IdDisc <= 0)
            {
                throw new Exception("Campo da Disciplina Inválido para Visualizar");
            }
            return this.repositorioFrequencia.visualizarfrequencia(frequencia);

        }
        public void validarcadastrarfrequencia(Frequencia frequencia)
        {

            if (frequencia.IdAlunfre.IdAluno <= 0)
            {
                throw new Exception("Campo da Aluna Inválido para Cadastrar");
            }
            if (frequencia.IdDisciplinafre.IdDisc <= 0)
            {
                throw new Exception("Campo da Disciplina Inválido para Cadastrar");
            }
            if (frequencia.Faltas <= 0)
            {
                throw new Exception("Campo da Faltas Inválido para Cadastrar");
            }
            this.repositorioFrequencia.cadastrarfrequencia(frequencia);

        }
    }
}
