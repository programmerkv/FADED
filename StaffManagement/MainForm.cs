using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement
{
    public partial class MainForm : Form
    {
        public List<Staff> staffList = new List<Staff>(); 

        public MainForm()
        {
            InitializeComponent();
        }

        private void radLecturer_CheckedChanged(object sender, EventArgs e)
        {
            grbLecturer.Enabled = true;
            grbEmployee.Enabled = false;
        }

        private void radEmployee_CheckedChanged(object sender, EventArgs e)
        {
            grbEmployee.Enabled = true;
            grbLecturer.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Do you really want to close this program?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes) Close();
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            if (grbLecturer.Enabled)
            {
                var coefficientPay = Convert.ToDouble(txtCoefficientPay.Text);
                var actualPeriod = Convert.ToInt32(txtActualPeriod.Text);
                var expectedPeriod = Convert.ToInt32(txtActualPeriod.Text);

                var salary = coefficientPay * 1_250_000 + (actualPeriod - expectedPeriod) * 100_000;
                txtSalary.Text = salary.ToString();
            }
            else if (grbEmployee.Enabled)
            {
                var coefficientPay = Convert.ToDouble(txtCoefficientPay.Text);
                var workDay = Convert.ToInt32(txtWorkDay.Text);
                var allowance = Convert.ToInt32(txtAllowance.Text);

                var salary = coefficientPay * 1_250_000 + (workDay - 24) * 200_000 + allowance;
                txtSalary.Text = salary.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (grbLecturer.Enabled)
            {
                var lecturer = new Lecturer();
                lecturer.FullName = txtFullName.Text;
                lecturer.BirthYear = Convert.ToInt32(txtBirthYear.Text);
                lecturer.CoefficientPay = Convert.ToDouble(txtCoefficientPay.Text);
                lecturer.Gender = radMale.Checked;
                lecturer.ActualPeriod = Convert.ToInt32(txtActualPeriod.Text);
                lecturer.ExpectedPeriod = Convert.ToInt32(txtExpectedPeriod.Text);

                staffList.Add(lecturer);
                lstStaff.Items.Add(lecturer.FullName);
            }
            else if (grbEmployee.Enabled)
            {
                var employee = new Employee();
                employee.FullName = txtFullName.Text;
                employee.BirthYear = Convert.ToInt32(txtBirthYear.Text);
                employee.CoefficientPay = Convert.ToDouble(txtCoefficientPay.Text);
                employee.Gender = radMale.Checked;
                employee.WorkDay = Convert.ToInt32(txtWorkDay.Text);
                employee.Allowance = Convert.ToInt32(txtAllowance.Text);

                staffList.Add(employee);
                lstStaff.Items.Add(employee.FullName);
            }
        }

        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStaff.SelectedIndex != -1)
            {
                var staff = staffList[lstStaff.SelectedIndex];
                txtFullName.Text = staff.FullName;
                txtBirthYear.Text = staff.BirthYear.ToString();
                txtCoefficientPay.Text = staff.CoefficientPay.ToString();
                if (staff.Gender) radMale.Checked = true;
                else radFemale.Checked = true;

                if (staff is Lecturer)
                {
                    var lecturer = staff as Lecturer;
                    radLecturer.Checked = true;
                    txtActualPeriod.Text = lecturer.ActualPeriod.ToString();
                    txtExpectedPeriod.Text = lecturer.ExpectedPeriod.ToString();
                    txtWorkDay.Text = "";
                    txtAllowance.Text = "";
                }
                else
                {
                    var employee = staff as Employee;
                    radEmployee.Checked = true;
                    txtWorkDay.Text = employee.WorkDay.ToString();
                    txtAllowance.Text = employee.Allowance.ToString();
                    txtActualPeriod.Text = "";
                    txtExpectedPeriod.Text = "";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStaff.SelectedIndex != -1)
            {
                var confirmation = MessageBox.Show("Do you really want to delete this staff?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    staffList.RemoveAt(lstStaff.SelectedIndex);
                    lstStaff.Items.RemoveAt(lstStaff.SelectedIndex);
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Do you really want to delete all the staff?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                staffList.Clear();
                lstStaff.Items.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                using (var streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.WriteLine(staffList.Count);

                    foreach (var staff in staffList)
                    {
                        streamWriter.WriteLine(staff.ToString());
                        streamWriter.WriteLine(staff.FullName);
                        streamWriter.WriteLine(staff.BirthYear);
                        streamWriter.WriteLine(staff.Gender.ToString());
                        if (staff.ToString() == "StaffManagement.Lecturer")
                        {
                            var lecturer = staff as Lecturer;
                            streamWriter.WriteLine(lecturer.ActualPeriod);
                            streamWriter.WriteLine(lecturer.ExpectedPeriod);
                        }
                        else
                        {
                            var employee = staff as Employee;
                            streamWriter.WriteLine(employee.WorkDay);
                            streamWriter.WriteLine(employee.Allowance);
                        }
                    }
                }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            staffList.Clear();
            lstStaff.Items.Clear();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                using (var streamReader = new StreamReader(openFileDialog.FileName))
                {
                    var count = Convert.ToInt32(streamReader.ReadLine());

                    for (var i = 0; i < count; i++)
                    {
                        if (streamReader.ReadLine() == "StaffManagement.Lecturer")
                        {
                            var lecturer = new Lecturer();
                            lecturer.FullName = streamReader.ReadLine();
                            lecturer.BirthYear = Convert.ToInt32(streamReader.ReadLine());
                            lecturer.Gender = Convert.ToBoolean(streamReader.ReadLine());
                            lecturer.ActualPeriod = Convert.ToInt32(streamReader.ReadLine());
                            lecturer.ExpectedPeriod = Convert.ToInt32(streamReader.ReadLine());
                            staffList.Add(lecturer);
                            lstStaff.Items.Add(lecturer.FullName);
                        }
                        else
                        {
                            var employee = new Employee();
                            employee.FullName = streamReader.ReadLine();
                            employee.BirthYear = Convert.ToInt32(streamReader.ReadLine());
                            employee.Gender = Convert.ToBoolean(streamReader.ReadLine());
                            employee.WorkDay = Convert.ToInt32(streamReader.ReadLine());
                            employee.Allowance = Convert.ToInt32(streamReader.ReadLine());
                            staffList.Add(employee);
                            lstStaff.Items.Add(employee.FullName);
                        }
                    }
                }
        }
    }
}
