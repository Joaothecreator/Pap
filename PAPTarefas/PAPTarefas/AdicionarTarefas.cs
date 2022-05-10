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
    public partial class AdicionarTarefas : Form
    {
        public AdicionarTarefas()
        {
            InitializeComponent();
        }

        private void btnGravarTarefas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtAddTarefa.Text))
            {
                MessageBox.Show("Tem de inserir uma tarefa.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtAddPontos.Text))
            {
                MessageBox.Show("Tem de atribuir uma pontuação.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlCeConnection con = new
            SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
            con.Open();
            string query = "INSERT INTO Tarefas (" +
                "Tarefa,Pontos)" +
                "VALUES (@Tarefa,@Pontos)";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@Tarefa", TxtAddTarefa.Text);
            cmd.Parameters.AddWithValue("@Pontos", TxtAddPontos.Text);
            cmd.ExecuteScalar();
            con.Close();
            if (MessageBox.Show("Tarefa inserida",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question) ==
                DialogResult.OK)
            {
                clsAreaTransf.valor = TxtAddTarefa.Text;
                this.Close();
            }
        }
    }
}
