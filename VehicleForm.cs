using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cours_work_PDD
{
    public partial class VehicleForm : Form
    {
        public string VehicleType;
        public string Mark;
        public string Model;
        public string GovernmentNumber;
        public string[] Fullnames;
        public string Fullname;

        string errorMsg;

        public VehicleForm(string[] fullnames)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            VehicleType = comboBox1.SelectedItem as string;
            Mark = string.Empty;
            Model = string.Empty;
            GovernmentNumber = string.Empty;
            Fullname = string.Empty;
            Fullnames = fullnames;
        }

        public VehicleForm(string type, string mark, string model, string number, string fullname, string[] fullnames)
        {
            InitializeComponent();
            comboBox1.SelectedItem = type;
            VehicleType = comboBox1.SelectedItem as string;
            Mark = mark;
            Model = model;
            GovernmentNumber = number;
            Fullname = fullname;
            Fullnames = fullnames;
            button1.Text = "Изменить";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^[a-zа-яА-ЯA-Z]+$";
            if (!Regex.IsMatch(textBox1.Text, pattern))
            {
                e.Cancel = true;
                errorMsg = "Допускаются только буквенные символы!";
                textBox1.Select(0, textBox1.TextLength);
                errorProvider1.SetError(textBox1, errorMsg);
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^[a-zа-яА-ЯA-Z0-9]+$";
            if (!Regex.IsMatch(textBox2.Text, pattern))
            {
                e.Cancel = true;
                errorMsg = "Введён недопустимый символ!";
                textBox2.Select(0, textBox2.TextLength);
                errorProvider1.SetError(textBox2, errorMsg);
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[АВЕКМНОРСТУХ]{1}\d{3}[АВЕКМНОРСТУХ]{2}\d{2,3}$";
            if(!Regex.IsMatch(textBox3.Text.ToUpper(), pattern))
            {
                e.Cancel = true;
                errorMsg = "Введён недопустимый символ!";
                textBox3.Select(0, textBox2.TextLength);
                errorProvider1.SetError(textBox3, errorMsg);
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(Fullnames);
            textBox1.Text = Mark;
            textBox2.Text = Model;
            textBox3.Text = GovernmentNumber;
            comboBox2.SelectedItem = Fullname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehicleType = comboBox1.SelectedItem as string;
            Mark = textBox1.Text;
            Model = textBox2.Text;
            GovernmentNumber = textBox3.Text;
            Fullname = comboBox2.SelectedItem as string;
            Close();
        }
    }
}
