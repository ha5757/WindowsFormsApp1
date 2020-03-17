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
    public partial class Form10 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
            adp = new SqlDataAdapter("select * from productdetails", con);
            ds = new DataSet();
            adp.Fill(ds, "c");
            dataGridView1.DataSource = ds.Tables["c"];
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["c"].Value = false;
            }
            dataGridView1.CurrentRow.Cells["c"].Value = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if ((bool)(dataGridView1.Rows[i].Cells[0] as DataGridViewCheckBoxCell).Value == true)
                    {
                        string pid = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        adp = new SqlDataAdapter("select *from productdetails where productid=@pid", con);
                        adp.SelectCommand.Parameters.AddWithValue("@pid", pid);
                        ds = new DataSet();
                        adp.Fill(ds, "ss");
                        DataRow r = ds.Tables["ss"].Rows[0];

                        string PID = r[0].ToString();
                        string PDESC = r[1].ToString();
                        string PRICE = r[2].ToString();

                        Form11 f2 = new Form11(PID, PDESC, PRICE);


                        f2.Show();
                    }
                }
            }
        }
    }
}

