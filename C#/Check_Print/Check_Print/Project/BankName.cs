using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Print.Project
{
    public partial class BankName : Form
    {
        Model.CHECK_PRINTEntities db = new Model.CHECK_PRINTEntities();

        public BankName()
        {
            InitializeComponent();
        }
        private void BankName_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Bank.ToList();
            dataGridView1.Columns["Bank_Id"].Visible = false;
            dataGridView1.Columns["Bank_Name"].HeaderText = "نام بانک";
            dataGridView1.Columns["Account"].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Bank tbl = new Model.Bank();
            tbl.Bank_Name = textBox1.Text;
            db.Bank.Add(tbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.Bank.ToList();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.Bank ttbbl = db.Bank.First(i => i.Bank_Id == a);
            ttbbl.Bank_Name= textBox1.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Bank.ToList();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.Bank ttbbl = db.Bank.First(i => i.Bank_Id == a);
            db.Bank.Remove(ttbbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.Bank.ToList();

        }
    }
}
