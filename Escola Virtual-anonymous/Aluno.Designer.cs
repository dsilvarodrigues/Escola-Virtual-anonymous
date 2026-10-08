namespace Escola_Virtual_anonymous
{
    partial class Aluno
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tp_Notas = new System.Windows.Forms.TabPage();
            this.tp_Infs = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_AlunoName = new System.Windows.Forms.Label();
            this.pb_Aluno = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tp_Notas);
            this.tabControl1.Controls.Add(this.tp_Infs);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 370);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tp_Notas
            // 
            this.tp_Notas.Location = new System.Drawing.Point(4, 25);
            this.tp_Notas.Name = "tp_Notas";
            this.tp_Notas.Size = new System.Drawing.Size(788, 341);
            this.tp_Notas.TabIndex = 2;
            this.tp_Notas.Text = "Notas";
            this.tp_Notas.UseVisualStyleBackColor = true;
            // 
            // tp_Infs
            // 
            this.tp_Infs.Location = new System.Drawing.Point(4, 25);
            this.tp_Infs.Name = "tp_Infs";
            this.tp_Infs.Size = new System.Drawing.Size(788, 341);
            this.tp_Infs.TabIndex = 3;
            this.tp_Infs.Text = "Informações";
            this.tp_Infs.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(788, 341);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Cartão";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(670, 1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(128, 45);
            this.btn_Logout.TabIndex = 17;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // lbl_AlunoName
            // 
            this.lbl_AlunoName.AutoSize = true;
            this.lbl_AlunoName.Location = new System.Drawing.Point(86, 1);
            this.lbl_AlunoName.Name = "lbl_AlunoName";
            this.lbl_AlunoName.Size = new System.Drawing.Size(41, 16);
            this.lbl_AlunoName.TabIndex = 16;
            this.lbl_AlunoName.Text = "Aluno";
            // 
            // pb_Aluno
            // 
            this.pb_Aluno.Location = new System.Drawing.Point(2, 1);
            this.pb_Aluno.Name = "pb_Aluno";
            this.pb_Aluno.Size = new System.Drawing.Size(77, 72);
            this.pb_Aluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Aluno.TabIndex = 15;
            this.pb_Aluno.TabStop = false;
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_AlunoName);
            this.Controls.Add(this.pb_Aluno);
            this.Name = "Aluno";
            this.Text = "Aluno";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tp_Notas;
        private System.Windows.Forms.TabPage tp_Infs;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_AlunoName;
        private System.Windows.Forms.PictureBox pb_Aluno;
    }
}