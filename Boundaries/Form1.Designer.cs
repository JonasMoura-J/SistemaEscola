﻿
namespace SistemaEscola
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.alunosBtn = new System.Windows.Forms.Button();
            this.professorBtn = new System.Windows.Forms.Button();
            this.turmaBtn = new System.Windows.Forms.Button();
            this.disciplinaBtn = new System.Windows.Forms.Button();
            this.titleLb = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(190, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 629);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.disciplinaBtn);
            this.panel2.Controls.Add(this.turmaBtn);
            this.panel2.Controls.Add(this.professorBtn);
            this.panel2.Controls.Add(this.alunosBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 708);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.titleLb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(191, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 80);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 80);
            this.panel4.TabIndex = 0;
            // 
            // alunosBtn
            // 
            this.alunosBtn.BackColor = System.Drawing.Color.Transparent;
            this.alunosBtn.FlatAppearance.BorderSize = 0;
            this.alunosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alunosBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.alunosBtn.ForeColor = System.Drawing.Color.White;
            this.alunosBtn.Location = new System.Drawing.Point(0, 79);
            this.alunosBtn.Name = "alunosBtn";
            this.alunosBtn.Size = new System.Drawing.Size(191, 66);
            this.alunosBtn.TabIndex = 1;
            this.alunosBtn.Text = "Aluno";
            this.alunosBtn.UseVisualStyleBackColor = false;
            this.alunosBtn.Click += new System.EventHandler(this.alunosBtn_Click);
            // 
            // professorBtn
            // 
            this.professorBtn.BackColor = System.Drawing.Color.Transparent;
            this.professorBtn.FlatAppearance.BorderSize = 0;
            this.professorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professorBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.professorBtn.ForeColor = System.Drawing.Color.White;
            this.professorBtn.Location = new System.Drawing.Point(0, 141);
            this.professorBtn.Name = "professorBtn";
            this.professorBtn.Size = new System.Drawing.Size(191, 66);
            this.professorBtn.TabIndex = 2;
            this.professorBtn.Text = "Professor";
            this.professorBtn.UseVisualStyleBackColor = false;
            // 
            // turmaBtn
            // 
            this.turmaBtn.BackColor = System.Drawing.Color.Transparent;
            this.turmaBtn.FlatAppearance.BorderSize = 0;
            this.turmaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turmaBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.turmaBtn.ForeColor = System.Drawing.Color.White;
            this.turmaBtn.Location = new System.Drawing.Point(0, 204);
            this.turmaBtn.Name = "turmaBtn";
            this.turmaBtn.Size = new System.Drawing.Size(191, 66);
            this.turmaBtn.TabIndex = 3;
            this.turmaBtn.Text = "Turma";
            this.turmaBtn.UseVisualStyleBackColor = false;
            // 
            // disciplinaBtn
            // 
            this.disciplinaBtn.BackColor = System.Drawing.Color.Transparent;
            this.disciplinaBtn.FlatAppearance.BorderSize = 0;
            this.disciplinaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplinaBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.disciplinaBtn.ForeColor = System.Drawing.Color.White;
            this.disciplinaBtn.Location = new System.Drawing.Point(0, 267);
            this.disciplinaBtn.Name = "disciplinaBtn";
            this.disciplinaBtn.Size = new System.Drawing.Size(191, 66);
            this.disciplinaBtn.TabIndex = 4;
            this.disciplinaBtn.Text = "Disciplina";
            this.disciplinaBtn.UseVisualStyleBackColor = false;
            // 
            // titleLb
            // 
            this.titleLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLb.AutoSize = true;
            this.titleLb.BackColor = System.Drawing.Color.Transparent;
            this.titleLb.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.ForeColor = System.Drawing.Color.White;
            this.titleLb.Location = new System.Drawing.Point(450, 9);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(173, 65);
            this.titleLb.TabIndex = 0;
            this.titleLb.Text = "HOME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button alunosBtn;
        private System.Windows.Forms.Button disciplinaBtn;
        private System.Windows.Forms.Button turmaBtn;
        private System.Windows.Forms.Button professorBtn;
        private System.Windows.Forms.Label titleLb;
    }
}
