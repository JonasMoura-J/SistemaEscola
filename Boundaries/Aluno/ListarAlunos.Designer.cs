
namespace SistemaEscola
{
    partial class ListarAlunos
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
            this.titleLb = new System.Windows.Forms.Label();
            this.concluirBtn = new System.Windows.Forms.Button();
            this.alunosFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(93, 26);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(333, 38);
            this.titleLb.TabIndex = 139;
            this.titleLb.Text = "Listando todos os alunos";
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
            this.concluirBtn.TabIndex = 138;
            this.concluirBtn.Text = "Concluir";
            this.concluirBtn.UseVisualStyleBackColor = false;
            this.concluirBtn.Click += new System.EventHandler(this.concluirBtn_Click);
            // 
            // alunosFlwLayPnl
            // 
            this.alunosFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.alunosFlwLayPnl.Location = new System.Drawing.Point(100, 87);
            this.alunosFlwLayPnl.Name = "alunosFlwLayPnl";
            this.alunosFlwLayPnl.Size = new System.Drawing.Size(908, 387);
            this.alunosFlwLayPnl.TabIndex = 137;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(666, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 2);
            this.panel1.TabIndex = 141;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.searchTxtBox.Location = new System.Drawing.Point(666, 39);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(342, 24);
            this.searchTxtBox.TabIndex = 140;
            this.searchTxtBox.Text = "Buscar";
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            this.searchTxtBox.Enter += new System.EventHandler(this.searchTxtBox_Enter);
            this.searchTxtBox.Leave += new System.EventHandler(this.searchTxtBox_Leave);
            // 
            // ListarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.concluirBtn);
            this.Controls.Add(this.alunosFlwLayPnl);
            this.Name = "ListarAlunos";
            this.Text = "ListarAlunos";
            this.Load += new System.EventHandler(this.ListarAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Button concluirBtn;
        private System.Windows.Forms.FlowLayoutPanel alunosFlwLayPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTxtBox;
    }
}