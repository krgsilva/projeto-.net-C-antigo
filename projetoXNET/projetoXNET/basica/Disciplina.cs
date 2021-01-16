using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoXNET.basica
{
    public class Disciplina
    {
        private int idDiscnova;

        public int IdDiscnova
        {
            get { return idDiscnova; }
            set { idDiscnova = value; }
        }
        private int idDisc;

        public int IdDisc
        {
            get { return idDisc; }
            set { idDisc = value; }
        }
        private String nomeDisc;

        public String NomeDisc
        {
            get { return nomeDisc; }
            set { nomeDisc = value; }
        }
        private String horaEntradaDisc;

        public String HoraEntradaDisc
        {
            get { return horaEntradaDisc; }
            set { horaEntradaDisc = value; }
        }
        private int cargaHorDisc;

        public int CargaHorDisc
        {
            get { return cargaHorDisc; }
            set { cargaHorDisc = value; }
        }
        private String horaSaidaDisc;

        public String HoraSaidaDisc
        {
            get { return horaSaidaDisc; }
            set { horaSaidaDisc = value; }
        }
        private Professor prof;

        public Professor Prof
        {
            get { return prof; }
            set { prof = value; }
        }

      

       
    }
}
