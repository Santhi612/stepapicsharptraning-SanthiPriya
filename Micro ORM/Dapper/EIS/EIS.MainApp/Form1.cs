using EIS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EIS.Models;

namespace EIS.MainApp
{
    public partial class Form1 : Form
    {
        EmployeeRepo empRepo = new EmployeeRepo();
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ID = textBoxID.Text;
            emp.Name = textBoxName.Text;
            emp.Position = textBoxPosition.Text;

            empRepo.AddEmployee(emp);
            loadEmployees();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadEmployees();
        }

        //this method will return all the list of employees
        private void loadEmployees()
        {
            dataGridViewemployee.DataSource = null;
            dataGridViewemployee.DataSource = empRepo.GetAllEmployees();

        }
    }
}
