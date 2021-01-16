using System;
using System.Collections;
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
    public partial class PainelProfessor : Form
    {
        public PainelProfessor()
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
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbidaluno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Frequencia frequencia = new Frequencia();
                frequencia.IdAlunfre = listaA.ElementAt(comboidaluno.SelectedIndex);
                frequencia.IdDisciplinafre = listaD.ElementAt(comboiddisciplina.SelectedIndex);
                frequencia.Faltas = Convert.ToInt32(tbfaltas.Text);
                fachada.cadastrarFrequencia(frequencia);
                MessageBox.Show("Frequencia Cadastrada com sucesso!!!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Postar Frequencia :" + ex + " ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  try
            {
                listView1.Items.Clear();
                Aluno aluna = new Aluno();
                aluna.Curso.IdCurso = Convert.ToInt32(tbcurso.Text);
                aluna.Turma.IdTurma = Convert.ToInt32(tbturma.Text);
                fachada.listaraluno(aluna);
                RepositorioAluna r = new RepositorioAluna();
                r.ListarAlunospainelprof(listView1,aluna);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Lista Painel professor"+ex+"");
            }*/
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
