
namespace SistemaEscola
{
    partial class AddFromList
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
            this.addBtn = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(73, 368);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(142, 54);
            this.addBtn.TabIndex = 118;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(12, 10);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(266, 338);
            this.checkedListBox.TabIndex = 119;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(10, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 342);
            this.panel2.TabIndex = 120;
            // 
            // AddFromList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 433);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel2);
            this.Name = "AddFromList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFromList";
            this.Load += new System.EventHandler(this.AddFromList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Panel panel2;
    }
}