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
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("ex3", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            //input parameter of stored procedure
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@en", txtename.Text);
            //adp.SelectCommand.Parameters.AddWithValue("@g", txtgender.Text);
           // adp.SelectCommand.Parameters.AddWithValue("@db", DateTime.Parse(dtpdob.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            SqlParameter p = new SqlParameter("@result", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=adodb;Data Source=DESKTOP-I8O23UC");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("ex4", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            //input parameter of stored procedure
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            //adp.SelectCommand.Parameters.AddWithValue("@en", txtename.Text);
            //adp.SelectCommand.Parameters.AddWithValue("@g", txtgender.Text);
            // adp.SelectCommand.Parameters.AddWithValue("@db", DateTime.Parse(dtpdob.Text));
           // adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            SqlParameter p = new SqlParameter("@result", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());
        }
    }
}
