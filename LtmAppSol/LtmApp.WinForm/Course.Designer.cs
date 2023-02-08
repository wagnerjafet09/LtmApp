namespace LtmApp.WinForm
{
    partial class Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            this.bttmClean = new System.Windows.Forms.Button();
            this.bttmSearch = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridCourses = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.bttmDelete = new System.Windows.Forms.Button();
            this.bttmEdit = new System.Windows.Forms.Button();
            this.bttmNew = new System.Windows.Forms.Button();
            this.txtDeleted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreationD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCreationU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttmClean
            // 
            this.bttmClean.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmClean.Image = ((System.Drawing.Image)(resources.GetObject("bttmClean.Image")));
            this.bttmClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttmClean.Location = new System.Drawing.Point(820, 86);
            this.bttmClean.Name = "bttmClean";
            this.bttmClean.Size = new System.Drawing.Size(105, 37);
            this.bttmClean.TabIndex = 62;
            this.bttmClean.Text = "Clean";
            this.bttmClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttmClean.UseVisualStyleBackColor = true;
            this.bttmClean.Click += new System.EventHandler(this.bttmClean_Click);
            // 
            // bttmSearch
            // 
            this.bttmSearch.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmSearch.Location = new System.Drawing.Point(828, 298);
            this.bttmSearch.Name = "bttmSearch";
            this.bttmSearch.Size = new System.Drawing.Size(105, 29);
            this.bttmSearch.TabIndex = 61;
            this.bttmSearch.Text = "Search";
            this.bttmSearch.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(640, 299);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 26);
            this.textBox6.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 59;
            this.label8.Text = "Search by:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 29);
            this.comboBox1.TabIndex = 58;
            // 
            // gridCourses
            // 
            this.gridCourses.BackgroundColor = System.Drawing.Color.White;
            this.gridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourses.Location = new System.Drawing.Point(40, 333);
            this.gridCourses.Name = "gridCourses";
            this.gridCourses.Size = new System.Drawing.Size(893, 234);
            this.gridCourses.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(896, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Courses list_____________________________________________________________________" +
    "______________________________";
            // 
            // bttmDelete
            // 
            this.bttmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttmDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttmDelete.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmDelete.ForeColor = System.Drawing.Color.White;
            this.bttmDelete.Location = new System.Drawing.Point(828, 229);
            this.bttmDelete.Name = "bttmDelete";
            this.bttmDelete.Size = new System.Drawing.Size(97, 31);
            this.bttmDelete.TabIndex = 55;
            this.bttmDelete.Text = "Delete";
            this.bttmDelete.UseVisualStyleBackColor = false;
            // 
            // bttmEdit
            // 
            this.bttmEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttmEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttmEdit.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmEdit.ForeColor = System.Drawing.Color.White;
            this.bttmEdit.Location = new System.Drawing.Point(723, 229);
            this.bttmEdit.Name = "bttmEdit";
            this.bttmEdit.Size = new System.Drawing.Size(97, 31);
            this.bttmEdit.TabIndex = 54;
            this.bttmEdit.Text = "Edit";
            this.bttmEdit.UseVisualStyleBackColor = false;
            // 
            // bttmNew
            // 
            this.bttmNew.BackColor = System.Drawing.Color.Green;
            this.bttmNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttmNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttmNew.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmNew.ForeColor = System.Drawing.Color.White;
            this.bttmNew.Location = new System.Drawing.Point(618, 229);
            this.bttmNew.Name = "bttmNew";
            this.bttmNew.Size = new System.Drawing.Size(97, 31);
            this.bttmNew.TabIndex = 53;
            this.bttmNew.Text = "New";
            this.bttmNew.UseVisualStyleBackColor = false;
            // 
            // txtDeleted
            // 
            this.txtDeleted.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleted.Location = new System.Drawing.Point(548, 175);
            this.txtDeleted.Name = "txtDeleted";
            this.txtDeleted.Size = new System.Drawing.Size(182, 26);
            this.txtDeleted.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Deleted:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCreationD
            // 
            this.txtCreationD.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreationD.Location = new System.Drawing.Point(548, 86);
            this.txtCreationD.Name = "txtCreationD";
            this.txtCreationD.Size = new System.Drawing.Size(182, 26);
            this.txtCreationD.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Creation Date:";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentID.Location = new System.Drawing.Point(190, 176);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(182, 26);
            this.txtDepartmentID.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Department ID:";
            // 
            // txtCredits
            // 
            this.txtCredits.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.Location = new System.Drawing.Point(190, 132);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(182, 26);
            this.txtCredits.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Credits:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(190, 86);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(182, 26);
            this.txtTitle.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Title:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 46);
            this.panel1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(389, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Courses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 21);
            this.label9.TabIndex = 63;
            this.label9.Text = "Creation User:";
            // 
            // txtCreationU
            // 
            this.txtCreationU.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreationU.Location = new System.Drawing.Point(548, 129);
            this.txtCreationU.Name = "txtCreationU";
            this.txtCreationU.Size = new System.Drawing.Size(182, 26);
            this.txtCreationU.TabIndex = 64;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 579);
            this.Controls.Add(this.txtCreationU);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bttmClean);
            this.Controls.Add(this.bttmSearch);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gridCourses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttmDelete);
            this.Controls.Add(this.bttmEdit);
            this.Controls.Add(this.bttmNew);
            this.Controls.Add(this.txtDeleted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreationD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttmClean;
        private System.Windows.Forms.Button bttmSearch;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView gridCourses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttmDelete;
        private System.Windows.Forms.Button bttmEdit;
        private System.Windows.Forms.Button bttmNew;
        private System.Windows.Forms.TextBox txtDeleted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreationD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCreationU;
    }
}