
namespace SistemaEscola
{
    partial class EditarTurma
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
            this.addDisciplinaBtn = new FontAwesome.Sharp.IconButton();
            this.disciplinasLb = new System.Windows.Forms.Label();
            this.professoresLb = new System.Windows.Forms.Label();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.addProfessorBtn = new FontAwesome.Sharp.IconButton();
            this.disciplinasFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.professoresFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.codigoTxtBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.concluirBtn = new System.Windows.Forms.Button();
            this.addAlunoBtn = new FontAwesome.Sharp.IconButton();
            this.alunosLb = new System.Windows.Forms.Label();
            this.alunosFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.backPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addDisciplinaBtn
            // 
            this.addDisciplinaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addDisciplinaBtn.FlatAppearance.BorderSize = 0;
            this.addDisciplinaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDisciplinaBtn.ForeColor = System.Drawing.Color.White;
            this.addDisciplinaBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addDisciplinaBtn.IconColor = System.Drawing.Color.White;
            this.addDisciplinaBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addDisciplinaBtn.IconSize = 40;
            this.addDisciplinaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addDisciplinaBtn.Location = new System.Drawing.Point(651, 183);
            this.addDisciplinaBtn.Name = "addDisciplinaBtn";
            this.addDisciplinaBtn.Size = new System.Drawing.Size(48, 44);
            this.addDisciplinaBtn.TabIndex = 135;
            this.addDisciplinaBtn.UseVisualStyleBackColor = false;
            this.addDisciplinaBtn.Click += new System.EventHandler(this.addDisciplinaBtn_Click);
            // 
            // disciplinasLb
            // 
            this.disciplinasLb.AutoSize = true;
            this.disciplinasLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinasLb.Location = new System.Drawing.Point(419, 183);
            this.disciplinasLb.Name = "disciplinasLb";
            this.disciplinasLb.Size = new System.Drawing.Size(153, 38);
            this.disciplinasLb.TabIndex = 136;
            this.disciplinasLb.Text = "Disciplinas";
            // 
            // professoresLb
            // 
            this.professoresLb.AutoSize = true;
            this.professoresLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professoresLb.Location = new System.Drawing.Point(778, 183);
            this.professoresLb.Name = "professoresLb";
            this.professoresLb.Size = new System.Drawing.Size(164, 38);
            this.professoresLb.TabIndex = 133;
            this.professoresLb.Text = "Professores";
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nomeTxtBox.Location = new System.Drawing.Point(430, 68);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(268, 24);
            this.nomeTxtBox.TabIndex = 127;
            this.nomeTxtBox.Text = "Nome";
            this.nomeTxtBox.Enter += new System.EventHandler(this.nomeTxtBox_Enter);
            this.nomeTxtBox.Leave += new System.EventHandler(this.nomeTxtBox_Leave);
            // 
            // addProfessorBtn
            // 
            this.addProfessorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addProfessorBtn.FlatAppearance.BorderSize = 0;
            this.addProfessorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProfessorBtn.ForeColor = System.Drawing.Color.White;
            this.addProfessorBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addProfessorBtn.IconColor = System.Drawing.Color.White;
            this.addProfessorBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addProfessorBtn.IconSize = 40;
            this.addProfessorBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addProfessorBtn.Location = new System.Drawing.Point(1010, 183);
            this.addProfessorBtn.Name = "addProfessorBtn";
            this.addProfessorBtn.Size = new System.Drawing.Size(48, 44);
            this.addProfessorBtn.TabIndex = 132;
            this.addProfessorBtn.UseVisualStyleBackColor = false;
            this.addProfessorBtn.Click += new System.EventHandler(this.addProfessorBtn_Click);
            // 
            // disciplinasFlwLayPnl
            // 
            this.disciplinasFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.disciplinasFlwLayPnl.Location = new System.Drawing.Point(426, 248);
            this.disciplinasFlwLayPnl.Name = "disciplinasFlwLayPnl";
            this.disciplinasFlwLayPnl.Size = new System.Drawing.Size(273, 183);
            this.disciplinasFlwLayPnl.TabIndex = 134;
            this.disciplinasFlwLayPnl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.disciplinasFlwLayPnl_ControlRemoved);
            // 
            // professoresFlwLayPnl
            // 
            this.professoresFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.professoresFlwLayPnl.Location = new System.Drawing.Point(785, 248);
            this.professoresFlwLayPnl.Name = "professoresFlwLayPnl";
            this.professoresFlwLayPnl.Size = new System.Drawing.Size(273, 183);
            this.professoresFlwLayPnl.TabIndex = 131;
            this.professoresFlwLayPnl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.professoresFlwLayPnl_ControlRemoved);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(430, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 2);
            this.panel1.TabIndex = 128;
            // 
            // codigoTxtBox
            // 
            this.codigoTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigoTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.codigoTxtBox.Location = new System.Drawing.Point(430, 119);
            this.codigoTxtBox.Name = "codigoTxtBox";
            this.codigoTxtBox.Size = new System.Drawing.Size(268, 24);
            this.codigoTxtBox.TabIndex = 129;
            this.codigoTxtBox.Text = "Código";
            this.codigoTxtBox.Enter += new System.EventHandler(this.codigoTxtBox_Enter);
            this.codigoTxtBox.Leave += new System.EventHandler(this.codigoTxtBox_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel5.Location = new System.Drawing.Point(430, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 2);
            this.panel5.TabIndex = 130;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(952, 507);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(142, 54);
            this.removeBtn.TabIndex = 138;
            this.removeBtn.Text = "Remover";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // concluirBtn
            // 
            this.concluirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.concluirBtn.FlatAppearance.BorderSize = 0;
            this.concluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concluirBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concluirBtn.ForeColor = System.Drawing.Color.White;
            this.concluirBtn.Location = new System.Drawing.Point(454, 485);
            this.concluirBtn.Name = "concluirBtn";
            this.concluirBtn.Size = new System.Drawing.Size(218, 92);
            this.concluirBtn.TabIndex = 137;
            this.concluirBtn.Text = "Concluir";
            this.concluirBtn.UseVisualStyleBackColor = false;
            this.concluirBtn.Click += new System.EventHandler(this.concluirBtn_Click);
            // 
            // addAlunoBtn
            // 
            this.addAlunoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addAlunoBtn.FlatAppearance.BorderSize = 0;
            this.addAlunoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlunoBtn.ForeColor = System.Drawing.Color.White;
            this.addAlunoBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addAlunoBtn.IconColor = System.Drawing.Color.White;
            this.addAlunoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addAlunoBtn.IconSize = 40;
            this.addAlunoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addAlunoBtn.Location = new System.Drawing.Point(296, 183);
            this.addAlunoBtn.Name = "addAlunoBtn";
            this.addAlunoBtn.Size = new System.Drawing.Size(48, 44);
            this.addAlunoBtn.TabIndex = 140;
            this.addAlunoBtn.UseVisualStyleBackColor = false;
            this.addAlunoBtn.Click += new System.EventHandler(this.addAlunoBtn_Click);
            // 
            // alunosLb
            // 
            this.alunosLb.AutoSize = true;
            this.alunosLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunosLb.Location = new System.Drawing.Point(64, 183);
            this.alunosLb.Name = "alunosLb";
            this.alunosLb.Size = new System.Drawing.Size(102, 38);
            this.alunosLb.TabIndex = 141;
            this.alunosLb.Text = "Alunos";
            // 
            // alunosFlwLayPnl
            // 
            this.alunosFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.alunosFlwLayPnl.Location = new System.Drawing.Point(71, 248);
            this.alunosFlwLayPnl.Name = "alunosFlwLayPnl";
            this.alunosFlwLayPnl.Size = new System.Drawing.Size(273, 183);
            this.alunosFlwLayPnl.TabIndex = 139;
            this.alunosFlwLayPnl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.alunosFlwLayPnl_ControlRemoved);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.White;
            this.backPanel.Location = new System.Drawing.Point(1, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1201, 670);
            this.backPanel.TabIndex = 166;
            this.backPanel.Click += new System.EventHandler(this.backPanel_Click);
            // 
            // EditarTurma
            // 
            this.AcceptButton = this.concluirBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.addAlunoBtn);
            this.Controls.Add(this.alunosLb);
            this.Controls.Add(this.alunosFlwLayPnl);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.concluirBtn);
            this.Controls.Add(this.addDisciplinaBtn);
            this.Controls.Add(this.disciplinasLb);
            this.Controls.Add(this.professoresLb);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.addProfessorBtn);
            this.Controls.Add(this.disciplinasFlwLayPnl);
            this.Controls.Add(this.professoresFlwLayPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.codigoTxtBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.backPanel);
            this.Name = "EditarTurma";
            this.Text = "EditarTurma";
            this.Load += new System.EventHandler(this.EditarTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton addDisciplinaBtn;
        private System.Windows.Forms.Label disciplinasLb;
        private System.Windows.Forms.Label professoresLb;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private FontAwesome.Sharp.IconButton addProfessorBtn;
        private System.Windows.Forms.FlowLayoutPanel disciplinasFlwLayPnl;
        private System.Windows.Forms.FlowLayoutPanel professoresFlwLayPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox codigoTxtBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button concluirBtn;
        private FontAwesome.Sharp.IconButton addAlunoBtn;
        private System.Windows.Forms.Label alunosLb;
        private System.Windows.Forms.FlowLayoutPanel alunosFlwLayPnl;
        private System.Windows.Forms.Panel backPanel;
    }
}