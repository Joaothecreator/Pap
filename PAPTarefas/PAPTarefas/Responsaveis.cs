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
    public partial class Responsaveis : Form
    {
        private int iCodigo = -1;

        public Responsaveis()
        {
            InitializeComponent();
        }

        string filtro = "select ID, Nome from Autores";
        private void FormataDataGrid()

        {
            // proteger a grid contra escrita
            dataGridViewResponsaveis.ReadOnly = true;
            // retirar linha de AddNew
            dataGridViewResponsaveis.AllowUserToAddRows = false;
            // retirar cabeçalho das linhas 
            dataGridViewResponsaveis.RowHeadersVisible = false;

            // para centrar os títulos da grid            
            dataGridViewResponsaveis.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            //// para colocar a negrito os títulos da grid
            dataGridViewResponsaveis.ColumnHeadersDefaultCellStyle.Font =
                new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // alterar títulos colunas
            //dataGridView1.Columns[0].HeaderText = "aaaa";

            // alinhar colunas ao centro
            dataGridViewResponsaveis.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[5].DefaultCellStyle.Alignment =
            //DataGridViewContentAlignment.MiddleCenter;

            // formatar data
            dataGridViewResponsaveis.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

            dataGridViewResponsaveis.Columns[0].Visible = false;
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
                dataGridViewResponsaveis.DataSource = bs;
                con.Close();
            }
            FormataDataGrid();
        }

        private void BtnAddRespe_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            AddResponsavel form = new AddResponsavel();
            form.ShowDialog();
        }

        private void Responsaveis_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void Responsaveis_Activated(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void BtnRemoveResp_Click(object sender, EventArgs e)
        {
            if (iCodigo != -1)
            {
                if (MessageBox.Show("Prosseguir e eliminar registo " + dataGridViewResponsaveis.CurrentRow.Cells[1].Value.ToString() + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\Tarefas.sdf");
                    con.Open();
                    string query = "DELETE   Autores   where ID = " + iCodigo;
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

        private void dataGridViewResponsaveis_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewResponsaveis.SelectedRows.Count > 0)
            {
                iCodigo = Convert.ToInt32(dataGridViewResponsaveis.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
