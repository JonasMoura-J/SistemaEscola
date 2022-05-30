
namespace SistemaEscola
{
    partial class ConfirmDeletion
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
            this.removeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.title3 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.titleCustom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(90, 221);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(142, 54);
            this.removeBtn.TabIndex = 119;
            this.removeBtn.Text = "Remover";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(257, 221);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(142, 54);
            this.cancelBtn.TabIndex = 120;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // title3
            // 
            this.title3.AutoSize = true;
            this.title3.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3.Location = new System.Drawing.Point(114, 104);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(264, 38);
            this.title3.TabIndex = 136;
            this.title3.Text = "permanentemente?";
            // 
            // title1
            // 
            this.title1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(185, 23);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(125, 38);
            this.title1.TabIndex = 136;
            this.title1.Text = "Remover";
            // 
            // titleCustom
            // 
            this.titleCustom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleCustom.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCustom.Location = new System.Drawing.Point(-2, 64);
            this.titleCustom.Name = "titleCustom";
            this.titleCustom.Size = new System.Drawing.Size(495, 38);
            this.titleCustom.TabIndex = 137;
            this.titleCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmDeletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 290);
            this.Controls.Add(this.titleCustom);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.removeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConfirmDeletion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmDeletion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label titleCustom;
    }
}