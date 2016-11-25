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
    public partial class User : Form
    {
        Model.CHECK_PRINTEntities db = new Model.CHECK_PRINTEntities();
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.User.ToList();
            dataGridView1.Columns["User_Id"].Visible = false;
            dataGridView1.Columns["User_Name"].HeaderText = "نام کاربری";
            dataGridView1.Columns["Password"].HeaderText = "کلمه عبور";
            dataGridView1.Columns["Name_Family"].HeaderText = "نام شخص";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Model.User tbl = new Model.User();
            tbl.User_name = textBox1.Text;
            tbl.Password = textBox2.Text;
            tbl.Name_Family = textBox3.Text;
            db.User.Add(tbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.User.ToList();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.User ttbbl = db.User.First(i => i.User_Id == a);
            ttbbl.User_name = textBox1.Text;
            ttbbl.User_name = textBox2.Text;
            ttbbl.Name_Family = textBox3.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.User.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.User ttbbl = db.User.First(i => i.User_Id == a);
            db.User.Remove(ttbbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.User.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
