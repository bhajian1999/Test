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
    public partial class PrintFormat : Form
    {
        public byte[] arr_Pic;

        public PrintFormat( byte[] arrPic)
        {
            InitializeComponent();
            arr_Pic = arrPic;
        }
        
       


        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog2.ShowDialog();
            textBox2.Font = fontDialog2.Font;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog3.ShowDialog();
            textBox3.Font = fontDialog3.Font;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog4.ShowDialog();
            textBox4.Font = fontDialog4.Font;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog5.ShowDialog();
            textBox5.Font = fontDialog5.Font;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            fontDialog6.ShowDialog();
            textBox6.Font = fontDialog6.Font;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog7.ShowDialog();
            textBox7.Font = fontDialog7.Font;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            fontDialog8.ShowDialog();
            textBox8.Font = fontDialog8.Font;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            fontDialog9.ShowDialog();
            textBox9.Font = fontDialog9.Font;
        }


        private void PrintFormat_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(arr_Pic);
            pictureBox1.Image = Image.FromStream(ms);


            textBox1.Text = "95/12/29";
            textBox2.Text = "بیست و نهم اسفند ماه یکهزار و سیصدو نود و شش";
            textBox3.Text = "سی و دو میلیارد و چهار صدو نه میلیون و دویست و چهل و پنج هزار و پانصد و پنجاه و سه ریال تمام";
            textBox4.Text = "32'409'245'553";
            textBox5.Text = "بانک صادرات جهت واریز به حساب شبای به شماره:IR76-0170-000-0032-2244-5470-05 نزد بانک ملی به نام محمد مهدی شفیعی بابت حق التدریس دوره های بلند مدت//*";
            textBox6.Text = "1289066563";
            textBox7.Text = "1598755125";
            textBox8.Text = "/////////";
            textBox9.Text = "32,409,245,553Rls";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Left = int.Parse(numericUpDown1.Value.ToString());
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Top = int.Parse(numericUpDown2.Value.ToString());
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Left = int.Parse(numericUpDown3.Value.ToString());
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Top = int.Parse(numericUpDown4.Value.ToString());
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Left = int.Parse(numericUpDown5.Value.ToString());
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Top = int.Parse(numericUpDown6.Value.ToString());
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Left = int.Parse(numericUpDown7.Value.ToString());
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Top = int.Parse(numericUpDown8.Value.ToString());
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Left = int.Parse(numericUpDown9.Value.ToString());
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Top = int.Parse(numericUpDown10.Value.ToString());
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            textBox6.Left = int.Parse(numericUpDown11.Value.ToString());
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            textBox6.Top = int.Parse(numericUpDown12.Value.ToString());
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            textBox7.Left = int.Parse(numericUpDown13.Value.ToString());
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            textBox7.Top = int.Parse(numericUpDown14.Value.ToString());
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            textBox8.Left = int.Parse(numericUpDown15.Value.ToString());
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            textBox8.Top = int.Parse(numericUpDown16.Value.ToString());
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            textBox9.Left = int.Parse(numericUpDown17.Value.ToString());
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            textBox9.Top = int.Parse(numericUpDown18.Value.ToString());
        }

     
    }
}
