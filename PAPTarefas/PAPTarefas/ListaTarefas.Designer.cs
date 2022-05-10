
namespace PAPTarefas
{
    partial class ListaTarefas
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
            this.dataGridViewListaTarefas = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAddTarefa = new System.Windows.Forms.Button();
            this.BtnEliminarTarefas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaTarefas
            // 
            this.dataGridViewListaTarefas.AllowUserToAddRows = false;
            this.dataGridViewListaTarefas.AllowUserToDeleteRows = false;
            this.dataGridViewListaTarefas.AllowUserToResizeColumns = false;
            this.dataGridViewListaTarefas.AllowUserToResizeRows = false;
            this.dataGridViewListaTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaTarefas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewListaTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaTarefas.Location = new System.Drawing.Point(39, 62);
            this.dataGridViewListaTarefas.Name = "dataGridViewListaTarefas";
            this.dataGridViewListaTarefas.ReadOnly = true;
            this.dataGridViewListaTarefas.RowHeadersVisible = false;
            this.dataGridViewListaTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaTarefas.Size = new System.Drawing.Size(379, 332);
            this.dataGridViewListaTarefas.TabIndex = 0;
            this.dataGridViewListaTarefas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaTarefas_RowEnter);
            this.dataGridViewListaTarefas.Click += new System.EventHandler(this.dataGridViewListaTarefas_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditar.Location = new System.Drawing.Point(234, 24);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(89, 32);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAddTarefa
            // 
            this.BtnAddTarefa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddTarefa.Location = new System.Drawing.Point(139, 24);
            this.BtnAddTarefa.Name = "BtnAddTarefa";
            this.BtnAddTarefa.Size = new System.Drawing.Size(89, 32);
            this.BtnAddTarefa.TabIndex = 4;
            this.BtnAddTarefa.Text = "Adicionar";
            this.BtnAddTarefa.UseVisualStyleBackColor = false;
            this.BtnAddTarefa.Click += new System.EventHandler(this.BtnAddTarefa_Click);
            // 
            // BtnEliminarTarefas
            // 
            this.BtnEliminarTarefas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminarTarefas.Location = new System.Drawing.Point(329, 24);
            this.BtnEliminarTarefas.Name = "BtnEliminarTarefas";
            this.BtnEliminarTarefas.Size = new System.Drawing.Size(89, 32);
            this.BtnEliminarTarefas.TabIndex = 5;
            this.BtnEliminarTarefas.Text = "Eliminar";
            this.BtnEliminarTarefas.UseVisualStyleBackColor = false;
            this.BtnEliminarTarefas.Click += new System.EventHandler(this.BtnEliminarTarefas_Click);
            // 
            // ListaTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 438);
            this.Controls.Add(this.BtnEliminarTarefas);
            this.Controls.Add(this.BtnAddTarefa);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.dataGridViewListaTarefas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaTarefas";
            this.Text = "ListaTarefas";
            this.Activated += new System.EventHandler(this.ListaTarefas_Activated);
            this.Load += new System.EventHandler(this.ListaTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaTarefas;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAddTarefa;
        private System.Windows.Forms.Button BtnEliminarTarefas;
    }
}