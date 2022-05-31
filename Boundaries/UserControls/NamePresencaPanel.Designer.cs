
namespace SistemaEscola
{
    partial class NamePresencaPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLb = new System.Windows.Forms.Label();
            this.presenteRBtn = new System.Windows.Forms.RadioButton();
            this.ausenteRBtn = new System.Windows.Forms.RadioButton();
            this.justificadoRBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.nameLb.ForeColor = System.Drawing.Color.White;
            this.nameLb.Location = new System.Drawing.Point(352, 16);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(0, 22);
            this.nameLb.TabIndex = 0;
            // 
            // presenteRBtn
            // 
            this.presenteRBtn.AutoSize = true;
            this.presenteRBtn.Checked = true;
            this.presenteRBtn.FlatAppearance.BorderSize = 0;
            this.presenteRBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presenteRBtn.ForeColor = System.Drawing.Color.White;
            this.presenteRBtn.Location = new System.Drawing.Point(14, 15);
            this.presenteRBtn.Name = "presenteRBtn";
            this.presenteRBtn.Size = new System.Drawing.Size(93, 23);
            this.presenteRBtn.TabIndex = 4;
            this.presenteRBtn.TabStop = true;
            this.presenteRBtn.Text = "Presente";
            this.presenteRBtn.UseVisualStyleBackColor = true;
            // 
            // ausenteRBtn
            // 
            this.ausenteRBtn.AutoSize = true;
            this.ausenteRBtn.FlatAppearance.BorderSize = 0;
            this.ausenteRBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausenteRBtn.ForeColor = System.Drawing.Color.White;
            this.ausenteRBtn.Location = new System.Drawing.Point(113, 15);
            this.ausenteRBtn.Name = "ausenteRBtn";
            this.ausenteRBtn.Size = new System.Drawing.Size(89, 23);
            this.ausenteRBtn.TabIndex = 5;
            this.ausenteRBtn.TabStop = true;
            this.ausenteRBtn.Text = "Ausente";
            this.ausenteRBtn.UseVisualStyleBackColor = true;
            // 
            // justificadoRBtn
            // 
            this.justificadoRBtn.AutoSize = true;
            this.justificadoRBtn.FlatAppearance.BorderSize = 0;
            this.justificadoRBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justificadoRBtn.ForeColor = System.Drawing.Color.White;
            this.justificadoRBtn.Location = new System.Drawing.Point(208, 15);
            this.justificadoRBtn.Name = "justificadoRBtn";
            this.justificadoRBtn.Size = new System.Drawing.Size(108, 23);
            this.justificadoRBtn.TabIndex = 6;
            this.justificadoRBtn.TabStop = true;
            this.justificadoRBtn.Text = "Justificado";
            this.justificadoRBtn.UseVisualStyleBackColor = true;
            // 
            // NamePresencaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.justificadoRBtn);
            this.Controls.Add(this.ausenteRBtn);
            this.Controls.Add(this.presenteRBtn);
            this.Controls.Add(this.nameLb);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Name = "NamePresencaPanel";
            this.Size = new System.Drawing.Size(355, 51);
            this.MouseEnter += new System.EventHandler(this.NamePresencaPanel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NamePresencaPanel_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.RadioButton presenteRBtn;
        private System.Windows.Forms.RadioButton ausenteRBtn;
        private System.Windows.Forms.RadioButton justificadoRBtn;
    }
}
