
namespace PAPTarefas
{
    partial class Pontuacoes
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
            this.dataGridViewPontuacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPontuacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPontuacoes
            // 
            this.dataGridViewPontuacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPontuacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPontuacoes.Location = new System.Drawing.Point(26, 56);
            this.dataGridViewPontuacoes.Name = "dataGridViewPontuacoes";
            this.dataGridViewPontuacoes.Size = new System.Drawing.Size(281, 304);
            this.dataGridViewPontuacoes.TabIndex = 0;
            // 
            // Pontuacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 417);
            this.Controls.Add(this.dataGridViewPontuacoes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pontuacoes";
            this.Text = "Pontuacoes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPontuacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPontuacoes;
    }
}