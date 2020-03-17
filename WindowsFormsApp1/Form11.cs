using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11(string pid, string pdesc, string price)
        {
            InitializeComponent();
            label4.Text = pid;
            label5.Text = pdesc;
            label6.Text = price;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
           
        }
    }
}
