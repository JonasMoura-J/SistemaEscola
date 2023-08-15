
namespace SistemaEscola
{
    partial class Presenca
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
            this.alunosFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.concluirBtn = new System.Windows.Forms.Button();
            this.titleLb = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // alunosFlwLayPnl
            // 
            this.alunosFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.alunosFlwLayPnl.Location = new System.Drawing.Point(97, 81);
            this.alunosFlwLayPnl.Name = "alunosFlwLayPnl";
            this.alunosFlwLayPnl.Size = new System.Drawing.Size(908, 387);
            this.alunosFlwLayPnl.TabIndex = 119;
            // 
            // concluirBtn
            // 
            this.concluirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.concluirBtn.FlatAppearance.BorderSize = 0;
            this.concluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concluirBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concluirBtn.ForeColor = System.Drawing.Color.White;
            this.concluirBtn.Location = new System.Drawing.Point(448, 480);
            this.concluirBtn.Name = "concluirBtn";
            this.concluirBtn.Size = new System.Drawing.Size(218, 92);
            this.concluirBtn.TabIndex = 120;
            this.concluirBtn.Text = "Concluir";
            this.concluirBtn.UseVisualStyleBackColor = false;
            this.concluirBtn.Click += new System.EventHandler(this.concluirBtn_Click);
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(90, 20);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(378, 38);
            this.titleLb.TabIndex = 135;
            this.titleLb.Text = "Insira a presença dos alunos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(855, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 28);
            this.dateTimePicker1.TabIndex = 136;
            // 
            // Presenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.concluirBtn);
            this.Controls.Add(this.alunosFlwLayPnl);
            this.Name = "Presenca";
            this.Text = "Presenca";
            this.Load += new System.EventHandler(this.Presenca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel alunosFlwLayPnl;
        private System.Windows.Forms.Button concluirBtn;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}