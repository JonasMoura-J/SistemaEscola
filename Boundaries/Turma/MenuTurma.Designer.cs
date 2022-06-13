
namespace SistemaEscola
{
    partial class MenuTurma
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
            this.avaliarBtn = new System.Windows.Forms.Button();
            this.listButn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.presencaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // avaliarBtn
            // 
            this.avaliarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.avaliarBtn.FlatAppearance.BorderSize = 0;
            this.avaliarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avaliarBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaliarBtn.ForeColor = System.Drawing.Color.White;
            this.avaliarBtn.Location = new System.Drawing.Point(605, 324);
            this.avaliarBtn.Name = "avaliarBtn";
            this.avaliarBtn.Size = new System.Drawing.Size(218, 92);
            this.avaliarBtn.TabIndex = 18;
            this.avaliarBtn.Text = "Avaliar";
            this.avaliarBtn.UseVisualStyleBackColor = false;
            // 
            // listButn
            // 
            this.listButn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.listButn.FlatAppearance.BorderSize = 0;
            this.listButn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButn.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listButn.ForeColor = System.Drawing.Color.White;
            this.listButn.Location = new System.Drawing.Point(444, 182);
            this.listButn.Name = "listButn";
            this.listButn.Size = new System.Drawing.Size(218, 92);
            this.listButn.TabIndex = 16;
            this.listButn.Text = "Listar";
            this.listButn.UseVisualStyleBackColor = false;
            this.listButn.Click += new System.EventHandler(this.listButn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(753, 182);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(218, 92);
            this.removeBtn.TabIndex = 15;
            this.removeBtn.Text = "Remover";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(133, 182);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(218, 92);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // presencaBtn
            // 
            this.presencaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.presencaBtn.FlatAppearance.BorderSize = 0;
            this.presencaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presencaBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presencaBtn.ForeColor = System.Drawing.Color.White;
            this.presencaBtn.Location = new System.Drawing.Point(287, 324);
            this.presencaBtn.Name = "presencaBtn";
            this.presencaBtn.Size = new System.Drawing.Size(218, 92);
            this.presencaBtn.TabIndex = 19;
            this.presencaBtn.Text = "Presença";
            this.presencaBtn.UseVisualStyleBackColor = false;
            this.presencaBtn.Click += new System.EventHandler(this.presencaBtn_Click);
            // 
            // MenuTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.presencaBtn);
            this.Controls.Add(this.avaliarBtn);
            this.Controls.Add(this.listButn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "MenuTurma";
            this.Text = "MenuTurma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button avaliarBtn;
        private System.Windows.Forms.Button listButn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button presencaBtn;
    }
}