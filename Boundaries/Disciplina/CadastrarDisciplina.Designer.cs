
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cadDisBackPanel = new System.Windows.Forms.Panel();
            this.cadDisBackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(330, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 2);
            this.panel1.TabIndex = 59;
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nomeTxtBox.Location = new System.Drawing.Point(330, 241);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(448, 24);
            this.nomeTxtBox.TabIndex = 58;
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
            this.addBtn.Location = new System.Drawing.Point(443, 386);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(218, 92);
            this.addBtn.TabIndex = 60;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cadDisBackPanel
            // 
            this.cadDisBackPanel.BackColor = System.Drawing.Color.White;
            this.cadDisBackPanel.Controls.Add(this.panel1);
            this.cadDisBackPanel.Controls.Add(this.addBtn);
            this.cadDisBackPanel.Controls.Add(this.nomeTxtBox);
            this.cadDisBackPanel.Location = new System.Drawing.Point(0, 0);
            this.cadDisBackPanel.Name = "cadDisBackPanel";
            this.cadDisBackPanel.Size = new System.Drawing.Size(1143, 637);
            this.cadDisBackPanel.TabIndex = 73;
            this.cadDisBackPanel.Click += new System.EventHandler(this.cadDisBackPanel_Click);
            // 
            // CadastrarDisciplina
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.cadDisBackPanel);
            this.Name = "CadastrarDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarDisciplina";
            this.cadDisBackPanel.ResumeLayout(false);
            this.cadDisBackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel cadDisBackPanel;
    }
}