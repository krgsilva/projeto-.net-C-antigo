using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetoXNET;
using projetoXNET.basica;
using projetoXNET.fachada;
using projetoXNET.repositorio;

namespace projetoxnet.gui
{
    public partial class cadastrarDisciplina : Form
    {
        public cadastrarDisciplina()
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
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           try {
            Disciplina disciplina = new Disciplina();
            disciplina.Prof = listaF.ElementAt(comboidprof.SelectedIndex);
            disciplina.NomeDisc = tbnome.Text;
            disciplina.HoraEntradaDisc = tbhorarioentrada.Text;
            disciplina.HoraSaidaDisc = tbhorariosaida.Text;
            disciplina.IdDisc = Convert.ToInt32(tbiddisciplina.Text);
            disciplina.CargaHorDisc = Convert.ToInt32(tbcargahoraria.Text);
            fachada.cadastrarDisciplina(disciplina);
            MessageBox.Show("Disciplina cadastrada com sucesso!!!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Cadastro da Disciplina  : "+ex+"", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastrarDisciplina_Load(object sender, EventArgs e)
        {

        }
    }
}
