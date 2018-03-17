namespace StaffManagement
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoefficientPay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.radEmployee = new System.Windows.Forms.RadioButton();
            this.radLecturer = new System.Windows.Forms.RadioButton();
            this.grbLecturer = new System.Windows.Forms.GroupBox();
            this.txtActualPeriod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExpectedPeriod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbEmployee = new System.Windows.Forms.GroupBox();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkDay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateSalary = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lstStaff = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumberOfStaff = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grbGender.SuspendLayout();
            this.grbType.SuspendLayout();
            this.grbLecturer.SuspendLayout();
            this.grbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(131, 34);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 26);
            this.txtFullName.TabIndex = 1;
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Location = new System.Drawing.Point(131, 66);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(100, 26);
            this.txtBirthYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birth year";
            // 
            // txtCoefficientPay
            // 
            this.txtCoefficientPay.Location = new System.Drawing.Point(131, 98);
            this.txtCoefficientPay.Name = "txtCoefficientPay";
            this.txtCoefficientPay.Size = new System.Drawing.Size(100, 26);
            this.txtCoefficientPay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coefficient pay";
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.radFemale);
            this.grbGender.Controls.Add(this.radMale);
            this.grbGender.Location = new System.Drawing.Point(16, 130);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(200, 60);
            this.grbGender.TabIndex = 6;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(107, 30);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(87, 24);
            this.radFemale.TabIndex = 1;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(6, 30);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(68, 24);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.radEmployee);
            this.grbType.Controls.Add(this.radLecturer);
            this.grbType.Location = new System.Drawing.Point(222, 130);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(220, 60);
            this.grbType.TabIndex = 7;
            this.grbType.TabStop = false;
            this.grbType.Text = "Type";
            // 
            // radEmployee
            // 
            this.radEmployee.AutoSize = true;
            this.radEmployee.Location = new System.Drawing.Point(110, 30);
            this.radEmployee.Name = "radEmployee";
            this.radEmployee.Size = new System.Drawing.Size(104, 24);
            this.radEmployee.TabIndex = 1;
            this.radEmployee.Text = "Employee";
            this.radEmployee.UseVisualStyleBackColor = true;
            this.radEmployee.CheckedChanged += new System.EventHandler(this.radEmployee_CheckedChanged);
            // 
            // radLecturer
            // 
            this.radLecturer.AutoSize = true;
            this.radLecturer.Checked = true;
            this.radLecturer.Location = new System.Drawing.Point(6, 30);
            this.radLecturer.Name = "radLecturer";
            this.radLecturer.Size = new System.Drawing.Size(93, 24);
            this.radLecturer.TabIndex = 0;
            this.radLecturer.TabStop = true;
            this.radLecturer.Text = "Lecturer";
            this.radLecturer.UseVisualStyleBackColor = true;
            this.radLecturer.CheckedChanged += new System.EventHandler(this.radLecturer_CheckedChanged);
            // 
            // grbLecturer
            // 
            this.grbLecturer.Controls.Add(this.txtActualPeriod);
            this.grbLecturer.Controls.Add(this.label5);
            this.grbLecturer.Controls.Add(this.txtExpectedPeriod);
            this.grbLecturer.Controls.Add(this.label4);
            this.grbLecturer.Enabled = false;
            this.grbLecturer.Location = new System.Drawing.Point(16, 196);
            this.grbLecturer.Name = "grbLecturer";
            this.grbLecturer.Size = new System.Drawing.Size(200, 150);
            this.grbLecturer.TabIndex = 8;
            this.grbLecturer.TabStop = false;
            this.grbLecturer.Text = "Lecturer information";
            // 
            // txtActualPeriod
            // 
            this.txtActualPeriod.Location = new System.Drawing.Point(11, 112);
            this.txtActualPeriod.Name = "txtActualPeriod";
            this.txtActualPeriod.Size = new System.Drawing.Size(183, 26);
            this.txtActualPeriod.TabIndex = 3;
            this.txtActualPeriod.Text = "0";
            this.txtActualPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Actual periods / Month";
            // 
            // txtExpectedPeriod
            // 
            this.txtExpectedPeriod.Location = new System.Drawing.Point(11, 50);
            this.txtExpectedPeriod.Name = "txtExpectedPeriod";
            this.txtExpectedPeriod.Size = new System.Drawing.Size(183, 26);
            this.txtExpectedPeriod.TabIndex = 1;
            this.txtExpectedPeriod.Text = "0";
            this.txtExpectedPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Expected periods / Month";
            // 
            // grbEmployee
            // 
            this.grbEmployee.Controls.Add(this.txtAllowance);
            this.grbEmployee.Controls.Add(this.label6);
            this.grbEmployee.Controls.Add(this.txtWorkDay);
            this.grbEmployee.Controls.Add(this.label7);
            this.grbEmployee.Enabled = false;
            this.grbEmployee.Location = new System.Drawing.Point(222, 196);
            this.grbEmployee.Name = "grbEmployee";
            this.grbEmployee.Size = new System.Drawing.Size(220, 150);
            this.grbEmployee.TabIndex = 9;
            this.grbEmployee.TabStop = false;
            this.grbEmployee.Text = "Employee information";
            // 
            // txtAllowance
            // 
            this.txtAllowance.Location = new System.Drawing.Point(11, 112);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(203, 26);
            this.txtAllowance.TabIndex = 3;
            this.txtAllowance.Text = "0";
            this.txtAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Allowance / Month";
            // 
            // txtWorkDay
            // 
            this.txtWorkDay.Location = new System.Drawing.Point(11, 50);
            this.txtWorkDay.Name = "txtWorkDay";
            this.txtWorkDay.Size = new System.Drawing.Size(203, 26);
            this.txtWorkDay.TabIndex = 1;
            this.txtWorkDay.Text = "0";
            this.txtWorkDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Work days / Month";
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.Location = new System.Drawing.Point(16, 352);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(150, 30);
            this.btnCalculateSalary.TabIndex = 10;
            this.btnCalculateSalary.Text = "Calculate salary";
            this.btnCalculateSalary.UseVisualStyleBackColor = true;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(282, 356);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(160, 26);
            this.txtSalary.TabIndex = 11;
            this.txtSalary.Text = "0";
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Salary";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(237, 397);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteAll.TabIndex = 15;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(413, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(676, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Staff list";
            // 
            // lstStaff
            // 
            this.lstStaff.FormattingEnabled = true;
            this.lstStaff.ItemHeight = 20;
            this.lstStaff.Location = new System.Drawing.Point(470, 66);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(281, 264);
            this.lstStaff.TabIndex = 19;
            this.lstStaff.SelectedIndexChanged += new System.EventHandler(this.lstStaff_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Number of staff";
            // 
            // txtNumberOfStaff
            // 
            this.txtNumberOfStaff.Enabled = false;
            this.txtNumberOfStaff.Location = new System.Drawing.Point(591, 356);
            this.txtNumberOfStaff.Name = "txtNumberOfStaff";
            this.txtNumberOfStaff.Size = new System.Drawing.Size(160, 26);
            this.txtNumberOfStaff.TabIndex = 20;
            this.txtNumberOfStaff.Text = "0";
            this.txtNumberOfStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(494, 397);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 30);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumberOfStaff);
            this.Controls.Add(this.lstStaff);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnCalculateSalary);
            this.Controls.Add(this.grbEmployee);
            this.Controls.Add(this.grbLecturer);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.txtCoefficientPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBirthYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Staff Management";
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.grbLecturer.ResumeLayout(false);
            this.grbLecturer.PerformLayout();
            this.grbEmployee.ResumeLayout(false);
            this.grbEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoefficientPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.RadioButton radEmployee;
        private System.Windows.Forms.RadioButton radLecturer;
        private System.Windows.Forms.GroupBox grbLecturer;
        private System.Windows.Forms.TextBox txtActualPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExpectedPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbEmployee;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWorkDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculateSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstStaff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumberOfStaff;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

