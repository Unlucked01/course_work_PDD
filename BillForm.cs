using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cours_work_PDD
{
    public partial class BillForm : Form
    {
        public string Fullname { get; set; }
        public string VehicleDescription { get; set; }
        public string[] Reasons { get; set; }
        public string Reason { get; set; }
        public decimal Amount { get; set; }

        public BillForm()
        {
            InitializeComponent();
            Reasons = new string[]
            {
                "Страховка",
                "Тонировка",
                "Превышение скорости"
            };
            Fullname = string.Empty;
            VehicleDescription = string.Empty;
            Reason = string.Empty;
            Amount = 0m;
        }
        public BillForm(string fullname, string description, string reason)
        {
            InitializeComponent();
            Reasons = new string[]
            {
                "Страховка",
                "Тонировка",
                "Превышение скорости"
            };
            Fullname = fullname;
            VehicleDescription = description;
            Reason = reason;
        }

        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync())
                ?? new List<T>());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show($"Пожалуйста, заполните все поля!", "Внимание", 0,
                            MessageBoxIcon.Information);
                button1.Enabled = false;
            }
            Fullname = comboBox1.SelectedItem as string;
            VehicleDescription = comboBox2.SelectedItem as string;
            Reason = comboBox3.SelectedItem as string;
            Close();
        }

        private async void BillForm_Load(object sender, EventArgs e)
        {
            var drivers = await ReadFromFile<Driver>("Drivers.json");
            string[] fullnames = drivers.Select(x => x.FullName).ToArray();

            comboBox1.DataSource = fullnames;
            comboBox3.DataSource = Reasons;

            if(Fullname.Equals(string.Empty) && VehicleDescription.Equals(string.Empty) && Reason.Equals(string.Empty))
            {
                comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1; comboBox3.SelectedIndex = -1;
            }
            else
            {
                comboBox1.SelectedItem = Fullname; comboBox2.SelectedItem = VehicleDescription; comboBox3.SelectedItem = Reason;
            }
            

            textBox1.Text = string.Empty;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox3.SelectedIndex)
            {
                case 0:
                    Amount = 800m;
                    break;
                case 1:
                    Amount= 500m;
                    break;
                case 2:
                    Amount= 600m;
                    break;
            }
            textBox1.Text = Amount.ToString("C", new CultureInfo("ru-RU"));
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show($"Пожалуйста, заполните все поля!", "Внимание", 0,
                            MessageBoxIcon.Information);
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vehicles = await ReadFromFile<Vehicle>("Vehicles.json");
            string[] description = vehicles.Where(n => n.FullName.Equals(comboBox1.SelectedItem)).Select(x => x.Description).ToArray();

            comboBox2.DataSource = description; 
            button1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
