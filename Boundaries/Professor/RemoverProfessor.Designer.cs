
namespace SistemaEscola
{
    partial class RemoverProfessor
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
            this.professorComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleLb = new System.Windows.Forms.Label();
            this.professorLb = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // professorComboBox
            // 
            this.professorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.professorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professorComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professorComboBox.FormattingEnabled = true;
            this.professorComboBox.Location = new System.Drawing.Point(400, 264);
            this.professorComboBox.Name = "professorComboBox";
            this.professorComboBox.Size = new System.Drawing.Size(273, 30);
            this.professorComboBox.TabIndex = 144;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(398, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 34);
            this.panel2.TabIndex = 145;
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(264, 111);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(551, 38);
            this.titleLb.TabIndex = 143;
            this.titleLb.Text = "Selecione um professor para ser removido";
            // 
            // professorLb
            // 
            this.professorLb.AutoSize = true;
            this.professorLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professorLb.Location = new System.Drawing.Point(393, 211);
            this.professorLb.Name = "professorLb";
            this.professorLb.Size = new System.Drawing.Size(137, 38);
            this.professorLb.TabIndex = 142;
            this.professorLb.Text = "Professor";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(425, 400);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(218, 92);
            this.removeBtn.TabIndex = 141;
            this.removeBtn.Text = "Remover";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // RemoverProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.professorComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.professorLb);
            this.Controls.Add(this.removeBtn);
            this.Name = "RemoverProfessor";
            this.Text = "RemoverProfessor";
            this.Load += new System.EventHandler(this.RemoverProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox professorComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label professorLb;
        private System.Windows.Forms.Button removeBtn;
    }
}