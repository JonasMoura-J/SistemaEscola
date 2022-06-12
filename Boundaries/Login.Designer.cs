
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title1Lb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.senhaTxtBox = new System.Windows.Forms.TextBox();
            this.title2Lb = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(292, 429);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(232, 37);
            this.loginBtn.TabIndex = 60;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.title1Lb);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 552);
            this.panel1.TabIndex = 62;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // title1Lb
            // 
            this.title1Lb.AutoSize = true;
            this.title1Lb.BackColor = System.Drawing.Color.Transparent;
            this.title1Lb.Font = new System.Drawing.Font("Harvest", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1Lb.ForeColor = System.Drawing.Color.White;
            this.title1Lb.Location = new System.Drawing.Point(-2, 40);
            this.title1Lb.Name = "title1Lb";
            this.title1Lb.Size = new System.Drawing.Size(251, 53);
            this.title1Lb.TabIndex = 0;
            this.title1Lb.Text = "Bem-vindo!";
            this.title1Lb.Click += new System.EventHandler(this.title1Lb_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(292, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 1);
            this.panel2.TabIndex = 64;
            // 
            // userTxtBox
            // 
            this.userTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.userTxtBox.Location = new System.Drawing.Point(292, 190);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(232, 24);
            this.userTxtBox.TabIndex = 63;
            this.userTxtBox.Text = "Usuário";
            this.userTxtBox.Enter += new System.EventHandler(this.userTxtBox_Enter);
            this.userTxtBox.Leave += new System.EventHandler(this.userTxtBox_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.panel3.Location = new System.Drawing.Point(292, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 1);
            this.panel3.TabIndex = 66;
            // 
            // senhaTxtBox
            // 
            this.senhaTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.senhaTxtBox.Location = new System.Drawing.Point(292, 299);
            this.senhaTxtBox.Name = "senhaTxtBox";
            this.senhaTxtBox.Size = new System.Drawing.Size(232, 24);
            this.senhaTxtBox.TabIndex = 65;
            this.senhaTxtBox.Text = "Senha";
            this.senhaTxtBox.Enter += new System.EventHandler(this.senhaTxtBox_Enter);
            this.senhaTxtBox.Leave += new System.EventHandler(this.senhaTxtBox_Leave);
            // 
            // title2Lb
            // 
            this.title2Lb.AutoSize = true;
            this.title2Lb.BackColor = System.Drawing.Color.Transparent;
            this.title2Lb.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2Lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.title2Lb.Location = new System.Drawing.Point(340, 44);
            this.title2Lb.Name = "title2Lb";
            this.title2Lb.Size = new System.Drawing.Size(131, 48);
            this.title2Lb.TabIndex = 67;
            this.title2Lb.Text = "Log in";
            this.title2Lb.Click += new System.EventHandler(this.title2Lb_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(227, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 552);
            this.panel4.TabIndex = 68;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 552);
            this.Controls.Add(this.title2Lb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.senhaTxtBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox senhaTxtBox;
        private System.Windows.Forms.Label title1Lb;
        private System.Windows.Forms.Label title2Lb;
        private System.Windows.Forms.Panel panel4;
    }
}