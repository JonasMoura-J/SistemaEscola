
namespace SistemaEscola
{
    partial class SelectDisciplina
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
            this.titleLb = new System.Windows.Forms.Label();
            this.disciplinaLb = new System.Windows.Forms.Label();
            this.advanceBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // disciplinaComboBox
            // 
            this.disciplinaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplinaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplinaComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinaComboBox.FormattingEnabled = true;
            this.disciplinaComboBox.Location = new System.Drawing.Point(424, 267);
            this.disciplinaComboBox.Name = "disciplinaComboBox";
            this.disciplinaComboBox.Size = new System.Drawing.Size(273, 30);
            this.disciplinaComboBox.TabIndex = 149;
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(395, 113);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(328, 38);
            this.titleLb.TabIndex = 148;
            this.titleLb.Text = "Selecione uma disciplina";
            // 
            // disciplinaLb
            // 
            this.disciplinaLb.AutoSize = true;
            this.disciplinaLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinaLb.Location = new System.Drawing.Point(417, 202);
            this.disciplinaLb.Name = "disciplinaLb";
            this.disciplinaLb.Size = new System.Drawing.Size(140, 38);
            this.disciplinaLb.TabIndex = 147;
            this.disciplinaLb.Text = "Disciplina";
            // 
            // advanceBtn
            // 
            this.advanceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.advanceBtn.FlatAppearance.BorderSize = 0;
            this.advanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advanceBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advanceBtn.ForeColor = System.Drawing.Color.White;
            this.advanceBtn.Location = new System.Drawing.Point(451, 396);
            this.advanceBtn.Name = "advanceBtn";
            this.advanceBtn.Size = new System.Drawing.Size(218, 92);
            this.advanceBtn.TabIndex = 146;
            this.advanceBtn.Text = "Avançar";
            this.advanceBtn.UseVisualStyleBackColor = false;
            this.advanceBtn.Click += new System.EventHandler(this.advanceBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(422, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 34);
            this.panel2.TabIndex = 150;
            // 
            // SelectDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.disciplinaComboBox);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.disciplinaLb);
            this.Controls.Add(this.advanceBtn);
            this.Controls.Add(this.panel2);
            this.Name = "SelectDisciplina";
            this.Text = "SelectDisciplina";
            this.Load += new System.EventHandler(this.SelectDisciplina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox disciplinaComboBox;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label disciplinaLb;
        private System.Windows.Forms.Button advanceBtn;
        private System.Windows.Forms.Panel panel2;
    }
}