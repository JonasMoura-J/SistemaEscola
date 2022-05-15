
namespace SistemaEscola
{
    partial class CadastrarDisciplina
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
            this.idLb = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.nomeLb = new System.Windows.Forms.Label();
            this.professoresTxtBox = new System.Windows.Forms.TextBox();
            this.professoresLb = new System.Windows.Forms.Label();
            this.enviarBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // idLb
            // 
            this.idLb.AutoSize = true;
            this.idLb.Location = new System.Drawing.Point(49, 56);
            this.idLb.Name = "idLb";
            this.idLb.Size = new System.Drawing.Size(16, 13);
            this.idLb.TabIndex = 0;
            this.idLb.Text = "Id";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(71, 53);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(210, 20);
            this.idTxtBox.TabIndex = 1;
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.Location = new System.Drawing.Point(90, 126);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(191, 20);
            this.nomeTxtBox.TabIndex = 3;
            // 
            // nomeLb
            // 
            this.nomeLb.AutoSize = true;
            this.nomeLb.Location = new System.Drawing.Point(49, 129);
            this.nomeLb.Name = "nomeLb";
            this.nomeLb.Size = new System.Drawing.Size(35, 13);
            this.nomeLb.TabIndex = 2;
            this.nomeLb.Text = "Nome";
            // 
            // professoresTxtBox
            // 
            this.professoresTxtBox.Location = new System.Drawing.Point(117, 197);
            this.professoresTxtBox.Name = "professoresTxtBox";
            this.professoresTxtBox.Size = new System.Drawing.Size(164, 20);
            this.professoresTxtBox.TabIndex = 5;
            // 
            // professoresLb
            // 
            this.professoresLb.AutoSize = true;
            this.professoresLb.Location = new System.Drawing.Point(49, 200);
            this.professoresLb.Name = "professoresLb";
            this.professoresLb.Size = new System.Drawing.Size(62, 13);
            this.professoresLb.TabIndex = 4;
            this.professoresLb.Text = "Professores";
            // 
            // enviarBtn
            // 
            this.enviarBtn.Location = new System.Drawing.Point(52, 299);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(135, 51);
            this.enviarBtn.TabIndex = 6;
            this.enviarBtn.Text = "enviar";
            this.enviarBtn.UseVisualStyleBackColor = true;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(521, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(521, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // CadastrarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.enviarBtn);
            this.Controls.Add(this.professoresTxtBox);
            this.Controls.Add(this.professoresLb);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.nomeLb);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.idLb);
            this.Name = "CadastrarDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarDisciplina";
            this.Load += new System.EventHandler(this.CadastrarDisciplina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLb;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.Label nomeLb;
        private System.Windows.Forms.TextBox professoresTxtBox;
        private System.Windows.Forms.Label professoresLb;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}