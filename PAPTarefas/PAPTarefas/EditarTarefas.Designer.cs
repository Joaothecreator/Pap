
namespace PAPTarefas
{
    partial class EditarTarefas
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEditPontos = new System.Windows.Forms.TextBox();
            this.TxtEditTarefa = new System.Windows.Forms.TextBox();
            this.btnGravarTarefas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Editar Tarefa";
            // 
            // TxtEditPontos
            // 
            this.TxtEditPontos.Location = new System.Drawing.Point(51, 167);
            this.TxtEditPontos.Multiline = true;
            this.TxtEditPontos.Name = "TxtEditPontos";
            this.TxtEditPontos.Size = new System.Drawing.Size(118, 24);
            this.TxtEditPontos.TabIndex = 6;
            // 
            // TxtEditTarefa
            // 
            this.TxtEditTarefa.Location = new System.Drawing.Point(51, 99);
            this.TxtEditTarefa.Multiline = true;
            this.TxtEditTarefa.Name = "TxtEditTarefa";
            this.TxtEditTarefa.Size = new System.Drawing.Size(118, 24);
            this.TxtEditTarefa.TabIndex = 7;
            // 
            // btnGravarTarefas
            // 
            this.btnGravarTarefas.Location = new System.Drawing.Point(66, 235);
            this.btnGravarTarefas.Name = "btnGravarTarefas";
            this.btnGravarTarefas.Size = new System.Drawing.Size(75, 23);
            this.btnGravarTarefas.TabIndex = 8;
            this.btnGravarTarefas.Text = "Gravar";
            this.btnGravarTarefas.UseVisualStyleBackColor = true;
            this.btnGravarTarefas.Click += new System.EventHandler(this.btnGravarTarefas_Click);
            // 
            // EditarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 305);
            this.Controls.Add(this.btnGravarTarefas);
            this.Controls.Add(this.TxtEditTarefa);
            this.Controls.Add(this.TxtEditPontos);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarTarefas";
            this.Text = "EditarTarefas";
            this.Load += new System.EventHandler(this.EditarTarefas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEditPontos;
        private System.Windows.Forms.TextBox TxtEditTarefa;
        private System.Windows.Forms.Button btnGravarTarefas;
    }
}