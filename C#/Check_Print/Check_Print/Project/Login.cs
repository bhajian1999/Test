using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Print
{
   
    public partial class Login : Form
    {
        public int MUserId;
        public string  MUserName;
        public Login()
        {
            InitializeComponent();
        }
        Model.CHECK_PRINTEntities db = new Model.CHECK_PRINTEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            log();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

                
        private void log()
        {
            var query = from r in db.User
                        where r.User_name == textBox1.Text && r.Password == textBox2.Text
                        select r;
            if (query.Count() == 1)
            {
                Model.User ubn = db.User.First(i => i.User_name == textBox1.Text);
                MUserName = ubn.Name_Family;
                MUserId = ubn.User_Id;

                this.Hide();
                Project.Master_page Mp = new Project.Master_page(MUserId, MUserName);
                Mp.Show();
            }

            else {
                MessageBox.Show("نام کاربری یا کلمه عبور صحیح نمی باشد");

            }
        }

     }
}
