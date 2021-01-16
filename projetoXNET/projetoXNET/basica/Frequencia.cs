using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoXNET.basica
{
    public class Frequencia
    {
        private int faltas;

        public int Faltas
        {
            get { return faltas; }
            set { faltas = value; }
        }
        private Aluno idAlunfre;

        public Aluno IdAlunfre
        {
            get { return idAlunfre; }
            set { idAlunfre = value; }
        }
        private Disciplina idDisciplinafre;

        public Disciplina IdDisciplinafre
        {
            get { return idDisciplinafre; }
            set { idDisciplinafre = value; }
        }
        public Frequencia()
        {
            idDisciplinafre = new Disciplina();
            IdAlunfre = new Aluno();
    }
    }
}
