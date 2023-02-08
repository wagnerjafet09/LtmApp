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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void cleanTxtBox()
        {
            txtTitle.ResetText();
            txtCredits.ResetText();
            txtDepartmentID.ResetText();
            txtCreationD.ResetText();
            txtCreationU.ResetText();
            txtDeleted.ResetText();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CourseID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Credits");
            dt.Columns.Add("Departmet_ID");
            dt.Columns.Add("Creation Date");
            dt.Columns.Add("Creation User");
            dt.Columns.Add("Deleted");

            DataRow dr = dt.NewRow();
            dr[0] = "1";
            dr[1] = "Calculus III";
            dr[2] = "3";
            dr[3] = 7;
            dr[4] = DateTime.Now.ToString();
            dr[5] = "1";
            dr[6] = "0";
            dt.Rows.Add(dr);

            DataRow dr2 = dt.NewRow();
            dr2[0] = "2";
            dr2[1] = "Physics";
            dr2[2] = "5";
            dr2[3] = "1";
            dr2[4] = DateTime.Now.ToString();
            dr2[5] = "1";
            dr2[6] = "0";
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3[0] = "3";
            dr3[1] = "Poetry";
            dr3[2] = "2";
            dr3[3] = "2";
            dr3[4] = DateTime.Now.ToString();
            dr3[5] = "1";
            dr3[6] = "0";
            dt.Rows.Add(dr3);

            gridCourses.DataSource = dt;
        }

        private void bttmClean_Click(object sender, EventArgs e)
        {
            cleanTxtBox();
        }
    }
}
