
namespace SistemaEscola
{
    partial class Home
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
            this.disciplinaBtn = new System.Windows.Forms.Button();
            this.turmaBtn = new System.Windows.Forms.Button();
            this.professorBtn = new System.Windows.Forms.Button();
            this.alunoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disciplinaBtn
            // 
            this.disciplinaBtn.Location = new System.Drawing.Point(51, 37);
            this.disciplinaBtn.Name = "disciplinaBtn";
            this.disciplinaBtn.Size = new System.Drawing.Size(149, 60);
            this.disciplinaBtn.TabIndex = 0;
            this.disciplinaBtn.Text = "Cadastrar Disciplina";
            this.disciplinaBtn.UseVisualStyleBackColor = true;
            this.disciplinaBtn.Click += new System.EventHandler(this.disciplinaBtn_Click);
            // 
            // turmaBtn
            // 
            this.turmaBtn.Location = new System.Drawing.Point(244, 37);
            this.turmaBtn.Name = "turmaBtn";
            this.turmaBtn.Size = new System.Drawing.Size(149, 60);
            this.turmaBtn.TabIndex = 1;
            this.turmaBtn.Text = "Cadastrar Turma";
            this.turmaBtn.UseVisualStyleBackColor = true;
            // 
            // professorBtn
            // 
            this.professorBtn.Location = new System.Drawing.Point(438, 37);
            this.professorBtn.Name = "professorBtn";
            this.professorBtn.Size = new System.Drawing.Size(149, 60);
            this.professorBtn.TabIndex = 2;
            this.professorBtn.Text = "Cadastrar Professor";
            this.professorBtn.UseVisualStyleBackColor = true;
            // 
            // alunoBtn
            // 
            this.alunoBtn.Location = new System.Drawing.Point(612, 37);
            this.alunoBtn.Name = "alunoBtn";
            this.alunoBtn.Size = new System.Drawing.Size(149, 60);
            this.alunoBtn.TabIndex = 3;
            this.alunoBtn.Text = "Cadastrar Aluno";
            this.alunoBtn.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alunoBtn);
            this.Controls.Add(this.professorBtn);
            this.Controls.Add(this.turmaBtn);
            this.Controls.Add(this.disciplinaBtn);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button disciplinaBtn;
        private System.Windows.Forms.Button turmaBtn;
        private System.Windows.Forms.Button professorBtn;
        private System.Windows.Forms.Button alunoBtn;
    }
}