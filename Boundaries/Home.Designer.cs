
namespace SistemaEscola
{
    partial class Home
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
            this.disciplinaBtn = new System.Windows.Forms.Button();
            this.turmaBtn = new System.Windows.Forms.Button();
            this.professorBtn = new System.Windows.Forms.Button();
            this.alunosBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.titleLb = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
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
            // disciplinaBtn
            // 
            this.disciplinaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.disciplinaBtn.FlatAppearance.BorderSize = 0;
            this.disciplinaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplinaBtn.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinaBtn.ForeColor = System.Drawing.Color.White;
            this.disciplinaBtn.Location = new System.Drawing.Point(0, 267);
            this.disciplinaBtn.Name = "disciplinaBtn";
            this.disciplinaBtn.Size = new System.Drawing.Size(191, 66);
            this.disciplinaBtn.TabIndex = 4;
            this.disciplinaBtn.Text = "Disciplina";
            this.disciplinaBtn.UseVisualStyleBackColor = false;
            this.disciplinaBtn.Click += new System.EventHandler(this.disciplinaBtn_Click);
            // 
            // turmaBtn
            // 
            this.turmaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.turmaBtn.FlatAppearance.BorderSize = 0;
            this.turmaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turmaBtn.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turmaBtn.ForeColor = System.Drawing.Color.White;
            this.turmaBtn.Location = new System.Drawing.Point(0, 204);
            this.turmaBtn.Name = "turmaBtn";
            this.turmaBtn.Size = new System.Drawing.Size(191, 66);
            this.turmaBtn.TabIndex = 3;
            this.turmaBtn.Text = "Turma";
            this.turmaBtn.UseVisualStyleBackColor = false;
            this.turmaBtn.Click += new System.EventHandler(this.turmaBtn_Click);
            // 
            // professorBtn
            // 
            this.professorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.professorBtn.FlatAppearance.BorderSize = 0;
            this.professorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professorBtn.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professorBtn.ForeColor = System.Drawing.Color.White;
            this.professorBtn.Location = new System.Drawing.Point(0, 141);
            this.professorBtn.Name = "professorBtn";
            this.professorBtn.Size = new System.Drawing.Size(191, 66);
            this.professorBtn.TabIndex = 2;
            this.professorBtn.Text = "Professor";
            this.professorBtn.UseVisualStyleBackColor = false;
            this.professorBtn.Click += new System.EventHandler(this.professorBtn_Click);
            // 
            // alunosBtn
            // 
            this.alunosBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.alunosBtn.FlatAppearance.BorderSize = 0;
            this.alunosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alunosBtn.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunosBtn.ForeColor = System.Drawing.Color.White;
            this.alunosBtn.Location = new System.Drawing.Point(0, 79);
            this.alunosBtn.Name = "alunosBtn";
            this.alunosBtn.Size = new System.Drawing.Size(191, 66);
            this.alunosBtn.TabIndex = 1;
            this.alunosBtn.Text = "Aluno";
            this.alunosBtn.UseVisualStyleBackColor = false;
            this.alunosBtn.Click += new System.EventHandler(this.alunosBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 80);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Controls.Add(this.titleLb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(191, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 80);
            this.panel3.TabIndex = 2;
            // 
            // titleLb
            // 
            this.titleLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLb.AutoSize = true;
            this.titleLb.BackColor = System.Drawing.Color.Transparent;
            this.titleLb.Font = new System.Drawing.Font("Comfortaa", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.ForeColor = System.Drawing.Color.White;
            this.titleLb.Location = new System.Drawing.Point(447, -3);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(199, 75);
            this.titleLb.TabIndex = 0;
            this.titleLb.Text = "HOME";
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImage = global::SistemaEscola.Properties.Resources.home_icon_2;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(86, 80);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Visible = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
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
        private System.Windows.Forms.Button homeBtn;
    }
}

