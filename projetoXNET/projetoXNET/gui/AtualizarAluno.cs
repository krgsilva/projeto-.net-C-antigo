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
    public partial class AtualizarAluno : Form
    {
        public AtualizarAluno()
        {
            InitializeComponent();
            #region ListaID's turma,curso e Aluno
            try
            {
                RepositorioCurso r = new RepositorioCurso();
                listaC = r.listacurso();
                combocurso.Items.Clear();
                for (int i = 0; i < listaC.Count; i++)
                {
                    combocurso.Items.Add(listaC.ElementAt(i).NomeCurso);
                }
                RepositorioTurma s = new RepositorioTurma();
                listaT = s.listaturma();
                comboturma.Items.Clear();
                for (int i = 0; i < listaT.Count; i++)
                {
                    comboturma.Items.Add(listaT.ElementAt(i).NomeTurma);
                }
                RepositorioAluna a = new RepositorioAluna();
                listaA = a.listaaluno();
                comboidaluno.Items.Clear();
                for (int i = 0; i < listaA.Count; i++)
                {
                    comboidaluno.Items.Add(listaA.ElementAt(i).NomelAuno);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Lista Id's do Curso,turma e aluno" + ex + "");
            }
            #endregion

        }
        Fachada fachada = new Fachada();
        List<Curso> listaC = new List<Curso>();
        List<Turma> listaT = new List<Turma>();
        List<Aluno> listaA = new List<Aluno>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluna = new Aluno();

                aluna.NomelAuno = tbnome.Text;
                aluna.RgAluno = tbrg.Text;
                aluna.CpfAluno = tbcpf.Text;
                aluna.DmaAluno = tbdata.Text;
                aluna.EnderecoAluno = tbendereco.Text.Trim();
                aluna.Numero = Convert.ToInt32(tbnumero.Text);
                aluna.UfAluno = tbestado.Text;
                aluna.BairroAluno = tbbairro.Text;
                aluna.CidadeAluno = tbcidade.Text;
                aluna.Comple = textcomple.Text;
                aluna.LoginAluno = tblogin.Text;
                aluna.SenhaAluno = tbsenha.Text;
                aluna.IdAluno = listaA.ElementAt(comboidaluno.SelectedIndex).IdAluno;
                aluna.IdAlunoNova = Convert.ToInt32(tbidnova.Text);
                aluna.Curso = listaC.ElementAt(combocurso.SelectedIndex);
                aluna.Turma = listaT.ElementAt(comboturma.SelectedIndex);
                fachada.atualizarAluna(aluna);
                RepositorioAluna r = new RepositorioAluna();
                if(r.verificausuario == false){
                MessageBox.Show("Aluno Atualizado com sucesso!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aluno nao Atualizado." + ex.Message);
            }
        }

        private void AtualizarAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
