using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoXNET;
using projetoXNET.fachada;

namespace projetoxnet.gui
{
    public partial class cadastrarProfessor : Form
    {
        public cadastrarProfessor()
        {
            InitializeComponent();
        }
        Fachada fachada = new Fachada();

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
                professor.IdProf = Convert.ToInt32(tbid.Text);
                professor.NumeroProf = Convert.ToInt32(tbnumero.Text);
                fachada.cadastrarProfessor(professor);
                MessageBox.Show("Professor foi Cadastrado!!!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Professor nao Cadastrado." + ex , "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void tbcpf_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void tbsalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
