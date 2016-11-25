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
    public partial class Documents : Form
    {
        Model.CHECK_PRINTEntities db = new Model.CHECK_PRINTEntities();
        public Documents()
        {
            InitializeComponent();
        }

        private void Documents_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.CheckDoc.ToList();
            dataGridView1.Columns["Shc_Id"].Visible = false;
            dataGridView1.Columns["Shc_Doc"].HeaderText = "شرح چک";
            //dataGridView1.Columns["Account"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.CheckDoc tbl = new Model.CheckDoc();
            tbl.Shc_Doc = textBox1.Text;
            db.CheckDoc.Add(tbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.CheckDoc.ToList();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.CheckDoc ttbbl = db.CheckDoc.First(i => i.Shc_Id == a);
            ttbbl.Shc_Doc = textBox1.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.CheckDoc.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.CheckDoc ttbbl = db.CheckDoc.First(i => i.Shc_Id == a);
            db.CheckDoc.Remove(ttbbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.CheckDoc.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
