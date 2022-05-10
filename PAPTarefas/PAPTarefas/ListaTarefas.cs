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
    public partial class ListaTarefas : Form
    {
        private int iCodigo = -1;
        public ListaTarefas()
        {
            InitializeComponent();
        }
        
        string filtro = "select IDTaref, Tarefa, Pontos from Tarefas";

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
                dataGridViewListaTarefas.DataSource = bs;
                con.Close();
            }
        }

        private void ListaTarefas_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void FormataDataGrid()

        {
            // proteger a grid contra escrita
            dataGridViewListaTarefas.ReadOnly = true;
            // retirar linha de AddNew
            dataGridViewListaTarefas.AllowUserToAddRows = false;
            // retirar cabeçalho das linhas 
            dataGridViewListaTarefas.RowHeadersVisible = false;

            // para centrar os títulos da grid            
            dataGridViewListaTarefas.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            //// para colocar a negrito os títulos da grid
            dataGridViewListaTarefas.ColumnHeadersDefaultCellStyle.Font =
                new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // alterar títulos colunas
            //dataGridView1.Columns[0].HeaderText = "aaaa";

            // alinhar colunas ao centro
            dataGridViewListaTarefas.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[5].DefaultCellStyle.Alignment =
            //DataGridViewContentAlignment.MiddleCenter;

            // formatar data
            //dataGridView1.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewListaTarefas.Columns[0].Visible = false;


            // Editar o RowTemplate diretamente nas propriedades para
            // Font (DefaultCellStyle) e altura das linhas (Heigh)

            // alterar largura de colunas
            //dataGridView1.Columns[1].Width = 300;
            //dataGridView1.Columns[4].Width = 300;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefass.sdf");
           //con.Open();
            //string query = "UPDATE Responsaveis SET " +
                //"Nome=@Nome " +
               // " where Nome=@Nome";
           // SqlCeCommand cmd = new SqlCeCommand(query, con);
           // cmd.Parameters.AddWithValue("@Nome", textBox2.Text);

          //  cmd.ExecuteScalar();
          //  MessageBox.Show("Registo editado.", "Informação",
         //       MessageBoxButtons.OK, MessageBoxIcon.Information);

          //  con.Close();
            //this.Close();

            //if (clsAreaTransf.valor.Length == 0)
            // {
            //     MessageBox.Show("Tem de selecionar o registo que pretende editar.",
            //        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //     return;
            //  }

            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            EditarTarefas form = new EditarTarefas();
            form.ShowDialog();
        }

        private void BtnAddTarefa_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            AdicionarTarefas form = new AdicionarTarefas();
            form.ShowDialog();
        }

        private void dataGridViewListaTarefas_Click(object sender, EventArgs e)
        {
            clsAreaTransf.valor3 = dataGridViewListaTarefas.CurrentRow.Cells[0].Value.ToString();

            clsAreaTransf.valor5 = dataGridViewListaTarefas.CurrentRow.Cells[1].Value.ToString();

            FormataDataGrid();
        }

        private void ListaTarefas_Activated(object sender, EventArgs e)
        {
            CarregaDataGrid();
            FormataDataGrid();
        }

        private void BtnEliminarTarefas_Click(object sender, EventArgs e)
        {
             if (iCodigo != -1)
            {
                if (MessageBox.Show("Prosseguir e eliminar registo " + dataGridViewListaTarefas.CurrentRow.Cells[1].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
                    con.Open();
                    string query = "DELETE   Tarefas   where IDTaref = " + iCodigo;
                    SqlCeCommand cmd = new SqlCeCommand(query, con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
                CarregaDataGrid();
            }
        }

        private void dataGridViewListaTarefas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListaTarefas.SelectedRows.Count > 0)
            {
                iCodigo = Convert.ToInt32(dataGridViewListaTarefas.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
