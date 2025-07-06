using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProcownicyV2.MainForm;

namespace ProcownicyV2
{
    public partial class AddEmployeeForm : Form
    {
        public Employee EmployeeData { get; private set; }
        public AddEmployeeForm()
        {
            InitializeComponent();
            comboBoxPosition.SelectedIndex = 0;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            EmployeeData = new Employee
            {
                FirstName = textFirstName.Text,
                LastName = textLastName.Text,
                Age = int.TryParse(textAge.Text, out int age) ? age : 0,
                Position = comboBoxPosition.SelectedItem.ToString() ?? ""
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
