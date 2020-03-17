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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.html;


namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-I8O23UC");
            adp = new SqlDataAdapter("select * from productdetails", con);
            ds = new DataSet();
            adp.Fill(ds, "c");
            dataGridView1.DataSource = ds.Tables["c"];
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            FileStream F = new FileStream(@"C:\Users\Admin\Desktop\pdf\hh\hari.pdf", FileMode.Create);
            Document doc = new Document();
            PdfWriter.GetInstance(doc, F);
            doc.Open();
            PdfPTable table1 = new PdfPTable(3);

            table1.WidthPercentage = 90;
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if ((bool)(dataGridView1.Rows[i].Cells[0] as DataGridViewCheckBoxCell).Value == true)
                    {
                        string PID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        PdfPCell cell11 = new PdfPCell();

                        cell11.AddElement(new Paragraph("PRODUCT ID:" +PID));
                        string PDESC = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        PdfPCell cell12 = new PdfPCell();

                        cell12.AddElement(new Paragraph("PRODUCT DESC : " + PDESC));

                        string PRICE = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        PdfPCell cell13 = new PdfPCell();

                        cell13.AddElement(new Paragraph("PRICE : " + PRICE));

                        cell12.VerticalAlignment = Element.ALIGN_RIGHT;
                        cell13.VerticalAlignment = Element.ALIGN_RIGHT;
                        table1.AddCell(cell11);

                        table1.AddCell(cell12);
                        table1.AddCell(cell13);
                        doc.Add(table1);



                        MessageBox.Show("file generated successfully");
                        
                        //   Form9 PD = new Form9(PID, PDESC, PRICE);
                        //  PD.Show();


                    }
                    
                }
            }
            doc.Add(table1);
            doc.Close();
        }

        
    }
}
