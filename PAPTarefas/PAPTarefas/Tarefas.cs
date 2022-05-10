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
    public partial class Tarefas : Form
    {
        public Tarefas()
        {
            InitializeComponent();
        }

        string filtro = "select ID,Nome,Distribuicao.Tarefa,Pontos,Data from Distribuicao,Tarefas where Distribuicao.Tarefa=Tarefas.Tarefa";

        public object ToolStripTextBoxPesquisa { get; private set; }

        private void FormataDataGrid()

        {
            // proteger a grid contra escrita
            dataGridViewPrincipal.ReadOnly = true;
            // retirar linha de AddNew
            dataGridViewPrincipal.AllowUserToAddRows = false;
            // retirar cabeçalho das linhas 
            dataGridViewPrincipal.RowHeadersVisible = false;

            // para centrar os títulos da grid            
            dataGridViewPrincipal.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            //// para colocar a negrito os títulos da grid
            dataGridViewPrincipal.ColumnHeadersDefaultCellStyle.Font =
                new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // alterar títulos colunas
            //dataGridView1.Columns[0].HeaderText = "aaaa";

            // alinhar colunas ao centro
            dataGridViewPrincipal.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPrincipal.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dataGridViewPrincipal.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dataGridViewPrincipal.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[5].DefaultCellStyle.Alignment =
            //DataGridViewContentAlignment.MiddleCenter;

            // formatar data
            dataGridViewPrincipal.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
         
            // Editar o RowTemplate diretamente nas propriedades para
            // Font (DefaultCellStyle) e altura das linhas (Heigh)

             // alterar largura de colunas
            dataGridViewPrincipal.Columns[0].Width = 40;
            //dataGridView1.Columns[4].Width = 300;
        }
    private void dataGridViewPrincipal_SizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPrincipal.Rows)
            {
                row.Height = (dataGridViewPrincipal.ClientRectangle.Height - dataGridViewPrincipal.ColumnHeadersHeight) / dataGridViewPrincipal.Rows.Count;
            }
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
                dataGridViewPrincipal.DataSource = bs;
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            CarregaDataGrid();
            FormataDataGrid();
            toolStripStatusLabelTarefas.Text = "Total de tarefas: " + dataGridViewPrincipal.RowCount.ToString();

            // copia o Nome selecionado para criar novo serviço
            clsAreaTransf.valor = dataGridViewPrincipal.CurrentRow.Cells[0].Value.ToString();

            // copia o Data selecionado para criar novo serviço
            clsAreaTransf.valor2 = dataGridViewPrincipal.CurrentRow.Cells[1].Value.ToString();

            // copia o Tarefa selecionado para criar novo serviço
            clsAreaTransf.valor3 = dataGridViewPrincipal.CurrentRow.Cells[2].Value.ToString();

            clsAreaTransf.valor4 = dataGridViewPrincipal.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAdicionarTaref_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Distribuir form = new Distribuir();
            form.ShowDialog();
        }

        private void btnEditarTaref_Click(object sender, EventArgs e)
        {
            if (clsAreaTransf.valor.Length == 0)
            {
                MessageBox.Show("Tem de selecionar o registo que pretende editar.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Editar form = new Editar();
            form.ShowDialog();
            dataGridViewPrincipal.RowCount.ToString();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
           
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            ListaTarefas form = new ListaTarefas();
            form.ShowDialog();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnResponsaveis_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Responsaveis form = new Responsaveis();
            form.ShowDialog();
        }

        private void BtnPontuacao_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Pontuacoes form = new Pontuacoes();
            form.ShowDialog();
        }

        private void Tarefas_Activated(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            filtro = "select * from Distribuicao where Nome like '%" +
                toolStripTextBoxPesquisa.Text + "%' order by Nome";

            CarregaDataGrid();
            toolStripStatusLabelTarefas.Text = "Total de tarefas: " + dataGridViewPrincipal.RowCount.ToString();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            filtro = "select * from Distribuicao";
            CarregaDataGrid();
            toolStripStatusLabelTarefas.Text = "Total de tarefas: " + dataGridViewPrincipal.RowCount.ToString();
            toolStripTextBoxPesquisa.Text = "";
            
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Distribuir form = new Distribuir();
            form.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Editar form = new Editar();
            form.ShowDialog();

        }

        private void toolStripResponsaveis_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            Responsaveis form = new Responsaveis();
            form.ShowDialog();
        }

        private void toolStripTarefas_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //cursor em espera
            ListaTarefas form = new ListaTarefas();
            form.ShowDialog();
        }


        private void dataGridViewPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            clsAreaTransf.valor = dataGridViewPrincipal.CurrentRow.Cells[0].Value.ToString();

            // copia o Data selecionado para criar novo serviço
            clsAreaTransf.valor2 = dataGridViewPrincipal.CurrentRow.Cells[1].Value.ToString();

            // copia o Tarefa selecionado para criar novo serviço
            clsAreaTransf.valor3 = dataGridViewPrincipal.CurrentRow.Cells[2].Value.ToString();

            clsAreaTransf.valor4 = dataGridViewPrincipal.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
