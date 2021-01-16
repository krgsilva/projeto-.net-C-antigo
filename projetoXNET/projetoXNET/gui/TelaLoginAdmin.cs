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
    public partial class TelaLoginAdmin : Form
    {
        public TelaLoginAdmin()
        {
            InitializeComponent();
        }
        Fachada fachada = new Fachada();
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Administrador administrador = new Administrador();
                administrador.Login = tblogin.Text;
                administrador.Senha = tbsenha.Text;
                fachada.loginAdministrador(administrador);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no Login do Sistema :" + ex.Message);
            }
            
        }
    }
}
