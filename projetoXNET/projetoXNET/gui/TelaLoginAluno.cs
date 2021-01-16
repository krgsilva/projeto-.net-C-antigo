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

namespace projetoXNET.gui
{
    public partial class TelaLoginAluno : Form
    {
        public TelaLoginAluno()
        {
            InitializeComponent();
        }
        Fachada fachada = new Fachada();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            Aluno aluna = new Aluno();
            aluna.LoginAluno = tblogin.Text;
            aluna.SenhaAluno = tbsenha.Text;
            fachada.loginAluna(aluna);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Login do Sistema :"+ex.Message);
            }           

        }
    }
}
