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
    public partial class Form6 : Form
    {

        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_delete", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtempno.Text));
            SqlParameter p = new SqlParameter("@status", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());

        }
    }
}
