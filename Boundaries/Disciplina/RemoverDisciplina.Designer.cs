
namespace SistemaEscola
{
    partial class RemoverDisciplina
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
            this.disciplinaComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleLb = new System.Windows.Forms.Label();
            this.disciplinaLb = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disciplinaComboBox
            // 
            this.disciplinaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplinaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplinaComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinaComboBox.FormattingEnabled = true;
            this.disciplinaComboBox.Location = new System.Drawing.Point(416, 267);
            this.disciplinaComboBox.Name = "disciplinaComboBox";
            this.disciplinaComboBox.Size = new System.Drawing.Size(273, 30);
            this.disciplinaComboBox.TabIndex = 144;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(414, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 34);
            this.panel2.TabIndex = 145;
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(269, 113);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(566, 38);
            this.titleLb.TabIndex = 143;
            this.titleLb.Text = "Selecione uma disciplina para ser removida";
            // 
            // disciplinaLb
            // 
            this.disciplinaLb.AutoSize = true;
            this.disciplinaLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinaLb.Location = new System.Drawing.Point(409, 214);
            this.disciplinaLb.Name = "disciplinaLb";
            this.disciplinaLb.Size = new System.Drawing.Size(140, 38);
            this.disciplinaLb.TabIndex = 142;
            this.disciplinaLb.Text = "Disciplina";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(445, 406);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(218, 92);
            this.removeBtn.TabIndex = 141;
            this.removeBtn.Text = "Remover";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // RemoverDisciplina
            // 
            this.AcceptButton = this.removeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.disciplinaComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.disciplinaLb);
            this.Controls.Add(this.removeBtn);
            this.Name = "RemoverDisciplina";
            this.Text = "RemoverDisciplina";
            this.Load += new System.EventHandler(this.RemoverDisciplina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox disciplinaComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label disciplinaLb;
        private System.Windows.Forms.Button removeBtn;
    }
}