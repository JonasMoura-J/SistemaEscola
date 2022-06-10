
namespace SistemaEscola
{
    partial class MostrarDisciplina
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
            this.turmasLb = new System.Windows.Forms.Label();
            this.turmasFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.professoresLb = new System.Windows.Forms.Label();
            this.professoresFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.concluirBtn = new System.Windows.Forms.Button();
            this.nomeLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // turmasLb
            // 
            this.turmasLb.AutoSize = true;
            this.turmasLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turmasLb.Location = new System.Drawing.Point(610, 108);
            this.turmasLb.Name = "turmasLb";
            this.turmasLb.Size = new System.Drawing.Size(109, 38);
            this.turmasLb.TabIndex = 162;
            this.turmasLb.Text = "Turmas";
            // 
            // turmasFlwLayPnl
            // 
            this.turmasFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.turmasFlwLayPnl.Location = new System.Drawing.Point(617, 173);
            this.turmasFlwLayPnl.Name = "turmasFlwLayPnl";
            this.turmasFlwLayPnl.Size = new System.Drawing.Size(342, 258);
            this.turmasFlwLayPnl.TabIndex = 161;
            // 
            // professoresLb
            // 
            this.professoresLb.AutoSize = true;
            this.professoresLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professoresLb.Location = new System.Drawing.Point(135, 108);
            this.professoresLb.Name = "professoresLb";
            this.professoresLb.Size = new System.Drawing.Size(164, 38);
            this.professoresLb.TabIndex = 160;
            this.professoresLb.Text = "Professores";
            // 
            // professoresFlwLayPnl
            // 
            this.professoresFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.professoresFlwLayPnl.Location = new System.Drawing.Point(142, 173);
            this.professoresFlwLayPnl.Name = "professoresFlwLayPnl";
            this.professoresFlwLayPnl.Size = new System.Drawing.Size(342, 258);
            this.professoresFlwLayPnl.TabIndex = 159;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(325, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 2);
            this.panel1.TabIndex = 158;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(969, 498);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(134, 59);
            this.editBtn.TabIndex = 189;
            this.editBtn.Text = "Editar";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // concluirBtn
            // 
            this.concluirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.concluirBtn.FlatAppearance.BorderSize = 0;
            this.concluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concluirBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concluirBtn.ForeColor = System.Drawing.Color.White;
            this.concluirBtn.Location = new System.Drawing.Point(446, 478);
            this.concluirBtn.Name = "concluirBtn";
            this.concluirBtn.Size = new System.Drawing.Size(218, 92);
            this.concluirBtn.TabIndex = 188;
            this.concluirBtn.Text = "Concluir";
            this.concluirBtn.UseVisualStyleBackColor = false;
            this.concluirBtn.Click += new System.EventHandler(this.concluirBtn_Click);
            // 
            // nomeLb
            // 
            this.nomeLb.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.nomeLb.Location = new System.Drawing.Point(321, 42);
            this.nomeLb.Name = "nomeLb";
            this.nomeLb.Size = new System.Drawing.Size(450, 23);
            this.nomeLb.TabIndex = 190;
            this.nomeLb.Text = "Nome";
            // 
            // MostrarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.nomeLb);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.concluirBtn);
            this.Controls.Add(this.turmasLb);
            this.Controls.Add(this.turmasFlwLayPnl);
            this.Controls.Add(this.professoresLb);
            this.Controls.Add(this.professoresFlwLayPnl);
            this.Controls.Add(this.panel1);
            this.Name = "MostrarDisciplina";
            this.Text = "MostrarDisciplina";
            this.Load += new System.EventHandler(this.MostrarDisciplina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label turmasLb;
        private System.Windows.Forms.FlowLayoutPanel turmasFlwLayPnl;
        private System.Windows.Forms.Label professoresLb;
        private System.Windows.Forms.FlowLayoutPanel professoresFlwLayPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button concluirBtn;
        private System.Windows.Forms.Label nomeLb;
    }
}