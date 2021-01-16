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
    public partial class PainelAluno : Form
    {
        public PainelAluno()
        {
            InitializeComponent();
            #region ListaID's turma,curso e Aluno
            try
            {
                RepositorioAluna a = new RepositorioAluna();
                listaA = a.listaaluno();
                comboidaluno.Items.Clear();
                for (int i = 0; i < listaA.Count; i++)
                {
                    comboidaluno.Items.Add(listaA.ElementAt(i).NomelAuno);
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

                MessageBox.Show("Erro no Lista Id's do Disciplina e aluno" + ex + "");
            }
            #endregion

        }
        Fachada fachada = new Fachada();
        List<Aluno> listaA = new List<Aluno>();
        List<Disciplina> listaD = new List<Disciplina>();
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Frequencia frequencia = new Frequencia();
                frequencia.IdAlunfre = listaA.ElementAt(comboidaluno.SelectedIndex);
                frequencia.IdDisciplinafre = listaD.ElementAt(comboiddisciplina.SelectedIndex);
                frequencia = fachada.visualizarFrequencia(frequencia);
                RepositorioFrequencia r = new RepositorioFrequencia();
               // if(r.temfaltas == true)
                //{
                MessageBox.Show("Numero de Faltas : " + frequencia.Faltas + "");
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro na Visualização de Faltas" + ex + "");
            }
        }

        private void tbiddisciplina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
