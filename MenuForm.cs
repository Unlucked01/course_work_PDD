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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ButtonCloseMainForm_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ButtonAccountingFilm_Click(object sender, EventArgs e)
        {
            DriversAndVehicles filmFestival = new DriversAndVehicles();
            filmFestival.ShowDialog();
        }

        private void ButtonAccountingGuest_Click(object sender, EventArgs e)
        {
            BillsForm billsForm = new BillsForm();
            billsForm.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

    }
}
