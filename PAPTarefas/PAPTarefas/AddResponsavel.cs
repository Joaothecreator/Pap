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
    public partial class AddResponsavel : Form
    {
        public AddResponsavel()
        {
            InitializeComponent();
        }

        private void btnGravarResp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Tem de inserir um nome.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlCeConnection con = new
            SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
            con.Open();
            string query = "INSERT INTO Autores (Nome) VALUES (@Nome)";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", textBox2.Text); 
            cmd.ExecuteScalar();
            con.Close();
            if (MessageBox.Show("Responsável inserido",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question) ==
                DialogResult.OK)
            {
                clsAreaTransf.valor = textBox2.Text;
                this.Close();
            }           
        }

        private void AddResponsavel_Load(object sender, EventArgs e)
        {

        }
    }
}
