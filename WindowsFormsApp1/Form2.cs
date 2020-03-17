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
    public partial class Form2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
        }

        private void txtempno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_extract", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow R = null;
            if (ds.Tables["E"].Rows.Count != 0)
            {
                R = ds.Tables["E"].Rows[0];
                txtename.Text = R[1].ToString();
                txtjob.Text = R[2].ToString();
                txtmgr.Text = R[3].ToString();
                dpthiredate.Text = R[4].ToString();
                txtsal.Text = R[5].ToString();
                txtcommission.Text = R[6].ToString();
                cbbdeptno.Text = R[7].ToString();
            }
            else
            {
                MessageBox.Show("no employee exists");
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_updatedata", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@newjob", txtjob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@incrper", int.Parse(txtincrement.Text));
            SqlParameter p = new SqlParameter("@status", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());
        }
    }
}



