
namespace SistemaEscola
{
    partial class CadastrarTurma
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.codigoTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.alunosFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.alunosLb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.disciplinasLb = new System.Windows.Forms.Label();
            this.disciplinasFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.addDisciplinaBtn = new FontAwesome.Sharp.IconButton();
            this.addAlunoBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(915, 557);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Visible = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(451, 467);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(218, 92);
            this.addBtn.TabIndex = 117;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel5.Location = new System.Drawing.Point(431, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 2);
            this.panel5.TabIndex = 104;
            // 
            // codigoTxtBox
            // 
            this.codigoTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigoTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.codigoTxtBox.Location = new System.Drawing.Point(431, 82);
            this.codigoTxtBox.Name = "codigoTxtBox";
            this.codigoTxtBox.Size = new System.Drawing.Size(268, 24);
            this.codigoTxtBox.TabIndex = 98;
            this.codigoTxtBox.Text = "Código";
            this.codigoTxtBox.Enter += new System.EventHandler(this.codigoTxtBox_Enter);
            this.codigoTxtBox.Leave += new System.EventHandler(this.codigoTxtBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(431, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 2);
            this.panel1.TabIndex = 96;
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nomeTxtBox.Location = new System.Drawing.Point(431, 31);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(268, 24);
            this.nomeTxtBox.TabIndex = 95;
            this.nomeTxtBox.Text = "Nome";
            this.nomeTxtBox.Enter += new System.EventHandler(this.nomeTxtBox_Enter);
            this.nomeTxtBox.Leave += new System.EventHandler(this.nomeTxtBox_Leave);
            // 
            // alunosFlwLayPnl
            // 
            this.alunosFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.alunosFlwLayPnl.Location = new System.Drawing.Point(603, 223);
            this.alunosFlwLayPnl.Name = "alunosFlwLayPnl";
            this.alunosFlwLayPnl.Size = new System.Drawing.Size(273, 183);
            this.alunosFlwLayPnl.TabIndex = 118;
            // 
            // alunosLb
            // 
            this.alunosLb.AutoSize = true;
            this.alunosLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunosLb.Location = new System.Drawing.Point(596, 158);
            this.alunosLb.Name = "alunosLb";
            this.alunosLb.Size = new System.Drawing.Size(102, 38);
            this.alunosLb.TabIndex = 122;
            this.alunosLb.Text = "Alunos";
            this.alunosLb.Click += new System.EventHandler(this.alunosLb_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 592);
            this.panel2.TabIndex = 123;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // disciplinasLb
            // 
            this.disciplinasLb.AutoSize = true;
            this.disciplinasLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinasLb.Location = new System.Drawing.Point(237, 158);
            this.disciplinasLb.Name = "disciplinasLb";
            this.disciplinasLb.Size = new System.Drawing.Size(153, 38);
            this.disciplinasLb.TabIndex = 126;
            this.disciplinasLb.Text = "Disciplinas";
            this.disciplinasLb.Click += new System.EventHandler(this.disciplinasLb_Click);
            // 
            // disciplinasFlwLayPnl
            // 
            this.disciplinasFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.disciplinasFlwLayPnl.Location = new System.Drawing.Point(244, 223);
            this.disciplinasFlwLayPnl.Name = "disciplinasFlwLayPnl";
            this.disciplinasFlwLayPnl.Size = new System.Drawing.Size(273, 183);
            this.disciplinasFlwLayPnl.TabIndex = 124;
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
            this.addDisciplinaBtn.Location = new System.Drawing.Point(469, 158);
            this.addDisciplinaBtn.Name = "addDisciplinaBtn";
            this.addDisciplinaBtn.Size = new System.Drawing.Size(48, 44);
            this.addDisciplinaBtn.TabIndex = 125;
            this.addDisciplinaBtn.UseVisualStyleBackColor = false;
            this.addDisciplinaBtn.Click += new System.EventHandler(this.addDisciplinaBtn_Click);
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
            this.addAlunoBtn.Location = new System.Drawing.Point(828, 158);
            this.addAlunoBtn.Name = "addAlunoBtn";
            this.addAlunoBtn.Size = new System.Drawing.Size(48, 44);
            this.addAlunoBtn.TabIndex = 121;
            this.addAlunoBtn.UseVisualStyleBackColor = false;
            this.addAlunoBtn.Click += new System.EventHandler(this.addAlunoBtn_Click);
            // 
            // CadastrarTurma
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.addDisciplinaBtn);
            this.Controls.Add(this.disciplinasLb);
            this.Controls.Add(this.alunosLb);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.addAlunoBtn);
            this.Controls.Add(this.disciplinasFlwLayPnl);
            this.Controls.Add(this.alunosFlwLayPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.codigoTxtBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Name = "CadastrarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarTurma";
            this.Load += new System.EventHandler(this.CadastrarTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox codigoTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.FlowLayoutPanel alunosFlwLayPnl;
        private FontAwesome.Sharp.IconButton addAlunoBtn;
        private System.Windows.Forms.Label alunosLb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label disciplinasLb;
        private FontAwesome.Sharp.IconButton addDisciplinaBtn;
        private System.Windows.Forms.FlowLayoutPanel disciplinasFlwLayPnl;
    }
}