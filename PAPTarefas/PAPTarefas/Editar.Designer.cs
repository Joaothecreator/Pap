
namespace PAPTarefas
{
    partial class Editar
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
            this.btnGravarEdit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbEditarDistribTarefas = new System.Windows.Forms.ComboBox();
            this.CmbEditarDistribResp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEliminarEdit = new System.Windows.Forms.Button();
            this.Tarefa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGravarEdit
            // 
            this.btnGravarEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGravarEdit.Location = new System.Drawing.Point(9, 346);
            this.btnGravarEdit.Name = "btnGravarEdit";
            this.btnGravarEdit.Size = new System.Drawing.Size(82, 23);
            this.btnGravarEdit.TabIndex = 4;
            this.btnGravarEdit.Text = "Gravar";
            this.btnGravarEdit.UseVisualStyleBackColor = false;
            this.btnGravarEdit.Click += new System.EventHandler(this.btnGravarEdit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // CmbEditarDistribTarefas
            // 
            this.CmbEditarDistribTarefas.FormattingEnabled = true;
            this.CmbEditarDistribTarefas.Location = new System.Drawing.Point(59, 174);
            this.CmbEditarDistribTarefas.Name = "CmbEditarDistribTarefas";
            this.CmbEditarDistribTarefas.Size = new System.Drawing.Size(141, 21);
            this.CmbEditarDistribTarefas.TabIndex = 6;
            this.CmbEditarDistribTarefas.SelectedIndexChanged += new System.EventHandler(this.CmbEditarDistribTarefas_SelectedIndexChanged);
            this.CmbEditarDistribTarefas.Enter += new System.EventHandler(this.CmbEditarDistribTarefas_Enter);
            // 
            // CmbEditarDistribResp
            // 
            this.CmbEditarDistribResp.FormattingEnabled = true;
            this.CmbEditarDistribResp.Location = new System.Drawing.Point(59, 113);
            this.CmbEditarDistribResp.Name = "CmbEditarDistribResp";
            this.CmbEditarDistribResp.Size = new System.Drawing.Size(141, 21);
            this.CmbEditarDistribResp.TabIndex = 7;
            this.CmbEditarDistribResp.SelectedIndexChanged += new System.EventHandler(this.CmbEditarDistribResp_SelectedIndexChanged);
            this.CmbEditarDistribResp.Enter += new System.EventHandler(this.CmbEditarDistribResp_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            // 
            // BtnEliminarEdit
            // 
            this.BtnEliminarEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminarEdit.Location = new System.Drawing.Point(168, 346);
            this.BtnEliminarEdit.Name = "BtnEliminarEdit";
            this.BtnEliminarEdit.Size = new System.Drawing.Size(82, 23);
            this.BtnEliminarEdit.TabIndex = 14;
            this.BtnEliminarEdit.Text = "Eliminar";
            this.BtnEliminarEdit.UseVisualStyleBackColor = false;
            // 
            // Tarefa
            // 
            this.Tarefa.AutoSize = true;
            this.Tarefa.Location = new System.Drawing.Point(56, 149);
            this.Tarefa.Name = "Tarefa";
            this.Tarefa.Size = new System.Drawing.Size(38, 13);
            this.Tarefa.TabIndex = 16;
            this.Tarefa.Text = "Tarefa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(59, 54);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(141, 20);
            this.TxtID.TabIndex = 8;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 381);
            this.Controls.Add(this.Tarefa);
            this.Controls.Add(this.BtnEliminarEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.CmbEditarDistribResp);
            this.Controls.Add(this.CmbEditarDistribTarefas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGravarEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGravarEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CmbEditarDistribTarefas;
        private System.Windows.Forms.ComboBox CmbEditarDistribResp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEliminarEdit;
        private System.Windows.Forms.Label Tarefa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtID;
    }
}