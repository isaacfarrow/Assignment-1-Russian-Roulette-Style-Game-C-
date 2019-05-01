using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //minimize current window
            this.WindowState = FormWindowState.Minimized;

            // Open Windows form 1
            Form1 newForm = new Form1();
            newForm.ShowDialog();

            this.WindowState = FormWindowState.Normal;




        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
