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
    public partial class Reciver : Form
    {
        Model.CHECK_PRINTEntities db = new Model.CHECK_PRINTEntities();
        public Reciver()
        {
            InitializeComponent();
        }
        private void Reciver_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Reciver.ToList();
            dataGridView1.Columns["Riciver_Id"].Visible = false;
            dataGridView1.Columns["Reciver_Name"].HeaderText = "شرح چک";
            //dataGridView1.Columns["Account"].Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Model.Reciver tbl = new Model.Reciver();
            tbl.Reciver_Name = textBox1.Text;
            db.Reciver.Add(tbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.Reciver.ToList();
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.Reciver ttbbl = db.Reciver.First(i => i.Riciver_Id == a);
            ttbbl.Reciver_Name = textBox1.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Reciver.ToList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.Reciver ttbbl = db.Reciver.First(i => i.Riciver_Id == a);
            db.Reciver.Remove(ttbbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.Reciver.ToList();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
