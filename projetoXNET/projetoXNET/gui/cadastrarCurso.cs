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

namespace projetoxnet.gui
{
    public partial class cadastrarCurso : Form
    {
        public cadastrarCurso()
        {
            InitializeComponent();
        }
        Fachada fachada = new Fachada();
        private void tbid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = new Curso();
                curso.IdCurso = Convert.ToInt32(tbid.Text);
                curso.NomeCurso = tbnome.Text;
                curso.DuracaoCurso = tbduracao.Text;
                curso.InicioCurso = tbinicio.Text;
                curso.TerminoCurso = tbtermino.Text;
                curso.ValorCurso = tbvalor.Text;
                    fachada.cadastrarCurso(curso);
                    MessageBox.Show("Curso cadastrado com sucesso!!!","Atencao",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Cadastro do Curso  : "+ex+"", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
