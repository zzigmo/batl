using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;
using System.Reflection.Emit;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace батл_тенденси
{
    public partial class Form1 : Form
    {


        public int hp1 = 100;
        public int hp2 = 100;
        Random dem = new Random();
        public Form1()
        {
            InitializeComponent();

            FileInfo infa = new FileInfo("tt.txt");
            if (infa.Exists == false)
            {
                infa.Create();
            }
            
          
        }
        public damag dam = new damag();
        public StreamWriter text;



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int blok = dem.Next(1, 4);
            int atak = dem.Next(1, 4);
            

            switch (blok)
            {
                case (1):
                    label4.Text = "противник выбрал защитить голову";
                    break;
                case (2):
                    label4.Text = "противник выбрал защитить корпус";
                    break;
                case (3):
                    label4.Text = "противник выбрал защитить ноги";
                    break;
            }
            switch (atak)
            {
                case (1):
                    label5.Text = "противник выбрал ударить в голову";
                    break;
                case (2):
                    label5.Text = "противник выбрал ударить в корпус";
                    break;
                case (3):
                    label5.Text = "противник выбрал ударить по ногам";
                    break;
            }
            // апустим этот момент
             if (button7.BackColor == Color.Lime)
            {
                b = 1;
                
            }
             if (button6.BackColor == Color.Lime)
            {
                b = 2; 
            }
             if (button5.BackColor == Color.Lime)
            {
                b = 3; 
            }
            if (button2.BackColor == Color.Lime)
            {
                a = 1; 
            }
            if (button3.BackColor == Color.Lime)
            {
                a = 2;
            }
            if (button4.BackColor == Color.Lime)
            {
                a = 3; 
            }
            // дамак по противнику
            if ( a == blok)
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
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button7.BackColor = Color.Lime;      
            button6.BackColor = Color.Gainsboro; 
            button5.BackColor = Color.Gainsboro;   
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

        private void button2_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gainsboro; 
            button3.BackColor = Color.Gainsboro; 
            button2.BackColor = Color.Lime;      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gainsboro; 
            button2.BackColor = Color.Gainsboro; 
            button3.BackColor = Color.Lime;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gainsboro; 
            button3.BackColor = Color.Gainsboro; 
            button4.BackColor = Color.Lime;    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo choo = new FileInfo("tt.txt");
                if (choo.Exists == true)
                {
                    choo.Delete();
                }
                this.Close();
            }
            catch { MessageBox.Show("uu"); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            test test = new test();
            test.ShowDialog();
        }
    }
}
