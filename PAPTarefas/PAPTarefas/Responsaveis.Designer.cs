
namespace PAPTarefas
{
    partial class Responsaveis
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
            this.dataGridViewResponsaveis = new System.Windows.Forms.DataGridView();
            this.BtnAddRespe = new System.Windows.Forms.Button();
            this.BtnRemoveResp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponsaveis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResponsaveis
            // 
            this.dataGridViewResponsaveis.AllowUserToAddRows = false;
            this.dataGridViewResponsaveis.AllowUserToDeleteRows = false;
            this.dataGridViewResponsaveis.AllowUserToResizeColumns = false;
            this.dataGridViewResponsaveis.AllowUserToResizeRows = false;
            this.dataGridViewResponsaveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResponsaveis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewResponsaveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResponsaveis.Location = new System.Drawing.Point(32, 40);
            this.dataGridViewResponsaveis.Name = "dataGridViewResponsaveis";
            this.dataGridViewResponsaveis.ReadOnly = true;
            this.dataGridViewResponsaveis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewResponsaveis.RowHeadersVisible = false;
            this.dataGridViewResponsaveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResponsaveis.Size = new System.Drawing.Size(168, 263);
            this.dataGridViewResponsaveis.TabIndex = 0;
            this.dataGridViewResponsaveis.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResponsaveis_RowEnter);
            // 
            // BtnAddRespe
            // 
            this.BtnAddRespe.Location = new System.Drawing.Point(33, 342);
            this.BtnAddRespe.Name = "BtnAddRespe";
            this.BtnAddRespe.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRespe.TabIndex = 1;
            this.BtnAddRespe.Text = "Adicionar";
            this.BtnAddRespe.UseVisualStyleBackColor = true;
            this.BtnAddRespe.Click += new System.EventHandler(this.BtnAddRespe_Click);
            // 
            // BtnRemoveResp
            // 
            this.BtnRemoveResp.Location = new System.Drawing.Point(126, 342);
            this.BtnRemoveResp.Name = "BtnRemoveResp";
            this.BtnRemoveResp.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveResp.TabIndex = 2;
            this.BtnRemoveResp.Text = "Eliminar";
            this.BtnRemoveResp.UseVisualStyleBackColor = true;
            this.BtnRemoveResp.Click += new System.EventHandler(this.BtnRemoveResp_Click);
            // 
            // Responsaveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 388);
            this.Controls.Add(this.BtnRemoveResp);
            this.Controls.Add(this.BtnAddRespe);
            this.Controls.Add(this.dataGridViewResponsaveis);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Responsaveis";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responsaveis";
            this.Activated += new System.EventHandler(this.Responsaveis_Activated);
            this.Load += new System.EventHandler(this.Responsaveis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponsaveis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResponsaveis;
        private System.Windows.Forms.Button BtnAddRespe;
        private System.Windows.Forms.Button BtnRemoveResp;
    }
}