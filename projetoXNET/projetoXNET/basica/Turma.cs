using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoXNET
{
    public class Turma
    {
        private int idTurmaNova;

        public int IdTurmaNova
        {
            get { return idTurmaNova; }
            set { idTurmaNova = value; }
        }
        
        private int idTurma;

        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }
        private String nomeTurma;

        public String NomeTurma
        {
            get { return nomeTurma; }
            set { nomeTurma = value; }
        }
        private String turnoTurma;

        public String TurnoTurma
        {
            get { return turnoTurma; }
            set { turnoTurma = value; }
        }


    }
}
