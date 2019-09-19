using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diliru_oop
{
    public partial class Registar_home : Form
    {
        public Registar_home()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login Login = new Login();
            Login.Show();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manageStudents manageStudents = new manageStudents();
            manageStudents.Show();
        }

        private void btnManageProfessors_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manageProfessors Professor_Home = new manageProfessors();
            Professor_Home.Show();
        }

        private void btnManageCourse_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manageCourses manageCourses = new manageCourses();
            manageCourses.Show();
        }

        private void btnCourseCatalog_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            viewCourseCatalog viewCourseCatalog = new viewCourseCatalog();
            viewCourseCatalog.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Payments Payments = new Payments();
            Payments.Show();
        }
    }
}
