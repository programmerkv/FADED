using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HumanResourceManagement
{
    public partial class MainForm : Form
    {
        private readonly List<Employee> empList = new List<Employee>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var emp = new Employee();
            emp.FullName = txtFullname.Text;
            emp.BirthYear = Convert.ToInt32(txtBirthyear.Text);
            emp.Gender = radMale.Checked;
            emp.House = chkHouse.Checked;
            emp.Car = chkCar.Checked;
            emp.Company = chkCompany.Checked;
            emp.Available = radYes.Checked;

            empList.Add(emp);
            lstEmployee.Items.Add(emp.FullName);
        }

        private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedIndex != -1)
            {
                var emp = empList[lstEmployee.SelectedIndex];
                txtFullname.Text = emp.FullName;
                txtBirthyear.Text = emp.BirthYear.ToString();
                if (emp.Gender) radMale.Checked = true;
                else radFemale.Checked = true;
                chkHouse.Checked = emp.House;
                chkCar.Checked = emp.Car;
                chkCompany.Checked = emp.Company;
                if (emp.Available) radYes.Checked = true;
                else radNo.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose an employee!");
            }
            else
            {
                var confirmation = MessageBox.Show("Do you really want to delete this employee?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    empList.RemoveAt(lstEmployee.SelectedIndex);
                    lstEmployee.Items.RemoveAt(lstEmployee.SelectedIndex);
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Do you really want to delete all of employees?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                empList.Clear();
                lstEmployee.Items.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                using (var streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.WriteLine(empList.Count);

                    foreach (var emp in empList)
                    {
                        streamWriter.WriteLine(emp.FullName);
                        streamWriter.WriteLine(emp.BirthYear);
                        streamWriter.WriteLine(emp.Gender.ToString());
                        streamWriter.WriteLine(emp.House.ToString());
                        streamWriter.WriteLine(emp.Car.ToString());
                        streamWriter.WriteLine(emp.Company.ToString());
                        streamWriter.WriteLine(emp.Available.ToString());
                    }
                }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            empList.Clear();
            lstEmployee.Items.Clear();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                using (var streamReader = new StreamReader(openFileDialog.FileName))
                {
                    var count = Convert.ToInt32(streamReader.ReadLine());

                    for (var i = 0; i < count; i++)
                    {
                        var emp = new Employee();
                        emp.FullName = streamReader.ReadLine();
                        emp.BirthYear = Convert.ToInt32(streamReader.ReadLine());
                        emp.Gender = Convert.ToBoolean(streamReader.ReadLine());
                        emp.House = Convert.ToBoolean(streamReader.ReadLine());
                        emp.Car = Convert.ToBoolean(streamReader.ReadLine());
                        emp.Company = Convert.ToBoolean(streamReader.ReadLine());
                        emp.Available = Convert.ToBoolean(streamReader.ReadLine());
                        empList.Add(emp);
                        lstEmployee.Items.Add(emp.FullName);
                    }
                }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Do you really want to close this program?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes) Close();
        }
    }
}