using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoXNET.basica
{
    public class Curso
    {
        private int idNovoCurso;

        public int IdNovoCurso
        {
            get { return idNovoCurso; }
            set { idNovoCurso = value; }
        }  
        private int idCurso;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }
        private String nomeCurso;

        public String NomeCurso
        {
            get { return nomeCurso; }
            set { nomeCurso = value; }
        }
        private String duracaoCurso;

        public String DuracaoCurso
        {
            get { return duracaoCurso; }
            set { duracaoCurso = value; }
        }
        private String terminoCurso;

        public String TerminoCurso
        {
            get { return terminoCurso; }
            set { terminoCurso = value; }
        }
        private String inicioCurso;

        public String InicioCurso
        {
            get { return inicioCurso; }
            set { inicioCurso = value; }
        }
        private String valorCurso;

        public String ValorCurso
        {
            get { return valorCurso; }
            set { valorCurso = value; }
        }
        




    }
}
