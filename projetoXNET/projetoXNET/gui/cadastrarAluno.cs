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
using System.Collections;
using projetoXNET;

namespace projetoxnet.gui
{
    public partial class cadastrarAluno : Form
    {
        public cadastrarAluno()
        {
            InitializeComponent();
            #region ListaID's turma e curso
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
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Lista Id's do Curso" + ex + "");
            } 
            #endregion
            
        }
          Fachada fachada = new Fachada();
          List<Curso> listaC = new List<Curso>();
          List<Turma> listaT = new List<Turma>();


        private void btcadastrar_Click(object sender, EventArgs e)
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
                aluna.IdAluno = Convert.ToInt32(tbid.Text);
                aluna.Curso =  listaC.ElementAt(combocurso.SelectedIndex);
                aluna.Turma = listaT.ElementAt(comboturma.SelectedIndex);
                fachada.cadastrarAluna(aluna);
                    MessageBox.Show("Aluno cadastrado com sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aluno nao cadastrado." + ex.Message);
            }
        }

        private void tbestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
    }
}
