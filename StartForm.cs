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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StartForm_KeyDown(object sender, KeyEventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
