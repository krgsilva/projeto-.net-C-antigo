using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoXNET.fachada;
using projetoXNET.repositorio;

namespace projetoXNET.FormsRemover
{
    public partial class RemoverTurma : Form
    {
        public RemoverTurma()
        {
            InitializeComponent();
            #region ListaID's turma
            try
            {
                RepositorioTurma s = new RepositorioTurma();
                listaT = s.listaturma();
                comboidturma.Items.Clear();
                for (int i = 0; i < listaT.Count; i++)
                {
                    comboidturma.Items.Add(listaT.ElementAt(i).NomeTurma);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Lista Id's do Turma" + ex + "");
            }
            #endregion
        }
        Fachada fachada = new Fachada();
        List<Turma> listaT = new List<Turma>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Turma turma = new Turma();
                turma.IdTurma = listaT.ElementAt(comboidturma.SelectedIndex).IdTurma;
                fachada.removerTurma(turma);
                RepositorioTurma s = new RepositorioTurma();
                if (s.verificausuario == false)
                {
                    MessageBox.Show("Turma removido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Turma nao removido" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void textTuId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;

        }
    }
}
