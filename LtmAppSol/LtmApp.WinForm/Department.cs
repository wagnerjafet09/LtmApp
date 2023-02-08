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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void cleanTxtBox()
        {
            txtName.ResetText();
            txtBudget.ResetText();
            txtStartDate.ResetText();
            txtCreationD.ResetText();
            txtCreationU.ResetText();
            txtDeleted.ResetText();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Department_ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Budget");
            dt.Columns.Add("StartDate");
            dt.Columns.Add("Creation Date");
            dt.Columns.Add("Creation User");
            dt.Columns.Add("Deleted");

            DataRow dr = dt.NewRow();
            dr[0] = "1";
            dr[1] = "Engeneering";
            dr[2] = "350000";
            dr[3] = DateTime.Now.ToString();
            dr[4] = DateTime.Now.ToString();
            dr[5] = "0";
            dr[6] = "1";
            dt.Rows.Add(dr);

            DataRow dr2 = dt.NewRow();
            dr2[0] = "1";
            dr2[1] = "English";
            dr2[2] = "120000";
            dr2[3] = DateTime.Now.ToString();
            dr2[4] = DateTime.Now.ToString();
            dr2[5] = "0";
            dr2[6] = "1";
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3[0] = "1";
            dr3[1] = "Mathematics";
            dr3[2] = "200000";
            dr3[3] = DateTime.Now.ToString();
            dr3[4] = DateTime.Now.ToString();
            dr3[5] = "0";
            dr3[6] = "1";
            dt.Rows.Add(dr3);

            gridDepartments.DataSource = dt;
        }

        private void bttmClean_Click(object sender, EventArgs e)
        {
            cleanTxtBox();
        }
    }
}
