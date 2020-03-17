namespace WindowsFormsApp1
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.productid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbsalesmanid = new System.Windows.Forms.ComboBox();
            this.cbbcustomerid = new System.Windows.Forms.ComboBox();
            this.txtorderdate = new System.Windows.Forms.DateTimePicker();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtorderdesc = new System.Windows.Forms.TextBox();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvdata);
            this.panel1.Controls.Add(this.cbbsalesmanid);
            this.panel1.Controls.Add(this.cbbcustomerid);
            this.panel1.Controls.Add(this.txtorderdate);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.txtorderdesc);
            this.panel1.Controls.Add(this.txtorderid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(159, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 345);
            this.panel1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.productdesc,
            this.quantity,
            this.unitprice,
            this.totalcost});
            this.dgvdata.Location = new System.Drawing.Point(150, 167);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(507, 125);
            this.dgvdata.TabIndex = 26;
            this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick);
            this.dgvdata.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellLeave);
            this.dgvdata.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_RowLeave);
            this.dgvdata.SelectionChanged += new System.EventHandler(this.dgvdata_SelectionChanged);
            // 
            // productid
            // 
            this.productid.HeaderText = "product id";
            this.productid.Name = "productid";
            this.productid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // productdesc
            // 
            this.productdesc.HeaderText = "description";
            this.productdesc.Name = "productdesc";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "qty";
            this.quantity.Name = "quantity";
            // 
            // unitprice
            // 
            this.unitprice.HeaderText = "unit price";
            this.unitprice.Name = "unitprice";
            // 
            // totalcost
            // 
            this.totalcost.HeaderText = "total cost";
            this.totalcost.Name = "totalcost";
            // 
            // cbbsalesmanid
            // 
            this.cbbsalesmanid.FormattingEnabled = true;
            this.cbbsalesmanid.Location = new System.Drawing.Point(512, 125);
            this.cbbsalesmanid.Name = "cbbsalesmanid";
            this.cbbsalesmanid.Size = new System.Drawing.Size(121, 21);
            this.cbbsalesmanid.TabIndex = 25;
            // 
            // cbbcustomerid
            // 
            this.cbbcustomerid.FormattingEnabled = true;
            this.cbbcustomerid.Location = new System.Drawing.Point(512, 73);
            this.cbbcustomerid.Name = "cbbcustomerid";
            this.cbbcustomerid.Size = new System.Drawing.Size(121, 21);
            this.cbbcustomerid.TabIndex = 24;
            // 
            // txtorderdate
            // 
            this.txtorderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtorderdate.Location = new System.Drawing.Point(130, 101);
            this.txtorderdate.Name = "txtorderdate";
            this.txtorderdate.Size = new System.Drawing.Size(100, 20);
            this.txtorderdate.TabIndex = 23;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(512, 18);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(121, 20);
            this.txtdiscount.TabIndex = 22;
            // 
            // txtorderdesc
            // 
            this.txtorderdesc.Location = new System.Drawing.Point(130, 52);
            this.txtorderdesc.Name = "txtorderdesc";
            this.txtorderdesc.Size = new System.Drawing.Size(100, 20);
            this.txtorderdesc.TabIndex = 21;
            // 
            // txtorderid
            // 
            this.txtorderid.Enabled = false;
            this.txtorderid.Location = new System.Drawing.Point(130, 10);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(100, 20);
            this.txtorderid.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "salesmanid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "customer id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "orderdate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "orderdesc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "orderid";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.ComboBox cbbsalesmanid;
        private System.Windows.Forms.ComboBox cbbcustomerid;
        private System.Windows.Forms.DateTimePicker txtorderdate;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtorderdesc;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewComboBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcost;
    }
}