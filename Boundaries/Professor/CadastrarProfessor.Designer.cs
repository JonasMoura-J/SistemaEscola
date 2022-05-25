
namespace SistemaEscola
{
    partial class CadastrarProfessor
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
            this.addBtn = new System.Windows.Forms.Button();
            this.disciplinasLb = new System.Windows.Forms.Label();
            this.disciplinasFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addDisciplinaBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(905, 557);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Visible = false;
            // 
            // telCelTxtBox
            // 
            this.telCelTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telCelTxtBox.Culture = new System.Globalization.CultureInfo("");
            this.telCelTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.telCelTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.telCelTxtBox.Location = new System.Drawing.Point(387, 153);
            this.telCelTxtBox.Name = "telCelTxtBox";
            this.telCelTxtBox.PromptChar = ' ';
            this.telCelTxtBox.Size = new System.Drawing.Size(153, 24);
            this.telCelTxtBox.TabIndex = 93;
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
            this.telResTxtBox.Location = new System.Drawing.Point(166, 153);
            this.telResTxtBox.Name = "telResTxtBox";
            this.telResTxtBox.PromptChar = ' ';
            this.telResTxtBox.Size = new System.Drawing.Size(190, 24);
            this.telResTxtBox.TabIndex = 92;
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
            this.emailTxtBox.Location = new System.Drawing.Point(571, 153);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(375, 24);
            this.emailTxtBox.TabIndex = 74;
            this.emailTxtBox.Text = "E-mail";
            this.emailTxtBox.Enter += new System.EventHandler(this.emailTxtBox_Enter);
            this.emailTxtBox.Leave += new System.EventHandler(this.emailTxtBox_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel4.Location = new System.Drawing.Point(571, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 2);
            this.panel4.TabIndex = 78;
            // 
            // dataNascTxtBox
            // 
            this.dataNascTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNascTxtBox.Culture = new System.Globalization.CultureInfo("");
            this.dataNascTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.dataNascTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.dataNascTxtBox.Location = new System.Drawing.Point(164, 89);
            this.dataNascTxtBox.Name = "dataNascTxtBox";
            this.dataNascTxtBox.PromptChar = ' ';
            this.dataNascTxtBox.Size = new System.Drawing.Size(198, 24);
            this.dataNascTxtBox.TabIndex = 91;
            this.dataNascTxtBox.Text = "Data de Nascimento";
            this.dataNascTxtBox.ValidatingType = typeof(System.DateTime);
            this.dataNascTxtBox.Enter += new System.EventHandler(this.dataNascTxtBox_Enter);
            this.dataNascTxtBox.Leave += new System.EventHandler(this.dataNascTxtBox_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel7.Location = new System.Drawing.Point(387, 181);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(153, 2);
            this.panel7.TabIndex = 80;
            // 
            // rgTxtBox
            // 
            this.rgTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rgTxtBox.Culture = new System.Globalization.CultureInfo("");
            this.rgTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.rgTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.rgTxtBox.Location = new System.Drawing.Point(826, 27);
            this.rgTxtBox.Name = "rgTxtBox";
            this.rgTxtBox.PromptChar = ' ';
            this.rgTxtBox.Size = new System.Drawing.Size(120, 24);
            this.rgTxtBox.TabIndex = 90;
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
            this.cpfTxtBox.Location = new System.Drawing.Point(651, 27);
            this.cpfTxtBox.Name = "cpfTxtBox";
            this.cpfTxtBox.PromptChar = ' ';
            this.cpfTxtBox.Size = new System.Drawing.Size(140, 24);
            this.cpfTxtBox.TabIndex = 89;
            this.cpfTxtBox.Text = "CPF";
            this.cpfTxtBox.ValidatingType = typeof(System.DateTime);
            this.cpfTxtBox.Enter += new System.EventHandler(this.cpfTxtBox_Enter);
            this.cpfTxtBox.Leave += new System.EventHandler(this.cpfTxtBox_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel9.Location = new System.Drawing.Point(164, 118);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(192, 2);
            this.panel9.TabIndex = 84;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel6.Location = new System.Drawing.Point(166, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 2);
            this.panel6.TabIndex = 82;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel3.Location = new System.Drawing.Point(826, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 2);
            this.panel3.TabIndex = 79;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(651, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 2);
            this.panel2.TabIndex = 77;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(165, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 2);
            this.panel1.TabIndex = 73;
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nomeTxtBox.Location = new System.Drawing.Point(165, 27);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(448, 24);
            this.nomeTxtBox.TabIndex = 72;
            this.nomeTxtBox.Text = "Nome";
            this.nomeTxtBox.Enter += new System.EventHandler(this.nomeTxtBox_Enter);
            this.nomeTxtBox.Leave += new System.EventHandler(this.nomeTxtBox_Leave);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(449, 472);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(218, 92);
            this.addBtn.TabIndex = 94;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // disciplinasLb
            // 
            this.disciplinasLb.AutoSize = true;
            this.disciplinasLb.BackColor = System.Drawing.Color.White;
            this.disciplinasLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinasLb.Location = new System.Drawing.Point(384, 208);
            this.disciplinasLb.Name = "disciplinasLb";
            this.disciplinasLb.Size = new System.Drawing.Size(153, 38);
            this.disciplinasLb.TabIndex = 129;
            this.disciplinasLb.Text = "Disciplinas";
            this.disciplinasLb.Click += new System.EventHandler(this.disciplinasLb_Click);
            // 
            // disciplinasFlwLayPnl
            // 
            this.disciplinasFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.disciplinasFlwLayPnl.Location = new System.Drawing.Point(391, 264);
            this.disciplinasFlwLayPnl.Name = "disciplinasFlwLayPnl";
            this.disciplinasFlwLayPnl.Size = new System.Drawing.Size(338, 183);
            this.disciplinasFlwLayPnl.TabIndex = 127;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1148, 653);
            this.panel5.TabIndex = 130;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
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
            this.addDisciplinaBtn.Location = new System.Drawing.Point(681, 208);
            this.addDisciplinaBtn.Name = "addDisciplinaBtn";
            this.addDisciplinaBtn.Size = new System.Drawing.Size(48, 44);
            this.addDisciplinaBtn.TabIndex = 128;
            this.addDisciplinaBtn.UseVisualStyleBackColor = false;
            this.addDisciplinaBtn.Click += new System.EventHandler(this.addDisciplinaBtn_Click);
            // 
            // CadastrarProfessor
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.addDisciplinaBtn);
            this.Controls.Add(this.disciplinasLb);
            this.Controls.Add(this.disciplinasFlwLayPnl);
            this.Controls.Add(this.addBtn);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel5);
            this.Name = "CadastrarProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarProfessor";
            this.Load += new System.EventHandler(this.CadastrarProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.Button addBtn;
        private FontAwesome.Sharp.IconButton addDisciplinaBtn;
        private System.Windows.Forms.Label disciplinasLb;
        private System.Windows.Forms.FlowLayoutPanel disciplinasFlwLayPnl;
        private System.Windows.Forms.Panel panel5;
    }
}