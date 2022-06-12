
namespace SistemaEscola
{
    partial class EditarProfessor
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
            this.telCelTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.telResTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataNascTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rgTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.turmasLb = new System.Windows.Forms.Label();
            this.turmasFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.disciplinasLb = new System.Windows.Forms.Label();
            this.disciplinasFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.concluirBtn = new System.Windows.Forms.Button();
            this.backPanel = new System.Windows.Forms.Panel();
            this.addTurmaBtn = new FontAwesome.Sharp.IconButton();
            this.addDisciplinaBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // telCelTxtBox
            // 
            this.telCelTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telCelTxtBox.Culture = new System.Globalization.CultureInfo("");
            this.telCelTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.telCelTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.telCelTxtBox.Location = new System.Drawing.Point(395, 154);
            this.telCelTxtBox.Name = "telCelTxtBox";
            this.telCelTxtBox.PromptChar = ' ';
            this.telCelTxtBox.Size = new System.Drawing.Size(153, 24);
            this.telCelTxtBox.TabIndex = 107;
            this.telCelTxtBox.Text = "Telefone Celular";
            this.telCelTxtBox.ValidatingType = typeof(System.DateTime);
            this.telCelTxtBox.Enter += new System.EventHandler(this.telCelTxtBox_Enter);
            this.telCelTxtBox.Leave += new System.EventHandler(this.telCelTxtBox_Leave);
            // 
            // telResTxtBox
            // 
            this.telResTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telResTxtBox.Culture = new System.Globalization.CultureInfo("");
            this.telResTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.telResTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.telResTxtBox.Location = new System.Drawing.Point(174, 154);
            this.telResTxtBox.Name = "telResTxtBox";
            this.telResTxtBox.PromptChar = ' ';
            this.telResTxtBox.Size = new System.Drawing.Size(190, 24);
            this.telResTxtBox.TabIndex = 106;
            this.telResTxtBox.Text = "Telefone Residencial";
            this.telResTxtBox.ValidatingType = typeof(System.DateTime);
            this.telResTxtBox.Enter += new System.EventHandler(this.telResTxtBox_Enter);
            this.telResTxtBox.Leave += new System.EventHandler(this.telResTxtBox_Leave);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.emailTxtBox.Location = new System.Drawing.Point(579, 154);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(375, 24);
            this.emailTxtBox.TabIndex = 96;
            this.emailTxtBox.Text = "E-mail";
            this.emailTxtBox.Enter += new System.EventHandler(this.emailTxtBox_Enter);
            this.emailTxtBox.Leave += new System.EventHandler(this.emailTxtBox_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel4.Location = new System.Drawing.Point(579, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 2);
            this.panel4.TabIndex = 98;
            // 
            // dataNascTxtBox
            // 
            this.dataNascTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNascTxtBox.Culture = new System.Globalization.CultureInfo("");
            this.dataNascTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.dataNascTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.dataNascTxtBox.Location = new System.Drawing.Point(172, 90);
            this.dataNascTxtBox.Name = "dataNascTxtBox";
            this.dataNascTxtBox.PromptChar = ' ';
            this.dataNascTxtBox.Size = new System.Drawing.Size(198, 24);
            this.dataNascTxtBox.TabIndex = 105;
            this.dataNascTxtBox.Text = "Data de Nascimento";
            this.dataNascTxtBox.ValidatingType = typeof(System.DateTime);
            this.dataNascTxtBox.Enter += new System.EventHandler(this.dataNascTxtBox_Enter);
            this.dataNascTxtBox.Leave += new System.EventHandler(this.dataNascTxtBox_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel7.Location = new System.Drawing.Point(395, 182);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(153, 2);
            this.panel7.TabIndex = 100;
            // 
            // rgTxtBox
            // 
            this.rgTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rgTxtBox.Culture = new System.Globalization.CultureInfo("");
            this.rgTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.rgTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.rgTxtBox.Location = new System.Drawing.Point(834, 28);
            this.rgTxtBox.Name = "rgTxtBox";
            this.rgTxtBox.PromptChar = ' ';
            this.rgTxtBox.Size = new System.Drawing.Size(120, 24);
            this.rgTxtBox.TabIndex = 104;
            this.rgTxtBox.Text = "RG";
            this.rgTxtBox.ValidatingType = typeof(System.DateTime);
            this.rgTxtBox.Enter += new System.EventHandler(this.rgTxtBox_Enter);
            this.rgTxtBox.Leave += new System.EventHandler(this.rgTxtBox_Leave);
            // 
            // cpfTxtBox
            // 
            this.cpfTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpfTxtBox.Culture = new System.Globalization.CultureInfo("");
            this.cpfTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cpfTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.cpfTxtBox.Location = new System.Drawing.Point(659, 28);
            this.cpfTxtBox.Name = "cpfTxtBox";
            this.cpfTxtBox.PromptChar = ' ';
            this.cpfTxtBox.Size = new System.Drawing.Size(140, 24);
            this.cpfTxtBox.TabIndex = 103;
            this.cpfTxtBox.Text = "CPF";
            this.cpfTxtBox.ValidatingType = typeof(System.DateTime);
            this.cpfTxtBox.Enter += new System.EventHandler(this.cpfTxtBox_Enter);
            this.cpfTxtBox.Leave += new System.EventHandler(this.cpfTxtBox_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel9.Location = new System.Drawing.Point(172, 119);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(192, 2);
            this.panel9.TabIndex = 102;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel6.Location = new System.Drawing.Point(174, 182);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 2);
            this.panel6.TabIndex = 101;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel3.Location = new System.Drawing.Point(834, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 2);
            this.panel3.TabIndex = 99;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(659, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 2);
            this.panel2.TabIndex = 97;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(173, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 2);
            this.panel1.TabIndex = 95;
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nomeTxtBox.Location = new System.Drawing.Point(173, 28);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(448, 24);
            this.nomeTxtBox.TabIndex = 94;
            this.nomeTxtBox.Text = "Nome";
            this.nomeTxtBox.Enter += new System.EventHandler(this.nomeTxtBox_Enter);
            this.nomeTxtBox.Leave += new System.EventHandler(this.nomeTxtBox_Leave);
            // 
            // turmasLb
            // 
            this.turmasLb.AutoSize = true;
            this.turmasLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turmasLb.Location = new System.Drawing.Point(624, 209);
            this.turmasLb.Name = "turmasLb";
            this.turmasLb.Size = new System.Drawing.Size(109, 38);
            this.turmasLb.TabIndex = 164;
            this.turmasLb.Text = "Turmas";
            // 
            // turmasFlwLayPnl
            // 
            this.turmasFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.turmasFlwLayPnl.Location = new System.Drawing.Point(631, 267);
            this.turmasFlwLayPnl.Name = "turmasFlwLayPnl";
            this.turmasFlwLayPnl.Size = new System.Drawing.Size(342, 187);
            this.turmasFlwLayPnl.TabIndex = 162;
            this.turmasFlwLayPnl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.turmasFlwLayPnl_ControlRemoved);
            // 
            // disciplinasLb
            // 
            this.disciplinasLb.AutoSize = true;
            this.disciplinasLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinasLb.Location = new System.Drawing.Point(149, 209);
            this.disciplinasLb.Name = "disciplinasLb";
            this.disciplinasLb.Size = new System.Drawing.Size(153, 38);
            this.disciplinasLb.TabIndex = 161;
            this.disciplinasLb.Text = "Disciplinas";
            // 
            // disciplinasFlwLayPnl
            // 
            this.disciplinasFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.disciplinasFlwLayPnl.Location = new System.Drawing.Point(156, 267);
            this.disciplinasFlwLayPnl.Name = "disciplinasFlwLayPnl";
            this.disciplinasFlwLayPnl.Size = new System.Drawing.Size(342, 187);
            this.disciplinasFlwLayPnl.TabIndex = 159;
            this.disciplinasFlwLayPnl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.disciplinasFlwLayPnl_ControlRemoved);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(958, 513);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(142, 54);
            this.removeBtn.TabIndex = 158;
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
            this.concluirBtn.Location = new System.Drawing.Point(460, 491);
            this.concluirBtn.Name = "concluirBtn";
            this.concluirBtn.Size = new System.Drawing.Size(218, 92);
            this.concluirBtn.TabIndex = 157;
            this.concluirBtn.Text = "Concluir";
            this.concluirBtn.UseVisualStyleBackColor = false;
            this.concluirBtn.Click += new System.EventHandler(this.concluirBtn_Click);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.White;
            this.backPanel.Location = new System.Drawing.Point(1, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1201, 670);
            this.backPanel.TabIndex = 165;
            this.backPanel.Click += new System.EventHandler(this.backPanel_Click);
            // 
            // addTurmaBtn
            // 
            this.addTurmaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addTurmaBtn.FlatAppearance.BorderSize = 0;
            this.addTurmaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTurmaBtn.ForeColor = System.Drawing.Color.White;
            this.addTurmaBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addTurmaBtn.IconColor = System.Drawing.Color.White;
            this.addTurmaBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addTurmaBtn.IconSize = 40;
            this.addTurmaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTurmaBtn.Location = new System.Drawing.Point(925, 209);
            this.addTurmaBtn.Name = "addTurmaBtn";
            this.addTurmaBtn.Size = new System.Drawing.Size(48, 44);
            this.addTurmaBtn.TabIndex = 163;
            this.addTurmaBtn.UseVisualStyleBackColor = false;
            this.addTurmaBtn.Click += new System.EventHandler(this.addTurmaBtn_Click);
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
            this.addDisciplinaBtn.Location = new System.Drawing.Point(450, 209);
            this.addDisciplinaBtn.Name = "addDisciplinaBtn";
            this.addDisciplinaBtn.Size = new System.Drawing.Size(48, 44);
            this.addDisciplinaBtn.TabIndex = 160;
            this.addDisciplinaBtn.UseVisualStyleBackColor = false;
            this.addDisciplinaBtn.Click += new System.EventHandler(this.addDisciplinaBtn_Click);
            // 
            // EditarProfessor
            // 
            this.AcceptButton = this.concluirBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.addTurmaBtn);
            this.Controls.Add(this.turmasLb);
            this.Controls.Add(this.turmasFlwLayPnl);
            this.Controls.Add(this.addDisciplinaBtn);
            this.Controls.Add(this.disciplinasLb);
            this.Controls.Add(this.disciplinasFlwLayPnl);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.concluirBtn);
            this.Controls.Add(this.telCelTxtBox);
            this.Controls.Add(this.telResTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataNascTxtBox);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.rgTxtBox);
            this.Controls.Add(this.cpfTxtBox);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.backPanel);
            this.Name = "EditarProfessor";
            this.Text = "EditarProfessor";
            this.Load += new System.EventHandler(this.EditarProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox telCelTxtBox;
        private System.Windows.Forms.MaskedTextBox telResTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox dataNascTxtBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.MaskedTextBox rgTxtBox;
        private System.Windows.Forms.MaskedTextBox cpfTxtBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private FontAwesome.Sharp.IconButton addTurmaBtn;
        private System.Windows.Forms.Label turmasLb;
        private System.Windows.Forms.FlowLayoutPanel turmasFlwLayPnl;
        private FontAwesome.Sharp.IconButton addDisciplinaBtn;
        private System.Windows.Forms.Label disciplinasLb;
        private System.Windows.Forms.FlowLayoutPanel disciplinasFlwLayPnl;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button concluirBtn;
        private System.Windows.Forms.Panel backPanel;
    }
}