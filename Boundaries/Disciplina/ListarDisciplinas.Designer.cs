
namespace SistemaEscola
{
    partial class ListarDisciplinas
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
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.titleLb = new System.Windows.Forms.Label();
            this.concluirBtn = new System.Windows.Forms.Button();
            this.disciplinasFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(666, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 2);
            this.panel1.TabIndex = 146;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.searchTxtBox.Location = new System.Drawing.Point(666, 39);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(342, 24);
            this.searchTxtBox.TabIndex = 145;
            this.searchTxtBox.Text = "Buscar";
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            this.searchTxtBox.Enter += new System.EventHandler(this.searchTxtBox_Enter);
            this.searchTxtBox.Leave += new System.EventHandler(this.searchTxtBox_Leave);
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(93, 26);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(383, 38);
            this.titleLb.TabIndex = 144;
            this.titleLb.Text = "Listando todas as disciplinas";
            // 
            // concluirBtn
            // 
            this.concluirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.concluirBtn.FlatAppearance.BorderSize = 0;
            this.concluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concluirBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concluirBtn.ForeColor = System.Drawing.Color.White;
            this.concluirBtn.Location = new System.Drawing.Point(451, 486);
            this.concluirBtn.Name = "concluirBtn";
            this.concluirBtn.Size = new System.Drawing.Size(218, 92);
            this.concluirBtn.TabIndex = 143;
            this.concluirBtn.Text = "Concluir";
            this.concluirBtn.UseVisualStyleBackColor = false;
            this.concluirBtn.Click += new System.EventHandler(this.concluirBtn_Click);
            // 
            // disciplinasFlwLayPnl
            // 
            this.disciplinasFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.disciplinasFlwLayPnl.Location = new System.Drawing.Point(100, 87);
            this.disciplinasFlwLayPnl.Name = "disciplinasFlwLayPnl";
            this.disciplinasFlwLayPnl.Size = new System.Drawing.Size(908, 387);
            this.disciplinasFlwLayPnl.TabIndex = 142;
            // 
            // ListarDisciplinas
            // 
            this.AcceptButton = this.concluirBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.concluirBtn);
            this.Controls.Add(this.disciplinasFlwLayPnl);
            this.Name = "ListarDisciplinas";
            this.Text = "ListarDisciplinas";
            this.Load += new System.EventHandler(this.ListarDisciplinas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Button concluirBtn;
        private System.Windows.Forms.FlowLayoutPanel disciplinasFlwLayPnl;
    }
}