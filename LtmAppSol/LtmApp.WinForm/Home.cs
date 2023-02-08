using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LtmApp.WinForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bttmStudents_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
        }

        private void bttmInstructors_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();
            instructor.Show();
        }

        private void bttmCourses_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Show();
        }

        private void bttmDepartments_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
        }
    }
}
