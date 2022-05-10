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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void btnGravarEdit_Click(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
            con.Open();
            string query = "UPDATE Distribuicao SET " +
                "Nome=@Nome" +
                "Tarefa=@Tarefa," +
                "Data=@Data" +
                " where ID=@ID";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", TxtID.Text);
            cmd.Parameters.AddWithValue("@Nome", CmbEditarDistribResp.Text);
            cmd.Parameters.AddWithValue("@Tarefa", CmbEditarDistribTarefas.Text);
            cmd.Parameters.AddWithValue("@Data", dateTimePicker1.Text);           
            cmd.ExecuteScalar();
            MessageBox.Show("Tarefa editada.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            this.Close();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            TxtID.Text = clsAreaTransf.valor;
            CmbEditarDistribResp.Text = clsAreaTransf.valor2;
            dateTimePicker1.Value = Convert.ToDateTime(clsAreaTransf.valor4);
            CmbEditarDistribTarefas.Text = clsAreaTransf.valor3;

            InserirCMBB();

            InserirCMBB2();
        }
        private void InserirCMBB()
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
            con.Open();
            string query = "select Nome from Autores ";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbEditarDistribResp.Items.Add(dr["Nome"].ToString());
            }
        }

        private void InserirCMBB2()
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
            con.Open();
            string query = "select Tarefa from Tarefas ";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbEditarDistribTarefas.Items.Add(dr["Tarefa"].ToString());
            }
        }

        private void CmbEditarDistribResp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbEditarDistribResp.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CmbEditarDistribResp_Enter(object sender, EventArgs e)
        {
            CmbEditarDistribResp.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmbEditarDistribTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbEditarDistribTarefas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmbEditarDistribTarefas_Enter(object sender, EventArgs e)
        {
            CmbEditarDistribTarefas.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
