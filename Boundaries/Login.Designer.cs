
namespace SistemaEscola
{
    partial class Login
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
            this.entrarBtn = new System.Windows.Forms.Button();
            this.senhaTxtBox = new System.Windows.Forms.TextBox();
            this.senhaLb = new System.Windows.Forms.Label();
            this.usuarioTxtBox = new System.Windows.Forms.TextBox();
            this.usuarioLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 61;
            // 
            // entrarBtn
            // 
            this.entrarBtn.Location = new System.Drawing.Point(58, 166);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(135, 51);
            this.entrarBtn.TabIndex = 60;
            this.entrarBtn.Text = "entrar";
            this.entrarBtn.UseVisualStyleBackColor = true;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // senhaTxtBox
            // 
            this.senhaTxtBox.Location = new System.Drawing.Point(104, 95);
            this.senhaTxtBox.Name = "senhaTxtBox";
            this.senhaTxtBox.Size = new System.Drawing.Size(183, 20);
            this.senhaTxtBox.TabIndex = 59;
            // 
            // senhaLb
            // 
            this.senhaLb.AutoSize = true;
            this.senhaLb.Location = new System.Drawing.Point(55, 98);
            this.senhaLb.Name = "senhaLb";
            this.senhaLb.Size = new System.Drawing.Size(38, 13);
            this.senhaLb.TabIndex = 58;
            this.senhaLb.Text = "Senha";
            // 
            // usuarioTxtBox
            // 
            this.usuarioTxtBox.Location = new System.Drawing.Point(104, 54);
            this.usuarioTxtBox.Name = "usuarioTxtBox";
            this.usuarioTxtBox.Size = new System.Drawing.Size(183, 20);
            this.usuarioTxtBox.TabIndex = 57;
            // 
            // usuarioLb
            // 
            this.usuarioLb.AutoSize = true;
            this.usuarioLb.Location = new System.Drawing.Point(55, 57);
            this.usuarioLb.Name = "usuarioLb";
            this.usuarioLb.Size = new System.Drawing.Size(43, 13);
            this.usuarioLb.TabIndex = 56;
            this.usuarioLb.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 267);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.senhaTxtBox);
            this.Controls.Add(this.senhaLb);
            this.Controls.Add(this.usuarioTxtBox);
            this.Controls.Add(this.usuarioLb);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.TextBox senhaTxtBox;
        private System.Windows.Forms.Label senhaLb;
        private System.Windows.Forms.TextBox usuarioTxtBox;
        private System.Windows.Forms.Label usuarioLb;
    }
}