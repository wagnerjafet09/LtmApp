namespace LtmApp.WinForm
{
    partial class Instructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructor));
            this.bttmSearch = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridInstructors = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.bttmDelete = new System.Windows.Forms.Button();
            this.bttmEdit = new System.Windows.Forms.Button();
            this.bttmNew = new System.Windows.Forms.Button();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttmClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInstructors)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttmSearch
            // 
            this.bttmSearch.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmSearch.Location = new System.Drawing.Point(828, 271);
            this.bttmSearch.Name = "bttmSearch";
            this.bttmSearch.Size = new System.Drawing.Size(105, 29);
            this.bttmSearch.TabIndex = 57;
            this.bttmSearch.Text = "Search";
            this.bttmSearch.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(640, 272);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 26);
            this.textBox6.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Search by:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 29);
            this.comboBox1.TabIndex = 54;
            // 
            // gridInstructors
            // 
            this.gridInstructors.BackgroundColor = System.Drawing.Color.White;
            this.gridInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInstructors.Location = new System.Drawing.Point(40, 306);
            this.gridInstructors.Name = "gridInstructors";
            this.gridInstructors.Size = new System.Drawing.Size(893, 260);
            this.gridInstructors.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(896, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Instrusctors list________________________________________________________________" +
    "______________________________";
            // 
            // bttmDelete
            // 
            this.bttmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttmDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttmDelete.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmDelete.ForeColor = System.Drawing.Color.White;
            this.bttmDelete.Location = new System.Drawing.Point(811, 198);
            this.bttmDelete.Name = "bttmDelete";
            this.bttmDelete.Size = new System.Drawing.Size(97, 31);
            this.bttmDelete.TabIndex = 51;
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
            this.bttmEdit.Location = new System.Drawing.Point(706, 198);
            this.bttmEdit.Name = "bttmEdit";
            this.bttmEdit.Size = new System.Drawing.Size(97, 31);
            this.bttmEdit.TabIndex = 50;
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
            this.bttmNew.Location = new System.Drawing.Point(600, 198);
            this.bttmNew.Name = "bttmNew";
            this.bttmNew.Size = new System.Drawing.Size(97, 31);
            this.bttmNew.TabIndex = 49;
            this.bttmNew.Text = "New";
            this.bttmNew.UseVisualStyleBackColor = false;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHireDate.Location = new System.Drawing.Point(190, 175);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(182, 26);
            this.txtHireDate.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Hire Date:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(190, 131);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(182, 26);
            this.txtLastName.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(190, 85);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(182, 26);
            this.txtFirstName.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "First Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 46);
            this.panel1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(381, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Instructors";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bttmClean
            // 
            this.bttmClean.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmClean.Image = ((System.Drawing.Image)(resources.GetObject("bttmClean.Image")));
            this.bttmClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttmClean.Location = new System.Drawing.Point(803, 85);
            this.bttmClean.Name = "bttmClean";
            this.bttmClean.Size = new System.Drawing.Size(105, 37);
            this.bttmClean.TabIndex = 58;
            this.bttmClean.Text = "Clean";
            this.bttmClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttmClean.UseVisualStyleBackColor = true;
            this.bttmClean.Click += new System.EventHandler(this.bttmClean_Click);
            // 
            // Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 579);
            this.Controls.Add(this.bttmClean);
            this.Controls.Add(this.bttmSearch);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gridInstructors);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttmDelete);
            this.Controls.Add(this.bttmEdit);
            this.Controls.Add(this.bttmNew);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Instructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructor";
            this.Load += new System.EventHandler(this.Instructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInstructors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttmSearch;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView gridInstructors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttmDelete;
        private System.Windows.Forms.Button bttmEdit;
        private System.Windows.Forms.Button bttmNew;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttmClean;
    }
}