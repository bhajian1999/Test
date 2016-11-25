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
    public partial class CheckBook : Form
    {
        Model.CHECK_PRINTEntities db = new Model.CHECK_PRINTEntities();
        int C_Row;
        public CheckBook()
        {
            InitializeComponent();
        }
        private void CheckBook_Load(object sender, EventArgs e)
        {

            comboBox1.Enabled = false;comboBox2.Enabled = false; textBox1.Enabled = false; textBox2.Enabled = false; textBox3.Enabled = false; textBox4.Enabled = false;

            var lst = from d in db.DastehCheck select new {d.DC_Id,d.DC_Name,d.DC_GSerial,d.Account.Hesab_Name,d.DC_Start,d.DC_End,d.PrintFormat.PF_Name  };
            dataGridView1.DataSource = lst.ToList();
           // dataGridView1.DataSource = db.DastehCheck.ToList();

            //dataGridView1.Columns["DC_Id"].Visible = false;
            
            dataGridView1.Columns["DC_Name"].HeaderText = "نام دسته چک";
            dataGridView1.Columns["DC_GSerial"].HeaderText = "سریال دسته چک";
            dataGridView1.Columns["Hesab_Name"].HeaderText = "نام حساب";
            dataGridView1.Columns["DC_Start"].HeaderText = "شماره اولین برگ";
            dataGridView1.Columns["DC_End"].HeaderText = "شماره آخرین برگ";
            dataGridView1.Columns["PF_Name"].HeaderText = "نمونه چاپی";
            

            //----------------------------------------------------------------------------------



            //----------------------------------------------------------------------------------

             comboBox1.ValueMember = "Hesab_Id";
             comboBox1.DisplayMember = "Hesab_Name";
             comboBox1.DataSource = db.Account.ToList();

             comboBox2.ValueMember = "PF_Id";
             comboBox2.DisplayMember = "PF_Name";
             comboBox2.DataSource = db.PrintFormat.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // C_Row = 1;


            C_Row = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //  MessageBox.Show(C_Row.ToString());


            if (button1.Text == "ذخیره")
            {
                Model.DastehCheck ttbbl = db.DastehCheck.First(i => i.DC_Id == C_Row);

                db.DastehCheck.Add(ttbbl);

                
                ttbbl.DC_Name = textBox1.Text;
                ttbbl.DC_GSerial = textBox2.Text;
                ttbbl.DC_Start = int.Parse(textBox3.Text);
                ttbbl.DC_End = int.Parse(textBox4.Text)+int.Parse(textBox3.Text);

                ttbbl.DC_Hesab_Id = int.Parse(comboBox1.SelectedValue.ToString());
                ttbbl.Print_Formate_Id = int.Parse(comboBox2.SelectedValue.ToString());

                db.SaveChanges();

                Model.Check chtbl = db.Check.First();

                int a = int.Parse(textBox4.Text.ToString());
             
                for(int i=0;i < a;i++ )
                {
                    
                    db.Check.Add(chtbl);
                    chtbl.DC_Id = ttbbl.DC_Id;
                    chtbl.SDate = "";
                    chtbl.RDate = "";
                    chtbl.Darvajh = "";
                    chtbl.Mablagh = "0";
                    //chtbl.Status = 1;
                    chtbl.Serial = int.Parse(textBox3.Text)+i;
                    db.SaveChanges();

                }

                


                button1.Text = "ایجاد";
                //MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
                comboBox1.Enabled = false; comboBox2.Enabled = false; textBox1.Enabled = false; textBox2.Enabled = false; textBox3.Enabled = false; textBox4.Enabled = false;
                var lst = from d in db.DastehCheck select new { d.DC_Id, d.DC_Name, d.DC_GSerial, d.Account.Hesab_Name, d.DC_Start, d.DC_End, d.PrintFormat.PF_Name };
                dataGridView1.DataSource = lst.ToList();


            }
            else

            if (button1.Text == "ایجاد")
            {

                Model.DastehCheck ttbbl = db.DastehCheck.First(i => i.DC_Id == C_Row);
                comboBox1.Enabled = true; comboBox2.Enabled = true; textBox1.Enabled = true; textBox2.Enabled = true; textBox3.Enabled = true; textBox4.Enabled = true;
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
                

                button1.Text = "ذخیره";
                //MessageBox.Show("اطلاعات آماده ویرایش می باشد");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            C_Row = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //  MessageBox.Show(C_Row.ToString());


            if (button2.Text == "ذخیره")
            {
                Model.Account ttbbl = db.Account.First(i => i.Hesab_Id == C_Row);



                ttbbl.Bank_id = int.Parse(comboBox1.SelectedValue.ToString());
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
                */
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.DastehCheck ttbbl = db.DastehCheck.First(i => i.DC_Id == a);
            db.DastehCheck.Remove(ttbbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.DastehCheck.ToList();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

           
            this.Close();
        }

        
    }
}
