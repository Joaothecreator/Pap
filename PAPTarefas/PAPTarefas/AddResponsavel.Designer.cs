
namespace PAPTarefas
{
    partial class AddResponsavel
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGravarResp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 75);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 27);
            this.textBox2.TabIndex = 1;
            // 
            // btnGravarResp
            // 
            this.btnGravarResp.Location = new System.Drawing.Point(99, 155);
            this.btnGravarResp.Name = "btnGravarResp";
            this.btnGravarResp.Size = new System.Drawing.Size(79, 27);
            this.btnGravarResp.TabIndex = 2;
            this.btnGravarResp.Text = "Gravar";
            this.btnGravarResp.UseVisualStyleBackColor = true;
            this.btnGravarResp.Click += new System.EventHandler(this.btnGravarResp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // AddResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(291, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravarResp);
            this.Controls.Add(this.textBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddResponsavel";
            this.Text = "Responsavel";
            this.Load += new System.EventHandler(this.AddResponsavel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGravarResp;
        private System.Windows.Forms.Label label1;
    }
}