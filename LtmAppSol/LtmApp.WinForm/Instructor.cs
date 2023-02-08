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
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
        }

        private void cleanTextBox() 
        {
            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtHireDate.ResetText();
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Hire Date");

            DataRow dr = dt.NewRow();
            dr[0] = "1";
            dr[1] = "Francis";
            dr[2] = "Ramirez";
            dr[3] = DateTime.Now.ToString();
            dt.Rows.Add(dr);

            DataRow dr2 = dt.NewRow();
            dr2[0] = "2";
            dr2[1] = "Julio";
            dr2[2] = "Hernandez";
            dr2[3] = DateTime.UtcNow.ToString();
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3[0] = "3";
            dr3[1] = "Hector";
            dr3[2] = "Gonzales";
            dr3[3] = DateTime.Today.ToString();
            dt.Rows.Add(dr3);

            gridInstructors.DataSource = dt;
        }

        private void bttmClean_Click(object sender, EventArgs e)
        {
            cleanTextBox();
        }
    }
}
