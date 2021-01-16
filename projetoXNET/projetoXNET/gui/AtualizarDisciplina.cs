using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoXNET.basica;
using projetoXNET.fachada;
using projetoXNET.repositorio;

namespace projetoXNET.gui
{
    public partial class AtualizarDisciplina : Form
    {
        public AtualizarDisciplina()
        {
            InitializeComponent();
            #region ListaID's Professor
            try
            {
                RepositorioProfessor r = new RepositorioProfessor();
                listaF = r.listaprofessor();
                comboidprof.Items.Clear();
                for (int i = 0; i < listaF.Count; i++)
                {
                    comboidprof.Items.Add(listaF.ElementAt(i).NomeProf);
                }
                RespositorioDisciplina s = new RespositorioDisciplina();
                listaD = s.listaDisciplina();
                comboiddisciplina.Items.Clear();
                for (int i = 0; i < listaD.Count; i++)
                {
                    comboiddisciplina.Items.Add(listaD.ElementAt(i).NomeDisc);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Lista Id's do Professor e Disciplina" + ex + "");
            }
            #endregion
        }
        Fachada fachada = new Fachada();
        List<Professor> listaF = new List<Professor>();
        List<Disciplina> listaD = new List<Disciplina>();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Disciplina disciplina = new Disciplina();
                disciplina.Prof = listaF.ElementAt(comboidprof.SelectedIndex);
                disciplina.IdDiscnova = Convert.ToInt32(tbidnova.Text);
                disciplina.IdDisc = listaD.ElementAt(comboiddisciplina.SelectedIndex).IdDisc;
                disciplina.NomeDisc = tbnome.Text;
                disciplina.HoraEntradaDisc = tbhorarioentrada.Text;
                disciplina.HoraSaidaDisc = tbhorariosaida.Text;
                disciplina.CargaHorDisc = Convert.ToInt32(tbcargahoraria.Text);
                fachada.atualizarDisciplina(disciplina);
                RespositorioDisciplina r = new RespositorioDisciplina();
                if(r.verificausuario == false){
                MessageBox.Show("Disciplina Atualizada com sucesso!!!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Atualizar da Disciplina  : " + ex + "", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizarDisciplina_Load(object sender, EventArgs e)
        {

        }
    }
}
