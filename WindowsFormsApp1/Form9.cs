using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form9 : Form
    {
       
        public Form9(string pid, string pdesc, string price)
        {
            InitializeComponent();
            label4.Text = pid;
            label5.Text = pdesc;
            label6.Text = price;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
          
        }
    }
}
