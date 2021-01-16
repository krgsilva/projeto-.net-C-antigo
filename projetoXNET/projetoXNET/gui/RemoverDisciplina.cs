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

namespace projetoXNET.FormsRemover
{
    public partial class RemoverDisciplina : Form
    {
        public RemoverDisciplina()
        {
            #region ListaID's Professor
            try
            {
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

                MessageBox.Show("Erro no Lista Id's Disciplina" + ex + "");
            }
            #endregion
        }
        Fachada fachada = new Fachada();
        List<Disciplina> listaD = new List<Disciplina>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Disciplina disciplina = new Disciplina();
                disciplina.IdDisc = listaD.ElementAt(comboiddisciplina.SelectedIndex).IdDisc;
                fachada.removerDisciplina(disciplina);
                RespositorioDisciplina r = new RespositorioDisciplina();
                if (r.verificausuario == false)
                {
                    MessageBox.Show("Disciplina removido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Disciplina nao removido" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textDiId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
    }
}
