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
    public partial class RemoverAluno2 : Form
    {
        public RemoverAluno2()
        {
            InitializeComponent();
            #region ListaID's turma,curso e Aluno
            try
            {
                RepositorioAluna a = new RepositorioAluna();
                listaA = a.listaaluno();
                comboidalun.Items.Clear();
                for (int i = 0; i < listaA.Count; i++)
                {
                    comboidalun.Items.Add(listaA.ElementAt(i).NomelAuno);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Lista Id's do aluno" + ex + "");
            }
            #endregion

        }
        Fachada fachada = new Fachada();
        List<Aluno> listaA = new List<Aluno>();
        private void RemoverAluno2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();
                aluno.IdAluno = listaA.ElementAt(comboidalun.SelectedIndex).IdAluno;
                fachada.removerAluna(aluno);
                RepositorioAluna r = new RepositorioAluna();
                if (r.verificausuario == false)
                {
                    MessageBox.Show("Aluno removido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aluno nao removido" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
