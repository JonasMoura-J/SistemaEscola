
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
            this.enviarBtn = new System.Windows.Forms.Button();
            this.quantTxtBox = new System.Windows.Forms.TextBox();
            this.quantLb = new System.Windows.Forms.Label();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.nomeLb = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.idLb = new System.Windows.Forms.Label();
            this.codigoTxtBox = new System.Windows.Forms.TextBox();
            this.codigoLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // enviarBtn
            // 
            this.enviarBtn.Location = new System.Drawing.Point(54, 301);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(135, 51);
            this.enviarBtn.TabIndex = 14;
            this.enviarBtn.Text = "enviar";
            this.enviarBtn.UseVisualStyleBackColor = true;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // quantTxtBox
            // 
            this.quantTxtBox.Location = new System.Drawing.Point(168, 199);
            this.quantTxtBox.Name = "quantTxtBox";
            this.quantTxtBox.Size = new System.Drawing.Size(115, 20);
            this.quantTxtBox.TabIndex = 13;
            // 
            // quantLb
            // 
            this.quantLb.AutoSize = true;
            this.quantLb.Location = new System.Drawing.Point(51, 202);
            this.quantLb.Name = "quantLb";
            this.quantLb.Size = new System.Drawing.Size(111, 13);
            this.quantLb.TabIndex = 12;
            this.quantLb.Text = "Quantidade de alunos";
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.Location = new System.Drawing.Point(92, 155);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(191, 20);
            this.nomeTxtBox.TabIndex = 11;
            // 
            // nomeLb
            // 
            this.nomeLb.AutoSize = true;
            this.nomeLb.Location = new System.Drawing.Point(51, 158);
            this.nomeLb.Name = "nomeLb";
            this.nomeLb.Size = new System.Drawing.Size(35, 13);
            this.nomeLb.TabIndex = 10;
            this.nomeLb.Text = "Nome";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(73, 55);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(210, 20);
            this.idTxtBox.TabIndex = 9;
            // 
            // idLb
            // 
            this.idLb.AutoSize = true;
            this.idLb.Location = new System.Drawing.Point(51, 58);
            this.idLb.Name = "idLb";
            this.idLb.Size = new System.Drawing.Size(16, 13);
            this.idLb.TabIndex = 8;
            this.idLb.Text = "Id";
            // 
            // codigoTxtBox
            // 
            this.codigoTxtBox.Location = new System.Drawing.Point(92, 106);
            this.codigoTxtBox.Name = "codigoTxtBox";
            this.codigoTxtBox.Size = new System.Drawing.Size(191, 20);
            this.codigoTxtBox.TabIndex = 17;
            // 
            // codigoLb
            // 
            this.codigoLb.AutoSize = true;
            this.codigoLb.Location = new System.Drawing.Point(51, 109);
            this.codigoLb.Name = "codigoLb";
            this.codigoLb.Size = new System.Drawing.Size(40, 13);
            this.codigoLb.TabIndex = 16;
            this.codigoLb.Text = "Codigo";
            // 
            // CadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codigoTxtBox);
            this.Controls.Add(this.codigoLb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.enviarBtn);
            this.Controls.Add(this.quantTxtBox);
            this.Controls.Add(this.quantLb);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.nomeLb);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.idLb);
            this.Name = "CadastrarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarTurma";
            this.Load += new System.EventHandler(this.CadastrarTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.TextBox quantTxtBox;
        private System.Windows.Forms.Label quantLb;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.Label nomeLb;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label idLb;
        private System.Windows.Forms.TextBox codigoTxtBox;
        private System.Windows.Forms.Label codigoLb;
    }
}