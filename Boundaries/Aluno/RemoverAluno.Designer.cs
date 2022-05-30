
namespace SistemaEscola
{
    partial class RemoverAluno
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
            this.alunoLb = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.alunoComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(312, 109);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(500, 38);
            this.titleLb.TabIndex = 138;
            this.titleLb.Text = "Selecione um aluno para ser removido";
            // 
            // alunoLb
            // 
            this.alunoLb.AutoSize = true;
            this.alunoLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunoLb.Location = new System.Drawing.Point(408, 210);
            this.alunoLb.Name = "alunoLb";
            this.alunoLb.Size = new System.Drawing.Size(89, 38);
            this.alunoLb.TabIndex = 137;
            this.alunoLb.Text = "Aluno";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(444, 402);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(218, 92);
            this.removeBtn.TabIndex = 136;
            this.removeBtn.Text = "Remover";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // alunoComboBox
            // 
            this.alunoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alunoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alunoComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunoComboBox.FormattingEnabled = true;
            this.alunoComboBox.Location = new System.Drawing.Point(415, 263);
            this.alunoComboBox.Name = "alunoComboBox";
            this.alunoComboBox.Size = new System.Drawing.Size(273, 30);
            this.alunoComboBox.TabIndex = 139;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(413, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 34);
            this.panel2.TabIndex = 140;
            // 
            // RemoverAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.alunoComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.alunoLb);
            this.Controls.Add(this.removeBtn);
            this.Name = "RemoverAluno";
            this.Text = "RemoverAluno";
            this.Load += new System.EventHandler(this.RemoverAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label alunoLb;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ComboBox alunoComboBox;
        private System.Windows.Forms.Panel panel2;
    }
}