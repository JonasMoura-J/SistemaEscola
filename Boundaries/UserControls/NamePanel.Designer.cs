
namespace SistemaEscola
{
    partial class NamePanel
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.ForeColor = System.Drawing.Color.White;
            this.nameLb.Location = new System.Drawing.Point(55, 14);
            this.nameLb.Margin = new System.Windows.Forms.Padding(3);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(0, 22);
            this.nameLb.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = global::SistemaEscola.Properties.Resources.x_icon4;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteBtn.Location = new System.Drawing.Point(0, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(52, 51);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AlunoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.deleteBtn);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 51);
            this.MinimumSize = new System.Drawing.Size(0, 51);
            this.Name = "AlunoPanel";
            this.Size = new System.Drawing.Size(58, 51);
            this.MouseEnter += new System.EventHandler(this.NamePanel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NamePanel_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Button deleteBtn;
    }
}
