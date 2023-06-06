using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cours_work_PDD
{
    public partial class DriverForm : Form
    {
        public string DriverSurname;
        public string DriverName;
        public string DriverLastName;
        public DateTime DriverBirthDate;
        public string DriverLicense;

        string errorMsg;
        
        public DriverForm()
        {
            InitializeComponent();
            DriverSurname = string.Empty;
            DriverName = string.Empty;
            DriverLastName = string.Empty;
            DriverBirthDate = DateTime.MinValue;
            DriverLicense = string.Empty;
        }
        public DriverForm(string surname, string name, string lastname, DateTime birthdate, string license)
        {
            InitializeComponent();
            button2.Text = "Изменить";
            Surname.Text = surname;
            Name.Text = name;
            Lastname.Text = lastname;
            BirthDate.Value = birthdate;
            License.Text = license;
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            BirthDate.CustomFormat = "dd/MM/yyyy";
            Surname.TabStop = false;
            Name.TabStop = false;
            Lastname.TabStop = false;
            BirthDate.TabStop = false;
            License.TabStop = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DriverSurname=Surname.Text;
            DriverName=Name.Text;
            DriverLastName=Lastname.Text;
            DriverBirthDate= BirthDate.Value;
            DriverLicense = License.Text;
            Close();
        }

        public static bool IsValidRussianName(string name, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                error = "Пустая строчка,\nВведите значение!";
                return false;
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    error = "Использование цифр не допускается!";
                    return false;
                    
                } else if (!IsRussianLetter(c))
                {
                    error = "Использован символ не из Кириллицы!";
                    return false;
                }
            }
            error = "";
            return true;
        }

        private static bool IsRussianLetter(char c)
        {
            return (c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё';
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidRussianName(Surname.Text, out errorMsg))
            {
                e.Cancel = true;
                Surname.Select(0, Surname.TextLength);
                errorProvider.SetError(Surname, errorMsg);
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidRussianName(Name.Text, out errorMsg))
            {
                e.Cancel = true;
                Name.Select(0, Name.TextLength);
                errorProvider.SetError(Name, errorMsg);
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void lastname_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidRussianName(Lastname.Text, out errorMsg))
            {
                e.Cancel = true;
                Lastname.Select(0, Lastname.TextLength);
                errorProvider.SetError(Lastname, errorMsg);
            }
        }

        private void lastname_Validated(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void license_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidLicense(License.Text, out errorMsg))
            {
                e.Cancel = true;
                License.Select(0, License.TextLength);
                errorProvider.SetError(License, errorMsg);
            }
        }

        public static bool IsValidLicense(string input, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrEmpty(input))
            {
                error = "Введите серию и номер водительского удостоверения!";
                return false;
            }
            if(input.Length != 10)
            {
                error = "Серия и номер водительского удостоверения состоят из 10 цифр, пожалуйста введите их все!";
                return false;
            }

            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    error = "Введён недопустимый символ!";
                    return false;
                }
            }

            return true;
        }

        private void license_Validated(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
