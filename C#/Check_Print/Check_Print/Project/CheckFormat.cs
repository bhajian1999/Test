using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Check_Print.Project
{
    public partial class CheckFormat : Form
    {
        Model.CHECK_PRINTEntities db = new Model.CHECK_PRINTEntities();
        public byte[] arrPic;
        int C_Row;

        MemoryStream ms = new MemoryStream();
        public CheckFormat()
        {
            InitializeComponent();
        }

        private void CheckFormat_Load(object sender, EventArgs e)
        {


         

            dataGridView1.DataSource = db.PrintFormat.ToList();
            dataGridView1.Columns["PF_Name"].HeaderText = "شرح چک";
            dataGridView1.Columns["Pf_Pic"].Visible = false;


            arrPic = (byte[])(dataGridView1.CurrentRow.Cells[2].Value);
            MemoryStream ms = new MemoryStream(arrPic);
            pictureBox1.Image = Image.FromStream(ms);



        }
        private void button1_Click(object sender, EventArgs e)
        {

            Model.PrintFormat tbl = new Model.PrintFormat();
            tbl.PF_Name = textBox1.Text;
            byte[] arrPic = ms.GetBuffer();
            tbl.Pf_Pic = arrPic;
            db.PrintFormat.Add(tbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.PrintFormat.ToList();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C_Row = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
               //  MessageBox.Show(C_Row.ToString());
           
            
            if (button2.Text == "ذخیره")
            {
                Model.PrintFormat ttbbl = db.PrintFormat.First(i => i.PF_Id == C_Row);
                ttbbl.PF_Name = textBox1.Text;
                ttbbl.Pf_Pic = ImageToByte(pictureBox1.Image);
                db.SaveChanges();

                button2.Text = "ویرایش";
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
                textBox1.Text = "";
                dataGridView1.DataSource = db.PrintFormat.ToList();

            }
            else

            if (button2.Text == "ویرایش")
            {
                Model.PrintFormat ttbbl = db.PrintFormat.First(i => i.PF_Id == C_Row);
                textBox1.Text = ttbbl.PF_Name;
                button2.Text = "ذخیره";
                MessageBox.Show("اطلاعات آماده ویرایش می باشد");
            }
            
            
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Model.PrintFormat ttbbl = db.PrintFormat.First(i => i.PF_Id == a);


            db.PrintFormat.Remove(ttbbl);
            //db.PrintFormat.Remove(dataGridView1.CurrentRow.);

            db.SaveChanges();
            dataGridView1.DataSource = db.PrintFormat.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
          
            pictureBox1.Image = Image.FromFile(op.FileName);
            textBox2.Text = op.FileName;
            
            ////////////////////////////////////////////////////////////////
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] arrPic = ms.GetBuffer();

            


 
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         

            arrPic = (byte[])(dataGridView1.CurrentRow.Cells[2].Value);
            MemoryStream ms = new MemoryStream(arrPic);
            pictureBox1.Image = Image.FromStream(ms);
          

            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrintFormat pn = new PrintFormat(arrPic);
            pn.Show();
        }
    }
}
