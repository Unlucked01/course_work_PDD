using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cours_work_PDD
{
    public partial class BillsForm : Form
    {
        const string Bills = "Bills.json";

        public BillsForm()
        {
            Task.Run(() => File.Open(Bills, FileMode.OpenOrCreate).Close());
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

        async private void ButtonCreateGuest_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm();
            billForm.ShowDialog();
            Bill bill = new Bill(billForm.Fullname, billForm.VehicleDescription, billForm.Reason, billForm.Amount);
            
            var bills = await ReadFromFile<Bill>(Bills);
            if(!(bill.Fullname.Equals(string.Empty) && bill.VehicleDescription.Equals(string.Empty) && 
                bill.Reason.Equals(string.Empty)))
            {
                foreach (var b in bills)
                {
                    if (b.Fullname.Equals(bill.Fullname) && b.VehicleDescription.Equals(bill.VehicleDescription) && b.Reason.Equals(bill.Reason) && b.Amount == bill.Amount)
                    {
                        MessageBox.Show($"Штраф {b.Reason} на сумму: {b.Amount} для {b.VehicleDescription} уже занесён в базу Штрафов.", "Неудачное добавление штрафа", 0, MessageBoxIcon.Information);
                        return;
                    }
                }
                bills.Add(bill);
                billCount.Text = bills.Count.ToString();
                billsGrid.Rows.Add(bill.Fullname, bill.VehicleDescription, bill.Reason, bill.Amount.ToString("C", new CultureInfo("ru-RU")));
            }
            await WriteToFile(bills, Bills);
        }

        async private void GuestFestivalForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(Bills))
            {
                var initaialBills = await ReadFromFile<Bill>(Bills);
                billCount.Text = Convert.ToString(initaialBills.Count.ToString());
                if (initaialBills != null)
                {
                    foreach (var b in initaialBills)
                    {
                        int index = billsGrid.Rows.Add();
                        billsGrid.Rows[index].Cells[0].Value = b.Fullname;
                        billsGrid.Rows[index].Cells[1].Value = b.VehicleDescription;
                        billsGrid.Rows[index].Cells[2].Value = b.Reason;
                        billsGrid.Rows[index].Cells[3].Value = b.Amount.ToString("C", new CultureInfo("ru-RU"));
                        billsGrid.Rows[index].Cells[4].Value = false;
                    }
                }
            }
            billsGrid.CurrentCell = null;
            for(int i = 0; i < billsGrid.Columns.Count - 2; i++)
            {
                billsGrid.Columns[i].ReadOnly = true;
            }
        }

       async private void ButtonDeleteGuest_Click(object sender, EventArgs e)
        {
            int selectedCount = billsGrid.SelectedRows.Count;

            if (selectedCount > 0)
            {
                var bills = await ReadFromFile<Bill>(Bills);
                if (selectedCount == 1)
                {
                    var removedBill = bills[billsGrid.SelectedRows[0].Index];
                    MessageBox.Show($"Штраф {removedBill.Reason} на сумму: {removedBill.Amount} для {removedBill.VehicleDescription} удалён", "Удаление одного штрафа", 0,
                            MessageBoxIcon.Information);
                    bills.Remove(removedBill);
                    billsGrid.Rows.Remove(billsGrid.SelectedRows[0]);
                }
                else
                {
                    int[] selectedIndexes = new int[selectedCount];
                    List<int> removedIndexes = new List<int>();
                    for (int i = 0; i < selectedCount; i++)
                    {
                        selectedIndexes[i] = billsGrid.SelectedRows[i].Index;
                    }
                    Array.Sort(selectedIndexes);
                    foreach (var elem in selectedIndexes.Reverse())
                    {
                        bills.Remove(bills[elem]);
                        billsGrid.Rows.RemoveAt(elem);
                        removedIndexes.Add(elem);
                    }
                    string removedIndexesStr = string.Join(", ", removedIndexes.ToArray());
                    MessageBox.Show($"Штрафы с индексами: {removedIndexesStr} удалены!", "Удаление нескольких штрафов", 0,
                        MessageBoxIcon.Information);
                }
                billCount.Text = bills.Count.ToString();
                billsGrid.Refresh();
                await WriteToFile(bills, Bills);
            }
            else
            {
                MessageBox.Show("Нет ни одного штрафа или вы не выбрали штраф для удаленя!",
                    "Неудачное удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

       async private void ButtonAllDeleteGuest_Click(object sender, EventArgs e)
        {
            var bills = await ReadFromFile<Bill>(Bills);
            if (bills.Count == 0)
            {
                MessageBox.Show("Нет ни одного штрафа!", "Удалить все штрафы", 0, MessageBoxIcon.Information);
                return;
            }
            bills.Clear();
            billsGrid.Rows.Clear();
            billCount.Text = bills.Count.ToString();
            MessageBox.Show("Данные всех штрафов удалены!", "Удалить все штрафы", 0, MessageBoxIcon.Information);
            await WriteToFile(bills, Bills);
        }

        private void ButtonCloseGuestTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                comboBox2.Enabled = true;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите поле для фильтрации!", "Внимание", 0, MessageBoxIcon.Information);
                return;
            }
            string searchValue = textBox1.Text;
            int columnIndex = comboBox1.SelectedIndex;
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in billsGrid.Rows)
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

        private async void dataGridViewGuestTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = billsGrid.CurrentRow;

            string fullname = selectedRow.Cells[0].Value.ToString();
            string description = selectedRow.Cells[1].Value.ToString();
            string reason = selectedRow.Cells[2].Value.ToString();

            BillForm billForm = new BillForm(fullname, description, reason);
            billForm.ShowDialog();

            Bill modBill = new Bill(billForm.Fullname,
                billForm.VehicleDescription, billForm.Reason, billForm.Amount);

            var bills = await ReadFromFile<Bill>(Bills);

            foreach (var b in bills)
            {
                if (b.Fullname.Equals(fullname) && b.VehicleDescription.Equals(description) && b.Reason.Equals(reason))
                {
                    if (!(modBill.Fullname.Equals(fullname) && modBill.VehicleDescription.Equals(description) && modBill.Reason.Equals(reason)))
                    {
                        bills.Remove(b);
                        bills.Add(modBill);
                        selectedRow.Cells[0].Value = modBill.Fullname;
                        selectedRow.Cells[1].Value = modBill.VehicleDescription;
                        selectedRow.Cells[2].Value = modBill.Reason;
                        selectedRow.Cells[3].Value = modBill.Amount;
                        billsGrid.Refresh();
                        MessageBox.Show($"Штраф {modBill.Reason} на сумму: {modBill.Amount} для {modBill.VehicleDescription} изменён!", "Изменение штрафа", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Штраф {modBill.Reason} на сумму: {modBill.Amount} для {modBill.VehicleDescription} не изменён!", "Неудачное изменение штрафа", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(bills, Bills);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox2.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelKolvoSearch.Visible = true;
            textBoxKolvoSearch.Visible = true;
            button2.Enabled = true;
            string searchText = textBox2.Text.ToLower();

            bool found = false;

            foreach (DataGridViewRow row in billsGrid.Rows)
            {
                if (row.Cells[comboBox2.SelectedIndex].Value != null && row.Cells[comboBox2.SelectedIndex].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Selected = true;
                    found = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
            textBoxKolvoSearch.Text = billsGrid.SelectedRows.Count.ToString();
            if (!found)
            {
                MessageBox.Show($"Гость с введёнными данными: {searchText} - отсутствует!", "Неудачный поиск гостя", 0,
                            MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxKolvoSearch.Text = "";
            textBoxKolvoSearch.Visible = false;
            comboBox1.Enabled = true;
            labelKolvoSearch.Visible = false;
            textBox2.Text = "";
            foreach (DataGridViewRow row in billsGrid.Rows)
            {
                row.Selected = false;
            }
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (DataGridViewRow row in billsGrid.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[billsGrid.Columns.Count - 1].Value);
                    row.Visible = isChecked;
                }
            }
            else
            {
                foreach (DataGridViewRow row in billsGrid.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[billsGrid.Columns.Count - 1].Value);
                    row.Visible = !isChecked;
                }
            }
        }

        private void billsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == billsGrid.Columns["Column5"].Index) 
            {
                billsGrid.Rows[e.RowIndex].Visible = false; 
            }
            else
            {
                billsGrid.Rows[e.RowIndex].Visible = true;
            }
        }
    }
}
