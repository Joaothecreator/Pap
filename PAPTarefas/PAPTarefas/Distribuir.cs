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
    public partial class Distribuir : Form
    {
        public Distribuir()
        {
            InitializeComponent();
        }

        private void InserirCMB()
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
            con.Open();
            string query = "select Nome from Autores ";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Nome"].ToString());
            }
        }

        private void InserirCMB2()
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
            con.Open();
            string query = "select Tarefa from Tarefas ";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Tarefa"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(BtnGravarDistribuicao.Text))
                {
                    MessageBox.Show("Tem de atribuir uma tarefa.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SqlCeConnection con = new
                SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
                con.Open();
                string query = "INSERT INTO Distribuicao(" +
                "Nome,Tarefa,Data)" +
                "VALUES (@Nome,@Tarefa,@Data)";
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Data", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@Tarefa", comboBox2.Text);
                cmd.ExecuteScalar();
                MessageBox.Show("Tarefa atribuida.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                {
                    clsAreaTransf.valor = BtnGravarDistribuicao.Text;
                    con.Close();
                    this.Close();
                }
            }
        }
        private void Distribuir_Load(object sender, EventArgs e)
        {
            InserirCMB();

            InserirCMB2();
        }

    }
}
