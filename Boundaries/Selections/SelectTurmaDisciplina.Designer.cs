
namespace SistemaEscola
{
    partial class SelectTurmaDisciplina
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
            this.turmaLb = new System.Windows.Forms.Label();
            this.disciplinaLb = new System.Windows.Forms.Label();
            this.advanceBtn = new System.Windows.Forms.Button();
            this.titleLb = new System.Windows.Forms.Label();
            this.turmaComboBox = new System.Windows.Forms.ComboBox();
            this.disciplinaComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // turmaLb
            // 
            this.turmaLb.AutoSize = true;
            this.turmaLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turmaLb.Location = new System.Drawing.Point(225, 212);
            this.turmaLb.Name = "turmaLb";
            this.turmaLb.Size = new System.Drawing.Size(96, 38);
            this.turmaLb.TabIndex = 133;
            this.turmaLb.Text = "Turma";
            // 
            // disciplinaLb
            // 
            this.disciplinaLb.AutoSize = true;
            this.disciplinaLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinaLb.Location = new System.Drawing.Point(584, 212);
            this.disciplinaLb.Name = "disciplinaLb";
            this.disciplinaLb.Size = new System.Drawing.Size(140, 38);
            this.disciplinaLb.TabIndex = 130;
            this.disciplinaLb.Text = "Disciplina";
            // 
            // advanceBtn
            // 
            this.advanceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.advanceBtn.FlatAppearance.BorderSize = 0;
            this.advanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advanceBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advanceBtn.ForeColor = System.Drawing.Color.White;
            this.advanceBtn.Location = new System.Drawing.Point(436, 406);
            this.advanceBtn.Name = "advanceBtn";
            this.advanceBtn.Size = new System.Drawing.Size(218, 92);
            this.advanceBtn.TabIndex = 127;
            this.advanceBtn.Text = "Avançar";
            this.advanceBtn.UseVisualStyleBackColor = false;
            this.advanceBtn.Click += new System.EventHandler(this.advanceBtn_Click);
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(298, 112);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(496, 38);
            this.titleLb.TabIndex = 134;
            this.titleLb.Text = "Selecione uma turma e uma disciplina";
            // 
            // turmaComboBox
            // 
            this.turmaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turmaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turmaComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turmaComboBox.FormattingEnabled = true;
            this.turmaComboBox.Location = new System.Drawing.Point(232, 277);
            this.turmaComboBox.Name = "turmaComboBox";
            this.turmaComboBox.Size = new System.Drawing.Size(273, 30);
            this.turmaComboBox.TabIndex = 135;
            // 
            // disciplinaComboBox
            // 
            this.disciplinaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplinaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplinaComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinaComboBox.FormattingEnabled = true;
            this.disciplinaComboBox.Location = new System.Drawing.Point(591, 277);
            this.disciplinaComboBox.Name = "disciplinaComboBox";
            this.disciplinaComboBox.Size = new System.Drawing.Size(273, 30);
            this.disciplinaComboBox.TabIndex = 136;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(230, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 34);
            this.panel2.TabIndex = 137;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(589, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 34);
            this.panel1.TabIndex = 138;
            // 
            // SelectTurmaDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.disciplinaComboBox);
            this.Controls.Add(this.turmaComboBox);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.turmaLb);
            this.Controls.Add(this.disciplinaLb);
            this.Controls.Add(this.advanceBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SelectTurmaDisciplina";
            this.Text = "SelectTurmaDisciplina";
            this.Load += new System.EventHandler(this.SelectTurmaDisciplina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label turmaLb;
        private System.Windows.Forms.Label disciplinaLb;
        private System.Windows.Forms.Button advanceBtn;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.ComboBox turmaComboBox;
        private System.Windows.Forms.ComboBox disciplinaComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}