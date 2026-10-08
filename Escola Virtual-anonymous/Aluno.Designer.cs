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
            this.tp_information = new System.Windows.Forms.TabControl();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_StudentName = new System.Windows.Forms.Label();
            this.pb_Student = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tp_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // tp_information
            // 
            this.tp_information.Controls.Add(this.tabPage1);
            this.tp_information.Controls.Add(this.tabPage2);
            this.tp_information.Controls.Add(this.tabPage3);
            this.tp_information.Location = new System.Drawing.Point(2, 80);
            this.tp_information.Name = "tp_information";
            this.tp_information.SelectedIndex = 0;
            this.tp_information.Size = new System.Drawing.Size(796, 370);
            this.tp_information.TabIndex = 18;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(670, 1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(128, 45);
            this.btn_Logout.TabIndex = 17;
            this.btn_Logout.Text = "Sair";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Location = new System.Drawing.Point(86, 1);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(41, 16);
            this.lbl_StudentName.TabIndex = 16;
            this.lbl_StudentName.Text = "Aluno";
            // 
            // pb_Student
            // 
            this.pb_Student.Image = global::Escola_Virtual_anonymous.Properties.Resources.icons8_student_100;
            this.pb_Student.Location = new System.Drawing.Point(2, 1);
            this.pb_Student.Name = "pb_Student";
            this.pb_Student.Size = new System.Drawing.Size(77, 72);
            this.pb_Student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Student.TabIndex = 15;
            this.pb_Student.TabStop = false;
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
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tp_information);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_StudentName);
            this.Controls.Add(this.pb_Student);
            this.Name = "Aluno";
            this.Text = "Aluno";
            this.tp_information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tp_information;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_StudentName;
        private System.Windows.Forms.PictureBox pb_Student;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}