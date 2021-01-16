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

namespace projetoXNET.gui
{
    public partial class AtualizarProfessor : Form
    {
        public AtualizarProfessor()
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
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = new Professor();
                professor.NomeProf = tbnome.Text;
                professor.RgProf = tbrg.Text;
                professor.CpfProf = tbcpf.Text;
                professor.DataNascProf = tbdma.Text;
                professor.LogradouroProf = tbendereco.Text;
                professor.ComplementoProf = tbnumero.Text;
                professor.UfProf = tbuf.Text;
                professor.BairroProf = tbbairro.Text;
                professor.CidadeProf = tbcidade.Text;
                professor.LoginProf = tblogin.Text;
                professor.SenhaProf = tbsenha.Text;
                professor.SalarioProf = tbsalario.Text;
                professor.ComplementoProf = tbcomplemetno.Text;
                professor.IdProf = listaF.ElementAt(comboidprof.SelectedIndex).IdProf;
                professor.IdProfnova = Convert.ToInt32(tbidnova.Text);
                professor.NumeroProf = Convert.ToInt32(tbnumero.Text);
                fachada.atualizarProfessor(professor);
                RepositorioProfessor r = new RepositorioProfessor();
                if (r.verificausuario == false)
                {
                    MessageBox.Show("Professor Atualizado com Sucesso");
                }
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show("Professor nao Atualizado" + ex);
            }
        }

        private void tbidantiga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void tbidnova_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
    }
}
