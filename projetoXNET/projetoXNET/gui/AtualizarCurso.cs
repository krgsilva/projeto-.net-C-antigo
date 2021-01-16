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
    public partial class AtualizarCurso : Form
    {
        public AtualizarCurso()
        {
            InitializeComponent();
            try
            {
                RepositorioCurso r = new RepositorioCurso();
                listaC = r.listacurso();
                comboidcurso.Items.Clear();
                for (int i = 0; i < listaC.Count; i++)
                {
                    comboidcurso.Items.Add(listaC.ElementAt(i).NomeCurso);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no Lista curso"+e+"");
            }
        }
        Fachada fachada = new Fachada();
        List<Curso> listaC = new List<Curso>();
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = new Curso();
                curso.IdCurso = listaC.ElementAt(comboidcurso.SelectedIndex).IdCurso;
                curso.IdNovoCurso = Convert.ToInt32(tbidnova.Text);
                curso.InicioCurso = tbinicio.Text;
                curso.NomeCurso = tbnome.Text;
                curso.TerminoCurso = tbtermino.Text;
                curso.ValorCurso = tbvalor.Text;
                curso.DuracaoCurso = tbduracao.Text;
                fachada.atualizarCurso(curso);
                RepositorioCurso r = new RepositorioCurso();
                if (r.verificurso == false)
                {
                    MessageBox.Show("Curso Alterado com Sucesso");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro na Alteração do Curso : "+ex+"");
            }
        }

        private void tbidantiga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
    }
}
