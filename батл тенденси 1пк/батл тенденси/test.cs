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
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace батл_тенденси
{
    public partial class test : Form
    {
        int a = 0;
        int b = 0;
        int blok = 0;
        int atak = 0;
        public int hp1 = 100;
        public int hp2 = 100;

        public test()
        {
            InitializeComponent();
            
        }
        
        
        public damag dam = new damag();
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Lime;
            button6.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Lime;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Lime;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //тут был бот
            
                if (button7.BackColor == Color.Lime)
                {
                    b = 1;
                    FileInfo infa = new FileInfo("tt.txt");
                    StreamWriter text;
                    text = infa.AppendText();
                    text.WriteLine(b);
                    text.Close();

                }
                if (button6.BackColor == Color.Lime)
                {
                    b = 2;
                    FileInfo infa = new FileInfo("tt.txt");
                    StreamWriter text;
                    text = infa.AppendText();
                    text.WriteLine(b);
                    text.Close();
                }
                if (button5.BackColor == Color.Lime)
                {
                    b = 3;
                    FileInfo infa = new FileInfo("tt.txt");
                    StreamWriter text;
                    text = infa.AppendText();
                    text.WriteLine(b);
                    text.Close();
                }
                if (button2.BackColor == Color.Lime)
                {
                    a = 1;
                    FileInfo infa = new FileInfo("tt.txt");
                    StreamWriter text;
                    text = infa.AppendText();
                    text.WriteLine(a);
                    text.Close();
                }
                if (button3.BackColor == Color.Lime)
                {
                    a = 2;
                    FileInfo infa = new FileInfo("tt.txt");
                    StreamWriter text;
                    text = infa.AppendText();
                    text.WriteLine(a);
                    text.Close();
                }
                if (button4.BackColor == Color.Lime)
                {
                    a = 3;
                    FileInfo infa = new FileInfo("tt.txt");
                    StreamWriter text;
                    text = infa.AppendText();
                    text.WriteLine(a);
                    text.Close();
                }
            

           
            
                a = Convert.ToInt32(File.ReadLines(@"tt.txt").ElementAtOrDefault(0));
                b = Convert.ToInt32(File.ReadLines(@"tt.txt").ElementAtOrDefault(1));
                blok = Convert.ToInt32(File.ReadLines(@"I:\244-ИСП\244ИСП\ОАиП\Прокопьев\батл тенденси 2pc\батл тенденси\bin\Debug\gg.txt").ElementAtOrDefault(0));
                atak = Convert.ToInt32(File.ReadLines(@"I:\244-ИСП\244ИСП\ОАиП\Прокопьев\батл тенденси 2pc\батл тенденси\bin\Debug\gg.txt").ElementAtOrDefault(1));
            
            

            label9.Text = Convert.ToString(a);
            label10.Text = Convert.ToString(b);
            label11.Text = Convert.ToString(blok);
            label12.Text = Convert.ToString(atak);
            if (a == 0 || b == 0 || blok == 0 || atak == 0)
            {
                MessageBox.Show("противник не отвентил ");
            }
            else
            {
                // дамак по противнику
                if (a == blok)
                {
                    label7.Text = "ваша атака отражена";
                }
                else
                {
                    label7.Text = "вы успешно атаковали";
                    hp2 = dam.hits2(hp2);
                    progressBar2.Value = dam.hits2(hp2);
                    label2.Text = progressBar2.Value.ToString();

                }
                // дамак по вам
                if (b == atak)
                {
                    label6.Text = "вы отразили атаку";
                }
                else
                {
                    label6.Text = "атаку пропущена";
                    hp1 = dam.hits1(hp1);
                    progressBar1.Value = dam.hits1(hp1);
                    label1.Text = progressBar1.Value.ToString();
                }
                if (progressBar2.Value == 0)
                {
                    MessageBox.Show("You Win");
                    this.Close();
                }
                if (progressBar1.Value == 0)
                {
                    MessageBox.Show("You Luse");
                    this.Close();
                }
                File.WriteAllText(@"tt.txt", "");

            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Lime;
            button5.BackColor = Color.Gainsboro;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Lime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Lime;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
