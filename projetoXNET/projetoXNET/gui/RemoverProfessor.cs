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
    public partial class RemoverProfessor : Form
    {
        public RemoverProfessor()
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
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Lista Id's do Professor" + ex + "");
            }
            #endregion
        }
        Fachada fachada = new Fachada();
        List<Professor> listaF = new List<Professor>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = new Professor();
                professor.IdProf = listaF.ElementAt(comboidprof.SelectedIndex).IdProf;
                fachada.removerProfessor(professor);
                RepositorioProfessor r = new RepositorioProfessor();
                if (r.verificausuario == true)
                {
                    MessageBox.Show("Professor Removido com Sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Professor nao removido" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textPrId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
    }
}
