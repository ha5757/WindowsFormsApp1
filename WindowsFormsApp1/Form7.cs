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
    public partial class Form7 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
         {
            adp = new SqlDataAdapter("select count(*) from orderdetails", con);
            ds = new DataSet();
            adp.Fill(ds,"c");
            txtorderid.Text =(int.Parse( ds.Tables["c"].Rows[0][0].ToString())+1).ToString();
            adp = new SqlDataAdapter("select salesmanid,salesmanname from salesmandetails",con);
            adp.Fill(ds, "s");
            cbbsalesmanid.DataSource = ds.Tables["s"];
            cbbsalesmanid.DisplayMember = "salesmanname";
            cbbsalesmanid.ValueMember = "salesmanid";

            adp = new SqlDataAdapter("select customerid,customername from customerdetails", con);
            adp.Fill(ds, "cust");
            cbbcustomerid.DataSource = ds.Tables["cust"];
            cbbcustomerid.DisplayMember = "customername";
            cbbcustomerid.ValueMember = "customerid";
            panel1.Visible = true;
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(dgvdata.CurrentCell.ColumnIndex.Equals(0))
            {
                adp = new SqlDataAdapter("select productid from productdetails",con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "pid");
                foreach(DataGridViewRow row in dgvdata.Rows)
                {
                  (row.Cells[0] as DataGridViewComboBoxCell).DataSource=ds.Tables["pid"];
                    (row.Cells[0] as DataGridViewComboBoxCell).DisplayMember= "productid";
                    
                }
            }
        }

        private void dgvdata_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvdata_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvdata.CurrentRow.Cells[0].Value != null)
            {
                if (!dgvdata.CurrentCell.ColumnIndex.Equals(0))
                {
                    adp = new SqlDataAdapter("select *from productdetails where productid=@p", con);
                    adp.SelectCommand.Parameters.AddWithValue("@p", dgvdata.CurrentRow.Cells[0].Value);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "p");
                    dgvdata.CurrentRow.Cells[1].Value = ds.Tables["p"].Rows[0][1];
                    dgvdata.CurrentRow.Cells[3].Value = ds.Tables["p"].Rows[0][2];
                }
            }
        }

        private void dgvdata_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.CurrentRow.Cells[2].Value != null) 
            {
                int q = int.Parse(dgvdata.CurrentRow.Cells[2].Value.ToString());
                int p = int.Parse(dgvdata.CurrentRow.Cells[3].Value.ToString());
                dgvdata.CurrentRow.Cells[4].Value = q * p;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_OrderProducts", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@oid ", txtorderid.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdesc ", txtorderdesc.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdate ", DateTime.Parse(txtorderdate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@discount  ", int.Parse(txtdiscount.Text));
            adp.SelectCommand.Parameters.AddWithValue("@custid  ", cbbcustomerid.SelectedValue);
            adp.SelectCommand.Parameters.AddWithValue("@salesid  ", cbbsalesmanid.SelectedValue);


            DataTable mytable = new DataTable();
            mytable.Columns.Add("Orderid", typeof(string));
            mytable.Columns.Add("ProductID", typeof(string));
            
            mytable.Columns.Add("qty", typeof(Int32));
            for(int i=0;i<dgvdata.Rows.Count-1;i++)
            {
                mytable.Rows.Add(txtorderid.Text, dgvdata.Rows[i].Cells[0].Value.ToString(),dgvdata.Rows[i].Cells[2].Value);
            }
            SqlParameter p = new SqlParameter("@ord_pro", mytable);
            p.SqlDbType = SqlDbType.Structured;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show("ORDER PLACED");
            panel1.Visible = false;
        }
    }
}
