
namespace PAPTarefas
{
    partial class Tarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarefas));
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAddDistrib = new System.Windows.Forms.ToolStripButton();
            this.toolStripAddEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelPesquisa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonLupa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLimparPesquisa = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTarefas = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrincipal
            // 
            this.dataGridViewPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPrincipal.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.ReadOnly = true;
            this.dataGridViewPrincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPrincipal.RowHeadersVisible = false;
            this.dataGridViewPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(700, 431);
            this.dataGridViewPrincipal.TabIndex = 0;
            this.dataGridViewPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrincipal_CellClick);
            this.dataGridViewPrincipal.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddDistrib,
            this.toolStripAddEdit,
            this.toolStripSeparator1,
            this.toolStripLabelPesquisa,
            this.toolStripTextBoxPesquisa,
            this.toolStripButtonLupa,
            this.toolStripSeparator2,
            this.toolStripLimparPesquisa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAddDistrib
            // 
            this.toolStripAddDistrib.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAddDistrib.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddDistrib.Image")));
            this.toolStripAddDistrib.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddDistrib.Name = "toolStripAddDistrib";
            this.toolStripAddDistrib.Size = new System.Drawing.Size(62, 22);
            this.toolStripAddDistrib.Text = "Adicionar";
            this.toolStripAddDistrib.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripAddEdit
            // 
            this.toolStripAddEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAddEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddEdit.Image")));
            this.toolStripAddEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddEdit.Name = "toolStripAddEdit";
            this.toolStripAddEdit.Size = new System.Drawing.Size(41, 22);
            this.toolStripAddEdit.Text = "Editar";
            this.toolStripAddEdit.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelPesquisa
            // 
            this.toolStripLabelPesquisa.Name = "toolStripLabelPesquisa";
            this.toolStripLabelPesquisa.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabelPesquisa.Text = "Pesquisar:";
            // 
            // toolStripTextBoxPesquisa
            // 
            this.toolStripTextBoxPesquisa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxPesquisa.Name = "toolStripTextBoxPesquisa";
            this.toolStripTextBoxPesquisa.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonLupa
            // 
            this.toolStripButtonLupa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLupa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLupa.Image")));
            this.toolStripButtonLupa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLupa.Name = "toolStripButtonLupa";
            this.toolStripButtonLupa.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLupa.Text = "Pesquisar";
            this.toolStripButtonLupa.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLimparPesquisa
            // 
            this.toolStripLimparPesquisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLimparPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLimparPesquisa.Image")));
            this.toolStripLimparPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLimparPesquisa.Name = "toolStripLimparPesquisa";
            this.toolStripLimparPesquisa.Size = new System.Drawing.Size(97, 22);
            this.toolStripLimparPesquisa.Text = "Limpar pesquisa";
            this.toolStripLimparPesquisa.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTarefas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTarefas
            // 
            this.toolStripStatusLabelTarefas.Name = "toolStripStatusLabelTarefas";
            this.toolStripStatusLabelTarefas.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelTarefas.Text = "toolStripStatusLabel1";
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.dataGridViewPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tarefas";
            this.Text = "Distribuição";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Tarefas_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAddDistrib;
        private System.Windows.Forms.ToolStripButton toolStripAddEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPesquisa;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPesquisa;
        private System.Windows.Forms.ToolStripButton toolStripButtonLupa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTarefas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripLimparPesquisa;
    }
}

