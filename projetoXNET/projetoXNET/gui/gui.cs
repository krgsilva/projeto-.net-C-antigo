using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetoXNET.gui
{
    public partial class gui : Form
    {
        public gui()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Telaloginprof l = new Telaloginprof();
            l.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLoginAluno l = new TelaLoginAluno();
            l.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaLoginAdmin l = new TelaLoginAdmin();
            l.ShowDialog();
        }
    }
}
