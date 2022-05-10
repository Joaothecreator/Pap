
namespace PAPTarefas
{
    partial class Principal
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
            this.BtnPrincipalResponsaveis = new System.Windows.Forms.Button();
            this.BtnPrincipalTarefas = new System.Windows.Forms.Button();
            this.BtnPrincipalDistribuicao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPrincipalResponsaveis
            // 
            this.BtnPrincipalResponsaveis.BackgroundImage = global::PAPTarefas.Properties.Resources.Responsaveis;
            this.BtnPrincipalResponsaveis.Location = new System.Drawing.Point(433, 310);
            this.BtnPrincipalResponsaveis.Name = "BtnPrincipalResponsaveis";
            this.BtnPrincipalResponsaveis.Size = new System.Drawing.Size(89, 93);
            this.BtnPrincipalResponsaveis.TabIndex = 2;
            this.BtnPrincipalResponsaveis.UseVisualStyleBackColor = true;
            this.BtnPrincipalResponsaveis.Click += new System.EventHandler(this.BtnPrincipalResponsaveis_Click);
            // 
            // BtnPrincipalTarefas
            // 
            this.BtnPrincipalTarefas.BackgroundImage = global::PAPTarefas.Properties.Resources.Tarefas1;
            this.BtnPrincipalTarefas.Location = new System.Drawing.Point(153, 310);
            this.BtnPrincipalTarefas.Name = "BtnPrincipalTarefas";
            this.BtnPrincipalTarefas.Size = new System.Drawing.Size(88, 93);
            this.BtnPrincipalTarefas.TabIndex = 1;
            this.BtnPrincipalTarefas.UseVisualStyleBackColor = true;
            this.BtnPrincipalTarefas.Click += new System.EventHandler(this.BtnPrincipalTarefas_Click);
            // 
            // BtnPrincipalDistribuicao
            // 
            this.BtnPrincipalDistribuicao.BackgroundImage = global::PAPTarefas.Properties.Resources.Distribuicao;
            this.BtnPrincipalDistribuicao.Location = new System.Drawing.Point(286, 306);
            this.BtnPrincipalDistribuicao.Name = "BtnPrincipalDistribuicao";
            this.BtnPrincipalDistribuicao.Size = new System.Drawing.Size(97, 97);
            this.BtnPrincipalDistribuicao.TabIndex = 0;
            this.BtnPrincipalDistribuicao.UseVisualStyleBackColor = true;
            this.BtnPrincipalDistribuicao.Click += new System.EventHandler(this.BtnPrincipalDistribuicao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestão de tarefas domésticas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPrincipalResponsaveis);
            this.Controls.Add(this.BtnPrincipalTarefas);
            this.Controls.Add(this.BtnPrincipalDistribuicao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPrincipalDistribuicao;
        private System.Windows.Forms.Button BtnPrincipalTarefas;
        private System.Windows.Forms.Button BtnPrincipalResponsaveis;
        private System.Windows.Forms.Label label1;
    }
}