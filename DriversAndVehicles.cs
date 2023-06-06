using Newtonsoft.Json;
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
using Npgsql;

namespace cours_work_PDD
{
    public partial class DriversAndVehicles : Form
    {
        const string Drivers = "Drivers.json";
        const string Vehicles = "Vehicles.json";

        public DriversAndVehicles()
        {
            Task.Run(() => File.Open(Drivers, FileMode.OpenOrCreate).Close());
            Task.Run(() => File.Open(Vehicles, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }

        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync())
                ?? new List<T>());
            }
        }

        async private void ButtonCreateFilm_Click(object sender, EventArgs e)
        {
            DriverForm driverForm = new DriverForm();
            driverForm.ShowDialog();
            Driver newDriver = new Driver(driverForm.DriverSurname, driverForm.DriverName, driverForm.DriverLastName, driverForm.DriverBirthDate, driverForm.DriverLicense);
            if (!newDriver.Surname.Equals(String.Empty) && !newDriver.Name.Equals(String.Empty) && !newDriver.Lastname.Equals(String.Empty))
            {
                var drivers = await ReadFromFile<Driver>(Drivers);

                foreach (var d in drivers)
                {
                    if(d.Surname.Equals(newDriver.Surname) && d.Name.Equals(newDriver.Name) && d.Lastname.Equals(d.Lastname) && 
                        d.DateOfBirth.ToShortDateString().Equals(newDriver.DateOfBirth.ToShortDateString()) && d.DriverLicense.Equals(newDriver.DriverLicense))
                    {
                        MessageBox.Show($"Водитель {newDriver.FullName} уже занесён в базу Водителей.", "Неудачное добавление водителя", 0, MessageBoxIcon.Information);
                        return;
                    }
                }
                drivers.Add(newDriver);
                driversCount.Text = drivers.Count.ToString();
                driversGrid.Rows.Add(newDriver.Surname, newDriver.Name, newDriver.Lastname, newDriver.DateOfBirth.ToShortDateString(), newDriver.DriverLicense);
                await WriteToFile(drivers, Drivers);
            }
        }
        async private void FilmFestivalForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(Drivers) && File.Exists(Vehicles))
            {
                var initialDrivers = await ReadFromFile<Driver>(Drivers);
                var initialVehicles = await ReadFromFile<Vehicle>(Vehicles);
                driversCount.Text = Convert.ToString(initialDrivers.Count.ToString());
                vehicleCount.Text = Convert.ToString(initialVehicles.Count.ToString());
                if (initialDrivers != null && initialVehicles != null)
                {
                    foreach (var d in initialDrivers)
                    {
                        int index = driversGrid.Rows.Add();
                        driversGrid.Rows[index].Cells[0].Value = d.Surname;
                        driversGrid.Rows[index].Cells[1].Value = d.Name;
                        driversGrid.Rows[index].Cells[2].Value = d.Lastname;
                        driversGrid.Rows[index].Cells[3].Value = d.DateOfBirth.ToShortDateString();
                        driversGrid.Rows[index].Cells[4].Value = d.DriverLicense;
                    }
                    foreach (var v in initialVehicles)
                    {
                        int index = vehicleGrid.Rows.Add();
                        vehicleGrid.Rows[index].Cells[0].Value = v.Type;
                        vehicleGrid.Rows[index].Cells[1].Value = v.Mark;
                        vehicleGrid.Rows[index].Cells[2].Value = v.Model;
                        vehicleGrid.Rows[index].Cells[3].Value = v.Number;
                        vehicleGrid.Rows[index].Cells[4].Value = v.FullName;
                    }
                }
            }
            driversGrid.CurrentCell = null;
            vehicleGrid.CurrentCell = null;
        }

        async private void ButtonDeleteFilm_Click(object sender, EventArgs e)
        {
            int selectedCount = driversGrid.SelectedRows.Count;

            if (selectedCount > 0)
            {
                var drivers = await ReadFromFile<Driver>(Drivers);
                if (selectedCount == 1)
                {
                    var removedDriver = drivers[driversGrid.SelectedRows[0].Index];
                    MessageBox.Show($"Водитель {removedDriver.FullName} удалён!", "Удаление одного водителя", 0,
                            MessageBoxIcon.Information);
                    drivers.Remove(removedDriver);
                    driversGrid.Rows.Remove(driversGrid.SelectedRows[0]);
                }
                else
                {
                    int[] selectedIndexes = new int[selectedCount];
                    List<int> removedIndexes = new List<int>();
                    for (int i = 0; i < selectedCount; i++)
                    {
                        selectedIndexes[i] = driversGrid.SelectedRows[i].Index;
                    }
                    Array.Sort(selectedIndexes);
                    foreach (var elem in selectedIndexes.Reverse())
                    {
                        drivers.Remove(drivers[elem]);
                        driversGrid.Rows.RemoveAt(elem);
                        removedIndexes.Add(elem);
                    }
                    string removedIndexesStr = string.Join(", ", removedIndexes.ToArray());
                    MessageBox.Show($"Водители с индексами: {removedIndexesStr} удалены!", "Удаление нескольких водителей", 0,
                        MessageBoxIcon.Information);
                }
                driversCount.Text = drivers.Count.ToString();
                driversGrid.Refresh();
                await WriteToFile(drivers, Drivers);
            }
            else
            {
                MessageBox.Show("Нет ни одного автомобиля или вы не выбрали автомобиль для удаленя!",
                    "Неудачное удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        private void ButtonCloseFilmTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        async private void ButtonAllDeleteFilm_Click(object sender, EventArgs e)
        {
            var drivers = await ReadFromFile<Driver>(Drivers);
            if(drivers.Count == 0)
            {
                MessageBox.Show("Нет ни одного водителя!", "Удалить всех водителей", 0, MessageBoxIcon.Information);
                return;
            }
            drivers.Clear();
            driversGrid.Rows.Clear();
            driversCount.Text = drivers.Count.ToString();
            MessageBox.Show("Данные всех волдителей удалены!", "Удалить всех водителей", 0, MessageBoxIcon.Information);
            await WriteToFile(drivers, Drivers);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataGridView selectedDatagrid;
            if (radioButton1.Checked)
            {
                selectedDatagrid = driversGrid;
            }
            else
            {
                selectedDatagrid = vehicleGrid;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите поле для фильтрации!", "Внимание", 0, MessageBoxIcon.Information);
                return;
            }
            string searchValue = textBox1.Text;
            int columnIndex = comboBox1.SelectedIndex;
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in selectedDatagrid.Rows)
            {
                if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    row.Visible = true;
                    hasVisibleRows = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
            if (!hasVisibleRows)
            {
                MessageBox.Show($"Полей с такими данными: {searchValue} - нет!", "Внимание", 0, MessageBoxIcon.Information);
            }
        }

        private async void dataGridViewFilmTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = driversGrid.CurrentRow;

            string surname = selectedRow.Cells[0].Value.ToString();
            string name = selectedRow.Cells[1].Value.ToString();
            string lastname = selectedRow.Cells[2].Value.ToString();
            DateTime dateOfBirth = Convert.ToDateTime(selectedRow.Cells[3].Value);
            string license = selectedRow.Cells[4].Value.ToString();

            DriverForm driverForm = new DriverForm(surname, name, lastname, dateOfBirth, license);
            driverForm.ShowDialog();

            Driver newDriver = new Driver(driverForm.DriverSurname, driverForm.DriverName, 
                driverForm.DriverLastName, driverForm.DriverBirthDate, driverForm.DriverLicense);

            var drivers = await ReadFromFile<Driver>(Drivers);
            foreach(var d in drivers)
            {
                if (d.Surname.Equals(surname) && d.Name.Equals(name) && d.Lastname.Equals(lastname) 
                        && d.DriverLicense.Equals(license))
                {
                    if(!(newDriver.Surname.Equals(surname) && newDriver.Name.Equals(name) && newDriver.DateOfBirth.Equals(dateOfBirth)
                        && newDriver.Lastname.Equals(lastname) && newDriver.DriverLicense.Equals(license)))
                    {
                        drivers.Remove(d);
                        drivers.Add(newDriver);
                        selectedRow.Cells[0].Value = newDriver.Surname;
                        selectedRow.Cells[1].Value = newDriver.Name;
                        selectedRow.Cells[2].Value = newDriver.Lastname;
                        selectedRow.Cells[3].Value = newDriver.DateOfBirth.ToShortDateString();
                        selectedRow.Cells[4].Value = newDriver.DriverLicense;
                        driversGrid.Refresh();
                        MessageBox.Show($"Водитель {newDriver.FullName} изменён!", "Изменение водителя", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Водитель {newDriver.FullName} не был изменён, внесите изменения!", "Неудачное изменение водителя", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(drivers, Drivers);
            driversGrid.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedColumn = comboBox2.SelectedIndex;
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show($"Введите данные для поиска водителя!", "Неудачный поиск водителя", 0,
                            MessageBoxIcon.Information);
            }
            textBox3.Visible = true;
            label4.Visible = true;
            button2.Enabled = true;
            string searchText = textBox2.Text.ToLower();

            bool found = false;

            foreach (DataGridViewRow row in driversGrid.Rows)
            {
                if (row.Cells[selectedColumn].Value != null && row.Cells[selectedColumn].Value.ToString().ToLower().Contains(searchText.ToLower()))
                {
                    row.Selected = true;
                    found = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
            textBox3.Text= driversGrid.SelectedRows.Count.ToString();

            if (!found) 
            {
                MessageBox.Show($"Водитель с такими данными: {searchText} - отсутствует!", "Неудачный поиск водителя", 0,
                            MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox3.Visible= false;
            label4.Visible= false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            if (radioButton1.Checked)
            {
                foreach (DataGridViewRow row in driversGrid.Rows)
                {
                    row.Selected = false;
                }
            }
            else
            {
                foreach (DataGridViewRow row in vehicleGrid.Rows)
                {
                    row.Selected = false;
                }
            }
            button2.Enabled = false;
            button1.Enabled= false;
            comboBox1.Enabled= true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.TextLength > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Enabled= false;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == vehicleGrid.Columns["dataGridViewTextBoxColumn1"].Index)
            {
                toolTip1.SetToolTip(vehicleGrid, "Здесь указан тип транспортного средства");
            }else if (e.RowIndex == -1 && e.ColumnIndex == vehicleGrid.Columns["dataGridViewTextBoxColumn3"].Index)
            {
                toolTip1.SetToolTip(vehicleGrid, "Здесь указан государственный регистрационный номер");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var drivers = await ReadFromFile<Driver>(Drivers);
            string[] fullnames = drivers.Select(x => x.FullName).ToArray();
            VehicleForm vehicleForm = new VehicleForm(fullnames);
            vehicleForm.ShowDialog();

            Vehicle vehicle = new Vehicle(vehicleForm.VehicleType,vehicleForm.Mark,vehicleForm.Model,vehicleForm.GovernmentNumber,vehicleForm.Fullname);
            if(!vehicle.Mark.Equals(String.Empty) && !vehicle.Model.Equals(string.Empty) && !vehicle.Number.Equals(string.Empty))
            {
                var vehicles = await ReadFromFile<Vehicle>(Vehicles);
                foreach (var v in vehicles)
                {
                    if(v.Mark.Equals(vehicle.Mark) && v.Model.Equals(vehicle.Model) && v.Number.Equals(v.Number) && v.FullName.Equals(vehicle.FullName))
                    {
                        MessageBox.Show($"Автомобиль {vehicle.Mark},{vehicle.Model} с владельцем: {vehicle.FullName} уже занесён в базу автомобилей.", "Неудачное добавление автомобиля", 0, MessageBoxIcon.Information);
                        return;
                    }
                }
                vehicles.Add(vehicle);
                vehicleCount.Text = vehicles.Count.ToString();
                vehicleGrid.Rows.Add(vehicle.Type, vehicle.Mark, vehicle.Model, vehicle.Number, vehicle.FullName);
                await WriteToFile(vehicles, Vehicles);
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var vehicles = await ReadFromFile<Vehicle>(Vehicles);
            if (vehicles.Count == 0)
            {
                MessageBox.Show("Нет ни одного автомобиля!", "Удалить все автомобили", 0, MessageBoxIcon.Information);
                return;
            }
            vehicles.Clear();
            vehicleGrid.Rows.Clear();
            vehicleCount.Text = vehicles.Count.ToString();
            MessageBox.Show("Данные всех автомобилей удалены!", "Удалить все автомобили", 0, MessageBoxIcon.Information);
            await WriteToFile(vehicles, Vehicles);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            int selectedCount = vehicleGrid.SelectedRows.Count;

            if (selectedCount > 0)
            {
                var vehicles = await ReadFromFile<Vehicle>(Vehicles);
                if (selectedCount == 1)
                {
                    var removedVehicle = vehicles[vehicleGrid.SelectedRows[0].Index];
                    MessageBox.Show($"Автомобиль {removedVehicle.Number} с владельцем: {removedVehicle.FullName} удалён!", "Удаление одного автомобиля", 0,
                            MessageBoxIcon.Information);
                    vehicles.Remove(removedVehicle);
                    vehicleGrid.Rows.Remove(vehicleGrid.SelectedRows[0]);
                }
                else
                {
                    int[] selectedIndexes = new int[selectedCount];
                    List<int> removedIndexes = new List<int>();
                    for (int i = 0; i < selectedCount; i++)
                    {
                        selectedIndexes[i] = vehicleGrid.SelectedRows[i].Index;
                    }
                    Array.Sort(selectedIndexes);
                    foreach (var elem in selectedIndexes.Reverse())
                    {
                        vehicles.Remove(vehicles[elem]);
                        vehicleGrid.Rows.RemoveAt(elem);
                        removedIndexes.Add(elem); 
                    }
                    string removedIndexesStr = string.Join(", ", removedIndexes.ToArray());
                    MessageBox.Show($"Автомобили с индексами: {removedIndexesStr} удалены!", "Удаление нескольких автомобилей", 0,
                        MessageBoxIcon.Information);
                }
                vehicleCount.Text = vehicles.Count.ToString();
                vehicleGrid.Refresh();
                await WriteToFile(vehicles, Vehicles);
            }
            else
            {
                MessageBox.Show("Нет ни одного автомобиля или вы не выбрали автомобиль для удаленя!",
                    "Неудачное удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            comboBox1.Enabled = false;
            textBox2.Focus();
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Focus();
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            foreach (DataGridViewRow row in vehicleGrid.Rows)
            {
                row.Selected = false;
                row.Visible= true;
            }
            comboBox1.Items.Clear();
            comboBox1.Items.Add("фамилия водителя");
            comboBox1.Items.Add("имя водителя");
            comboBox1.Items.Add("отчество водителя");
            comboBox1.Items.Add("серии и номеру ВУ");
            comboBox2.Items.Clear();
            comboBox2.Items.Add("фамилии водителя");
            comboBox2.Items.Add("имени водителя");
            comboBox2.Items.Add("отчеству водителя");
            comboBox2.Items.Add("серии и номеру ВУ");
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Focus();
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            foreach (DataGridViewRow row in driversGrid.Rows)
            {
                row.Selected = false;
                row.Visible = true;
            }

            comboBox1.Items.Clear();
            comboBox1.Items.Add("тип транспортного средства");
            comboBox1.Items.Add("марка");
            comboBox1.Items.Add("модель");
            comboBox1.Items.Add("государственный номер");
            comboBox1.Items.Add("ФИО водителя");
            comboBox2.Items.Clear();
            comboBox2.Items.Add("типу транспортного средства");
            comboBox2.Items.Add("марке");
            comboBox2.Items.Add("модели");
            comboBox2.Items.Add("государственному номеру");
            comboBox2.Items.Add("ФИО водителя");
        }

        private async void vehicleGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var drivers = await ReadFromFile<Driver>(Drivers);
            DataGridViewRow selectedRow = vehicleGrid.CurrentRow;

            string type = selectedRow.Cells[0].Value.ToString();
            string mark = selectedRow.Cells[1].Value.ToString();
            string model = selectedRow.Cells[2].Value.ToString();
            string number = selectedRow.Cells[3].Value.ToString();
            string driverFullname = selectedRow.Cells[4].Value.ToString();
            string[] fullnames = drivers.Select(x => x.FullName).ToArray();

            VehicleForm vehicleForm = new VehicleForm(type, mark, model, number, driverFullname, fullnames);
            vehicleForm.ShowDialog();

            Vehicle newVehicle = new Vehicle(vehicleForm.VehicleType, vehicleForm.Mark,
                vehicleForm.Model, vehicleForm.GovernmentNumber, vehicleForm.Fullname);

            var vehicles = await ReadFromFile<Vehicle>(Vehicles);
            foreach (var v in vehicles)
            {
                if (v.Type.Equals(type) && v.Mark.Equals(mark) && v.Model.Equals(model)
                        && v.Number.Equals(number))
                {
                    if (!(vehicleForm.VehicleType.Equals(type) && vehicleForm.Mark.Equals(mark)
                        && vehicleForm.Model.Equals(model) && vehicleForm.GovernmentNumber.Equals(number)))
                    {
                        vehicles.Remove(v);
                        vehicles.Add(newVehicle);
                        selectedRow.Cells[0].Value = newVehicle.Type;
                        selectedRow.Cells[1].Value = newVehicle.Mark;
                        selectedRow.Cells[2].Value = newVehicle.Model;
                        selectedRow.Cells[3].Value = newVehicle.Number;
                        selectedRow.Cells[4].Value = newVehicle.FullName;
                        vehicleGrid.Refresh();
                        MessageBox.Show($"Автомобиль {newVehicle.Description} изменён!", "Изменение автомобиля", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Автомобиль {newVehicle.Description} не был изменён, внесите изменения!", "Неудачное изменение автомобиля", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(vehicles, Vehicles);
            vehicleGrid.ClearSelection();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DriversAndVehicles_SizeChanged(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Calculate the size of each half
            int halfWidth = formWidth / 2;
            int halfHeight = formHeight / 2;

            groupBox1.Size = new Size(halfWidth, halfHeight);

            groupBox4.Location = new Point(groupBox1.Right, groupBox1.Top);
            groupBox4.Size = new Size(halfWidth - 15, halfHeight);
            groupBox2.Location = new Point(groupBox1.Left, groupBox1.Bottom + 5);
            groupBox5.Location = new Point(groupBox4.Right - groupBox5.Width, groupBox4.Bottom + 5);
            groupBox3.Location = new Point(groupBox4.Left - groupBox3.Width / 2, groupBox4.Bottom + 5);
        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {
            driversGrid.Dock = DockStyle.Fill;
        }

        private void groupBox4_Resize(object sender, EventArgs e)
        {
            vehicleGrid.Dock = DockStyle.Fill;
        }
    }
}