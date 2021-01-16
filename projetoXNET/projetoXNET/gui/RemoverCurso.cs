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

namespace projetoXNET
{
    public partial class RemoverCurso : Form
    {
        public RemoverCurso()
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
            catch (Exception ex)
            {

                MessageBox.Show("Erro Lista ID Curso"+ex+"");
            }
        }
        Fachada fachada = new Fachada();
        List<Curso> listaC = new List<Curso>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = new Curso();
                curso.IdCurso = listaC.ElementAt(comboidcurso.SelectedIndex).IdCurso;
                fachada.removerCurso(curso);
                RepositorioCurso r = new RepositorioCurso();
                if (r.verificurso == true)
                {
                    MessageBox.Show("Curso Removido com Sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Curso nao removido" + ex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textCuId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
    }
}
