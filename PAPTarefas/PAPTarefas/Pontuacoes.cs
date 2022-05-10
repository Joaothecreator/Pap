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
    public partial class Pontuacoes : Form
    {
        public Pontuacoes()
        {
            InitializeComponent();
        }
        
            string filtro = "select Nome,Tarefas,Data from distribuicao";
            private void FormataDataGrid()

            {
                // proteger a grid contra escrita
                dataGridViewPontuacoes.ReadOnly = true;
            // retirar linha de AddNew
            dataGridViewPontuacoes.AllowUserToAddRows = false;
            // retirar cabeçalho das linhas 
            dataGridViewPontuacoes.RowHeadersVisible = false;

            // para centrar os títulos da grid            
            dataGridViewPontuacoes.ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            //// para colocar a negrito os títulos da grid
            dataGridViewPontuacoes.ColumnHeadersDefaultCellStyle.Font =
                    new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // alterar títulos colunas
            //dataGridView1.Columns[0].HeaderText = "aaaa";

            // alinhar colunas ao centro
            dataGridViewPontuacoes.Columns[1].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[5].DefaultCellStyle.Alignment =
            //DataGridViewContentAlignment.MiddleCenter;

            // formatar data
            dataGridViewPontuacoes.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";


                // Editar o RowTemplate diretamente nas propriedades para
                // Font (DefaultCellStyle) e altura das linhas (Heigh)

                // alterar largura de colunas
                //dataGridView1.Columns[1].Width = 300;
                //dataGridView1.Columns[4].Width = 300;
            }

            private void CarregaDataGrid() // liga à bd e carrega datagrid
            {
                using (SqlCeConnection con =
                    new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf"))
                {
                    DataTable dt = new DataTable();
                    BindingSource bs = new BindingSource();
                    string query = filtro;
                    SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridViewPontuacoes.DataSource = bs;
                    con.Close();
                }
            }
    }
}
