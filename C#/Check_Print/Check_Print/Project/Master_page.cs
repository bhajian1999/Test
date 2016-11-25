using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Check_Print.Project
{
    public partial class Master_page : Form
    {
        int C_Row,r;
        public int mui;
        public string mun;
        Model.CHECK_PRINTEntities db = new Model.CHECK_PRINTEntities();
        PersianCalendar PC = new PersianCalendar();


        public Master_page(int MuserId,string MUserName)
        {
            InitializeComponent();
            mui = MuserId;
            mun = MUserName;
            
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("نرم افزار چاپ و صدور چک");
        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ورودنامبانکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankName bn = new BankName();
            bn.Show();

        }

        private void تعریفشرحچکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents dc = new Documents();
            dc.Show();

        }

        private void تعریفگیرندهچکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reciver dc = new Reciver();
            dc.Show();
        }

        private void تعریفحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account dc = new Account();
            dc.Show();

        }

        private void کاربرانبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User dc = new User();
            dc.Show();
        }

        private void تعریففرمتچاپیچکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckFormat dc = new CheckFormat();
            dc.Show();
        }

        private void Master_page_Load(object sender, EventArgs e)
        {
                                   
            comboBox1.ValueMember = "DC_Id";
            comboBox1.DisplayMember = "DC_Name";
            comboBox1.DataSource = db.DastehCheck.ToList();

            toolStripStatusLabel1.Text = "کاربر جاری سیستم: " +mun;

            comboBox2.ValueMember = "Shc_Id";
            comboBox2.DisplayMember = "Shc_Doc";
            comboBox2.DataSource = db.CheckDoc.ToList();

            comboBox2.Enabled = false; textBox1.Enabled = false; textBox2.Enabled = false; textBox3.Enabled = false;

            
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            r=int.Parse(comboBox1.SelectedValue.ToString());

            
            var query = from a in db.Check where a.DC_Id == r select new  {a.Check_Id,a.Status.Stat_Name,a.Serial,a.Darvajh,a.SDate,a.RDate,a.Mablagh,a.User.Name_Family };

            dataGridView1.DataSource = query.ToList();
            dataGridView1.Columns["Check_Id"].Visible = false;
            dataGridView1.Columns["Stat_Name"].HeaderText = "وضعیت چک";
            dataGridView1.Columns["Serial"].HeaderText = "شماره چک";
            dataGridView1.Columns["SDate"].HeaderText = "تاریخ صدور";
            dataGridView1.Columns["RDate"].HeaderText = "تاریخ سر رسید";
            dataGridView1.Columns["Darvajh"].HeaderText = "در وجه";
            dataGridView1.Columns["Mablagh"].HeaderText = "مبلغ چک";
            dataGridView1.Columns["Name_Family"].HeaderText = "نام ایجاد کننده";
        }

        private void تعریفدستهچکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBook dc = new CheckBook();
            dc.Show();
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            decimal Number;
            if (decimal.TryParse(textBox2.Text, out Number))
            {
                textBox2.Text = string.Format("{0:N0}", Number);
                textBox2.SelectionStart = textBox2.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            C_Row = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            

            if (button1.Text == "ذخیره")
            {
                Model.Check ttbbl = db.Check.First(i => i.Check_Id == C_Row);
                string taghvim = PC.GetYear(DateTime.Now) + "/" + PC.GetMonth(DateTime.Now) + "/" + PC.GetDayOfMonth(DateTime.Now);
                //label1.Text = taghvim;

                ttbbl.Darvajh = comboBox2.Text;
                ttbbl.RDate = textBox1.Text;
                ttbbl.Mablagh = textBox2.Text;
                ttbbl.User_id = mui;
                ttbbl.Status_Id = 2;
                ttbbl.SDate = taghvim;
                

                db.SaveChanges();
                button1.Text = "صدور چک";
                
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; 
                comboBox2.Enabled = false; textBox1.Enabled = false; textBox2.Enabled = false; textBox3.Enabled = false;
                //------------------------------------------------------------                
                var query = from a in db.Check where a.DC_Id == r select new { a.Check_Id, a.Status.Stat_Name, a.Serial, a.Darvajh, a.SDate, a.RDate, a.Mablagh, a.User.Name_Family };

                dataGridView1.DataSource = query.ToList();
               
                //------------------------------------------------------------
            }
            else

            if (button1.Text == "صدور چک")
            {
                Model.Check ttbbl = db.Check.First(i => i.Check_Id == C_Row);
                comboBox2.Enabled = true; textBox1.Enabled = true; textBox2.Enabled = true; textBox3.Enabled = true;
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                button1.Text = "ذخیره";
               
            }

        
        
    }
    }
}
