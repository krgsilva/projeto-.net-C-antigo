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
    public partial class cadastrarTurma : Form
    {
        public cadastrarTurma()
        {
            InitializeComponent();
        }
        Fachada fachada = new Fachada();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            Turma turma = new Turma();
            turma.IdTurma = Convert.ToInt32(tbid.Text);
            turma.NomeTurma = tbturma.Text;
            turma.TurnoTurma = comboturno.Text;
            fachada.cadastrarTurma(turma);
            MessageBox.Show("Turma cadastrada com sucesso!!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Turma nao cadastrado." + ex.Message);
            }
        }

        private void tbid_KeyPress(object sender, KeyPressEventArgs e)
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
