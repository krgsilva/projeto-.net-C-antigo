using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoxnet.gui;
using projetoXNET.FormsRemover;

namespace projetoXNET.gui
{
    public partial class PainelAdmin : Form
    {
        public PainelAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrarAluno l = new cadastrarAluno();
            l.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastrarCurso l = new cadastrarCurso();
            l.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadastrarDisciplina l = new cadastrarDisciplina();
            l.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cadastrarProfessor l = new cadastrarProfessor();
            l.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cadastrarTurma l = new cadastrarTurma();
            l.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AtualizarAluno l = new AtualizarAluno();
            l.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AtualizarCurso l = new AtualizarCurso();
            l.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AtualizarDisciplina l = new AtualizarDisciplina();
            l.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AtualizarProfessor l = new AtualizarProfessor();
            l.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AtualizarTurma l = new AtualizarTurma();
            l.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RemoverAluno2 l = new RemoverAluno2();
            l.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RemoverCurso l = new RemoverCurso();
            l.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RemoverDisciplina l = new RemoverDisciplina();
            l.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RemoverProfessor l = new RemoverProfessor();
            l.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RemoverTurma l = new RemoverTurma();
            l.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
