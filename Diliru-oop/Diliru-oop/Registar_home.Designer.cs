namespace Diliru_oop
{
    partial class Registar_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registar_home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnManageProfessors = new System.Windows.Forms.Button();
            this.btnManageCourse = new System.Windows.Forms.Button();
            this.btnCourseCatalog = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(12, 140);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(111, 44);
            this.btnManageStudents.TabIndex = 1;
            this.btnManageStudents.Text = "ManageStudents";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnManageProfessors
            // 
            this.btnManageProfessors.Location = new System.Drawing.Point(129, 140);
            this.btnManageProfessors.Name = "btnManageProfessors";
            this.btnManageProfessors.Size = new System.Drawing.Size(111, 44);
            this.btnManageProfessors.TabIndex = 1;
            this.btnManageProfessors.Text = "Manage Professors";
            this.btnManageProfessors.UseVisualStyleBackColor = true;
            this.btnManageProfessors.Click += new System.EventHandler(this.btnManageProfessors_Click);
            // 
            // btnManageCourse
            // 
            this.btnManageCourse.Location = new System.Drawing.Point(246, 140);
            this.btnManageCourse.Name = "btnManageCourse";
            this.btnManageCourse.Size = new System.Drawing.Size(107, 44);
            this.btnManageCourse.TabIndex = 1;
            this.btnManageCourse.Text = "Manage Courses";
            this.btnManageCourse.UseVisualStyleBackColor = true;
            this.btnManageCourse.Click += new System.EventHandler(this.btnManageCourse_Click);
            // 
            // btnCourseCatalog
            // 
            this.btnCourseCatalog.Location = new System.Drawing.Point(359, 140);
            this.btnCourseCatalog.Name = "btnCourseCatalog";
            this.btnCourseCatalog.Size = new System.Drawing.Size(127, 44);
            this.btnCourseCatalog.TabIndex = 1;
            this.btnCourseCatalog.Text = "View Course Catalog";
            this.btnCourseCatalog.UseVisualStyleBackColor = true;
            this.btnCourseCatalog.Click += new System.EventHandler(this.btnCourseCatalog_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(395, 348);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(160, 203);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(178, 41);
            this.btnPayments.TabIndex = 2;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // Registar_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 383);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCourseCatalog);
            this.Controls.Add(this.btnManageCourse);
            this.Controls.Add(this.btnManageProfessors);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registar_home";
            this.Text = "Registar_home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnManageProfessors;
        private System.Windows.Forms.Button btnManageCourse;
        private System.Windows.Forms.Button btnCourseCatalog;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPayments;
    }
}