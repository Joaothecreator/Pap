
namespace PAPTarefas
{
    partial class AdicionarTarefas
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
            this.btnGravarTarefas = new System.Windows.Forms.Button();
            this.TxtAddPontos = new System.Windows.Forms.TextBox();
            this.TxtAddTarefa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGravarTarefas
            // 
            this.btnGravarTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarTarefas.Location = new System.Drawing.Point(82, 238);
            this.btnGravarTarefas.Name = "btnGravarTarefas";
            this.btnGravarTarefas.Size = new System.Drawing.Size(75, 23);
            this.btnGravarTarefas.TabIndex = 12;
            this.btnGravarTarefas.Text = "Gravar";
            this.btnGravarTarefas.UseVisualStyleBackColor = true;
            this.btnGravarTarefas.Click += new System.EventHandler(this.btnGravarTarefas_Click);
            // 
            // TxtAddPontos
            // 
            this.TxtAddPontos.Location = new System.Drawing.Point(66, 155);
            this.TxtAddPontos.Multiline = true;
            this.TxtAddPontos.Name = "TxtAddPontos";
            this.TxtAddPontos.Size = new System.Drawing.Size(118, 24);
            this.TxtAddPontos.TabIndex = 11;
            // 
            // TxtAddTarefa
            // 
            this.TxtAddTarefa.Location = new System.Drawing.Point(66, 82);
            this.TxtAddTarefa.Multiline = true;
            this.TxtAddTarefa.Name = "TxtAddTarefa";
            this.TxtAddTarefa.Size = new System.Drawing.Size(118, 24);
            this.TxtAddTarefa.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome da tarefa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pontuação";
            // 
            // AdicionarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGravarTarefas);
            this.Controls.Add(this.TxtAddPontos);
            this.Controls.Add(this.TxtAddTarefa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarTarefas";
            this.Text = "AdicionarTarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravarTarefas;
        private System.Windows.Forms.TextBox TxtAddPontos;
        private System.Windows.Forms.TextBox TxtAddTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}