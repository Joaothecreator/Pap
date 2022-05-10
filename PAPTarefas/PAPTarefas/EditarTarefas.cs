using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
namespace PAPTarefas
{
    public partial class EditarTarefas : Form
    {
        public EditarTarefas()
        {
            InitializeComponent();
        }
        private void btnGravarTarefas_Click(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
            con.Open();
            string query = "UPDATE Tarefas SET " +
                "Tarefa=@Tarefa," +
                "Pontos=@Pontos" +
                " where IDTaref=@IDTaref";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@Tarefa", TxtEditTarefa.Text);
            cmd.Parameters.AddWithValue("@Pontos", TxtEditPontos.Text);


            cmd.ExecuteScalar();
            MessageBox.Show("Tarefa editada.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            this.Close();
        }

        private void EditarTarefas_Load(object sender, EventArgs e)
        {
            TxtEditTarefa.Text = clsAreaTransf.valor3;
            TxtEditPontos.Text = clsAreaTransf.valor5;

            

        }
    }
}
