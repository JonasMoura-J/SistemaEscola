
namespace SistemaEscola
{
    partial class NameEditListPanel
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
            this.detailsBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.ForeColor = System.Drawing.Color.White;
            this.nameLb.Location = new System.Drawing.Point(116, 14);
            this.nameLb.Margin = new System.Windows.Forms.Padding(3);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(0, 22);
            this.nameLb.TabIndex = 3;
            // 
            // detailsBtn
            // 
            this.detailsBtn.BackgroundImage = global::SistemaEscola.Properties.Resources.details_icon;
            this.detailsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.detailsBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsBtn.FlatAppearance.BorderSize = 0;
            this.detailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsBtn.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.detailsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.detailsBtn.Location = new System.Drawing.Point(52, 0);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(52, 51);
            this.detailsBtn.TabIndex = 4;
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = global::SistemaEscola.Properties.Resources.edit_icon;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.Transparent;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editBtn.Location = new System.Drawing.Point(0, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(52, 51);
            this.editBtn.TabIndex = 2;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // NameEditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.editBtn);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Name = "NameEditPanel";
            this.Size = new System.Drawing.Size(125, 51);
            this.MouseEnter += new System.EventHandler(this.NameEditPanel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NameEditPanel_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Button detailsBtn;
    }
}
