using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAPTarefas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnPrincipalTarefas_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            ListaTarefas form = new ListaTarefas();
            form.ShowDialog();
        }

        private void BtnPrincipalDistribuicao_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Tarefas form = new Tarefas();
            form.ShowDialog();
        }

        private void BtnPrincipalResponsaveis_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Responsaveis form = new Responsaveis();
            form.ShowDialog();
        }
    }
}
