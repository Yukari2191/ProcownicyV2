using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProcownicyV2
{
    public partial class MainForm : Form
    {
        private List<Employee> employees = new();
        private int nextId = 1;
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = new BindingSource { DataSource = employees };
        }
        public class Employee
        {
            public int ID { get; set; }
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public int Age { get; set; }
            public string Position { get; set; } = "";
        }
       
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using var form = new AddEmployeeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var emp = form.EmployeeData;
                emp.ID = nextId++;
                employees.Add(emp);
                RefreshGrid();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Employee emp)
            {
                employees.Remove(emp);
                RefreshGrid();
            }
        }

        private void buttonSaveCSV_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dlg = new();
            dlg.Filter = "CSV files (*.csv)|*.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(dlg.FileName, employees.Select(e =>
                    $"{e.ID},{e.FirstName},{e.LastName},{e.Age},{e.Position}"));
            }
        }
        private void buttonLoadCSV_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dlg = new();
            dlg.Filter = "CSV files (*.csv)|*.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadAllLines(dlg.FileName);
                employees = lines.Select(line =>
                {
                    var parts = line.Split(',');
                    return new Employee
                    {
                        ID = int.Parse(parts[0]),
                        FirstName = parts[1],
                        LastName = parts[2],
                        Age = int.Parse(parts[3]),
                        Position = parts[4]
                    };
                }).ToList();
                nextId = employees.Any() ? employees.Max(e => e.ID) + 1 : 1;
                RefreshGrid();
            }
        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new BindingSource { DataSource = employees };
            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["FirstName"].HeaderText = "Imiê";
            dataGridView1.Columns["LastName"].HeaderText = "Nazwisko";
            dataGridView1.Columns["Age"].HeaderText = "Wiek";
            dataGridView1.Columns["Position"].HeaderText = "Stanowisko";
        }
    }
}
