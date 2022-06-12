
namespace SistemaEscola
{
    partial class EditarDisciplina
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.concluirBtn = new System.Windows.Forms.Button();
            this.addProfessorBtn = new FontAwesome.Sharp.IconButton();
            this.professoresLb = new System.Windows.Forms.Label();
            this.professoresFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.addTurmaBtn = new FontAwesome.Sharp.IconButton();
            this.turmasLb = new System.Windows.Forms.Label();
            this.turmasFlwLayPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.backPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(323, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 2);
            this.panel1.TabIndex = 146;
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeTxtBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxtBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nomeTxtBox.Location = new System.Drawing.Point(323, 51);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(448, 24);
            this.nomeTxtBox.TabIndex = 144;
            this.nomeTxtBox.Text = "Nome";
            this.nomeTxtBox.Enter += new System.EventHandler(this.nomeTxtBox_Enter);
            this.nomeTxtBox.Leave += new System.EventHandler(this.nomeTxtBox_Leave);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(942, 501);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(142, 54);
            this.removeBtn.TabIndex = 147;
            this.removeBtn.Text = "Remover";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // concluirBtn
            // 
            this.concluirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.concluirBtn.FlatAppearance.BorderSize = 0;
            this.concluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concluirBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concluirBtn.ForeColor = System.Drawing.Color.White;
            this.concluirBtn.Location = new System.Drawing.Point(444, 479);
            this.concluirBtn.Name = "concluirBtn";
            this.concluirBtn.Size = new System.Drawing.Size(218, 92);
            this.concluirBtn.TabIndex = 145;
            this.concluirBtn.Text = "Concluir";
            this.concluirBtn.UseVisualStyleBackColor = false;
            this.concluirBtn.Click += new System.EventHandler(this.concluirBtn_Click);
            // 
            // addProfessorBtn
            // 
            this.addProfessorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addProfessorBtn.FlatAppearance.BorderSize = 0;
            this.addProfessorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProfessorBtn.ForeColor = System.Drawing.Color.White;
            this.addProfessorBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addProfessorBtn.IconColor = System.Drawing.Color.White;
            this.addProfessorBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addProfessorBtn.IconSize = 40;
            this.addProfessorBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addProfessorBtn.Location = new System.Drawing.Point(434, 119);
            this.addProfessorBtn.Name = "addProfessorBtn";
            this.addProfessorBtn.Size = new System.Drawing.Size(48, 44);
            this.addProfessorBtn.TabIndex = 152;
            this.addProfessorBtn.UseVisualStyleBackColor = false;
            this.addProfessorBtn.Click += new System.EventHandler(this.addProfessorBtn_Click);
            // 
            // professoresLb
            // 
            this.professoresLb.AutoSize = true;
            this.professoresLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professoresLb.Location = new System.Drawing.Point(133, 119);
            this.professoresLb.Name = "professoresLb";
            this.professoresLb.Size = new System.Drawing.Size(164, 38);
            this.professoresLb.TabIndex = 153;
            this.professoresLb.Text = "Professores";
            // 
            // professoresFlwLayPnl
            // 
            this.professoresFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.professoresFlwLayPnl.Location = new System.Drawing.Point(140, 184);
            this.professoresFlwLayPnl.Name = "professoresFlwLayPnl";
            this.professoresFlwLayPnl.Size = new System.Drawing.Size(342, 258);
            this.professoresFlwLayPnl.TabIndex = 151;
            this.professoresFlwLayPnl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.professoresFlwLayPnl_ControlRemoved);
            // 
            // addTurmaBtn
            // 
            this.addTurmaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.addTurmaBtn.FlatAppearance.BorderSize = 0;
            this.addTurmaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTurmaBtn.ForeColor = System.Drawing.Color.White;
            this.addTurmaBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addTurmaBtn.IconColor = System.Drawing.Color.White;
            this.addTurmaBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addTurmaBtn.IconSize = 40;
            this.addTurmaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTurmaBtn.Location = new System.Drawing.Point(909, 119);
            this.addTurmaBtn.Name = "addTurmaBtn";
            this.addTurmaBtn.Size = new System.Drawing.Size(48, 44);
            this.addTurmaBtn.TabIndex = 155;
            this.addTurmaBtn.UseVisualStyleBackColor = false;
            this.addTurmaBtn.Click += new System.EventHandler(this.addTurmaBtn_Click);
            // 
            // turmasLb
            // 
            this.turmasLb.AutoSize = true;
            this.turmasLb.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turmasLb.Location = new System.Drawing.Point(608, 119);
            this.turmasLb.Name = "turmasLb";
            this.turmasLb.Size = new System.Drawing.Size(109, 38);
            this.turmasLb.TabIndex = 156;
            this.turmasLb.Text = "Turmas";
            // 
            // turmasFlwLayPnl
            // 
            this.turmasFlwLayPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.turmasFlwLayPnl.Location = new System.Drawing.Point(615, 184);
            this.turmasFlwLayPnl.Name = "turmasFlwLayPnl";
            this.turmasFlwLayPnl.Size = new System.Drawing.Size(342, 258);
            this.turmasFlwLayPnl.TabIndex = 154;
            this.turmasFlwLayPnl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.turmasFlwLayPnl_ControlRemoved);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.White;
            this.backPanel.Location = new System.Drawing.Point(-42, -40);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1201, 670);
            this.backPanel.TabIndex = 157;
            // 
            // EditarDisciplina
            // 
            this.AcceptButton = this.concluirBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.addTurmaBtn);
            this.Controls.Add(this.turmasLb);
            this.Controls.Add(this.turmasFlwLayPnl);
            this.Controls.Add(this.addProfessorBtn);
            this.Controls.Add(this.professoresLb);
            this.Controls.Add(this.professoresFlwLayPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.concluirBtn);
            this.Controls.Add(this.backPanel);
            this.Name = "EditarDisciplina";
            this.Text = "EditarDisciplina";
            this.Load += new System.EventHandler(this.EditarDisciplina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button concluirBtn;
        private FontAwesome.Sharp.IconButton addProfessorBtn;
        private System.Windows.Forms.Label professoresLb;
        private System.Windows.Forms.FlowLayoutPanel professoresFlwLayPnl;
        private FontAwesome.Sharp.IconButton addTurmaBtn;
        private System.Windows.Forms.Label turmasLb;
        private System.Windows.Forms.FlowLayoutPanel turmasFlwLayPnl;
        private System.Windows.Forms.Panel backPanel;
    }
}