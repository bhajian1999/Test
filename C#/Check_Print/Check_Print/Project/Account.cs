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
    public partial class Account : Form
    {
        Model.CHECK_PRINTEntities db = new Model.CHECK_PRINTEntities();
        int C_Row;
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false; textBox1.Enabled = false; textBox2.Enabled = false; textBox3.Enabled = false; textBox4.Enabled = false; textBox5.Enabled = false; textBox6.Enabled = false;
            //----------------------------------------------------------------------
            var lst = from d in db.Account select new {d.Hesab_Id ,d.Bank.Bank_Name,d.Hesab_Name,d.Hesab_Number,d.Branch_Name,d.Branch_Tel,d.Branch_Adress,d.Meli_Code };
            dataGridView1.DataSource = lst.ToList();
            //----------------------------------------------------------------------
            dataGridView1.Columns["Hesab_Id"].Visible = false;
            dataGridView1.Columns["Bank_Name"].HeaderText = "نام بانک";
            dataGridView1.Columns["Hesab_Name"].HeaderText = "نام حساب";
            dataGridView1.Columns["Hesab_Number"].HeaderText = "شماره حساب";
            dataGridView1.Columns["Branch_Name"].HeaderText = "نام شعبه";
            dataGridView1.Columns["Branch_Tel"].HeaderText = "تلفن شعبه";
            dataGridView1.Columns["Branch_Adress"].HeaderText = "آدرس شعبه";
            dataGridView1.Columns["Meli_Code"].HeaderText = "کد ملی";
           
            //----------------------------------------------------------------------------------



           

            comboBox1.ValueMember = "Bank_Id";
            comboBox1.DisplayMember = "Bank_Name";
            comboBox1.DataSource = db.Bank.ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           C_Row = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //C_Row = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //  MessageBox.Show(C_Row.ToString());


            if (button1.Text == "ذخیره")
            {
                Model.Account ttbbl = db.Account.First(i => i.Hesab_Id == C_Row);
                db.Account.Add(ttbbl);
                ttbbl.Bank_id = int.Parse(comboBox1.SelectedValue.ToString());
                ttbbl.Hesab_Name = textBox1.Text;
                ttbbl.Hesab_Number = textBox2.Text;
                ttbbl.Branch_Name = textBox3.Text;
                ttbbl.Branch_Tel = textBox4.Text;
                ttbbl.Branch_Adress = textBox5.Text;
                ttbbl.Meli_Code = textBox6.Text;
                db.SaveChanges();
                button1.Text = "ایجاد";
                //MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
                comboBox1.Enabled = false; textBox1.Enabled = false; textBox2.Enabled = false; textBox3.Enabled = false; textBox4.Enabled = false; textBox5.Enabled = false; textBox6.Enabled = false;
//------------------------------------------------------------                
                var lst = from d in db.Account select new { d.Hesab_Id, d.Bank.Bank_Name, d.Hesab_Name, d.Hesab_Number, d.Branch_Name, d.Branch_Tel, d.Branch_Adress, d.Meli_Code };
                dataGridView1.DataSource = lst.ToList();
//------------------------------------------------------------
            }
            else

            if (button1.Text == "ایجاد")
            {
                Model.Account ttbbl = db.Account.First(i => i.Hesab_Id == C_Row);
                comboBox1.Enabled = true; textBox1.Enabled = true; textBox2.Enabled = true; textBox3.Enabled = true; textBox4.Enabled = true; textBox5.Enabled = true; textBox6.Enabled = true;
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
                button1.Text = "ذخیره";
                //MessageBox.Show("اطلاعات آماده ویرایش می باشد");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             C_Row = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
               //  MessageBox.Show(C_Row.ToString());
           
            
            if (button2.Text == "ذخیره")
            {
                Model.Account ttbbl = db.Account.First(i => i.Hesab_Id == C_Row);



                ttbbl.Bank_id= int.Parse(comboBox1.SelectedValue.ToString());
                ttbbl.Hesab_Name = textBox1.Text;
                ttbbl.Hesab_Number = textBox2.Text;
                ttbbl.Branch_Name = textBox3.Text;
                ttbbl.Branch_Tel = textBox4.Text;
                ttbbl.Branch_Adress = textBox5.Text;
                ttbbl.Meli_Code = textBox6.Text;
    
                db.SaveChanges();

                button2.Text = "ویرایش";
                //MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
                comboBox1.Enabled = false; textBox1.Enabled = false; textBox2.Enabled = false; textBox3.Enabled = false; textBox4.Enabled = false; textBox5.Enabled = false; textBox6.Enabled = false;
                dataGridView1.DataSource = db.Account.ToList();

            }
            else

            if (button2.Text == "ویرایش")
            {
                Model.Account ttbbl = db.Account.First(i => i.Hesab_Id == C_Row);
                comboBox1.Enabled = true; textBox1.Enabled = true; textBox2.Enabled = true; textBox3.Enabled = true; textBox4.Enabled = true; textBox5.Enabled = true; textBox6.Enabled = true;
                textBox1.Text = ttbbl.Hesab_Name;
                textBox2.Text = ttbbl.Hesab_Number;
                textBox3.Text = ttbbl.Branch_Name;
                textBox4.Text = ttbbl.Branch_Tel;
                textBox5.Text = ttbbl.Branch_Adress;
                textBox6.Text = ttbbl.Meli_Code;

                button2.Text = "ذخیره";
                //MessageBox.Show("اطلاعات آماده ویرایش می باشد");
            }
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.Account ttbbl = db.Account.First(i => i.Hesab_Id == a);
            db.Account.Remove(ttbbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.Account.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
