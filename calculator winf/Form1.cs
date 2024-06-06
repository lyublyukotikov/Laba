using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace calculator_winf
{
    public partial class калькулятор : Form
    {
        public string D;//создал переменную действия 
        public string N1;//
        public bool n2;
        public калькулятор()
        {
            n2 = false;
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            

        }

        
        private void Form1_Click_1(object sender, EventArgs e)
        {
            

        }





        private void Button24_Click(object sender, EventArgs e)
        {
           





        }

        private void Form1_Click_2(object sender, EventArgs e)
        {

            string aaa = Convert.ToString(sender);

            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";//стираем textbox для нового набора 
            }

            Button B = (Button)sender;//кнопка по которой нажали
            if (textBox1.Text == "0")//случай,если стоит 0
                textBox1.Text = B.Text;//если ноль тогда записываем B.text
            else
                textBox1.Text = textBox1.Text + B.Text;//Если первый стоит не ноль,тогда прибовляем посимвольно
        }

        private void Form1_Click_3(object sender, EventArgs e)//кнопка стерания С,CE //оставляем 
        {

            
            textBox1.Text = "0";//Обнуляем textbox
        }

        private void Form1_Click_4(object sender, EventArgs e)//группа действий +-*/
        {
            Button B = (Button)sender;//что мы написали 
            D = B.Text;//запоминаем действие (последнее,которое нажали)
            N1 = textBox1.Text;//запоминаем число,которое было набрано 
            n2 = true;//посмотрел на форуме.Если запомнили действие и текст,тогда нужно стереть для новой записи
        }

        private void Form1_Click_5(object sender, EventArgs e)//кнопка =
        {
            double dn1, dn2,res;
            res = 0;//результат 
            dn1 = Convert.ToDouble(N1);//создаем переменную для конвертации первого числа 
            dn2 = Convert.ToDouble(textBox1.Text);//создаем переменную для конвертации второго чила из textbox
            if(D=="+")
            {
                res = dn1 + dn2;
            }
            if (D== "-")
            {
                res = dn1 - dn2;
            }
            if (D== "×")
            {
                res = dn1 * dn2;
            }
            if (D== "/")
            {
                res = dn1 / dn2;
            }

            D = "=";
            if  (D=="=") 
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Bold);//делает шрифт BOLD

                n2 = true;
                textBox1.Text = res.ToString();//вывод результата
            }
            
        }
        //корень
        private void Button2_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();



        }
        //возведение в квадрат

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn,2);
            textBox1.Text = res.ToString();
        }
        //1/x
        private void button4_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();

        }



        private void button21_Click(object sender, EventArgs e)//+/-
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();


        }
        //процент %
        private void button1_Click(object sender, EventArgs e)
        {
            
           

        }



        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            //this.Hide();

        }
        private void button23_Click(object sender, EventArgs e)//,,,,,,,
        { if(! textBox1.Text.Contains(","))//если запись не содержит запитой,тогда пишем ее
                
            textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length - 1);//удаляем значение 
            if (textBox1.Text == "")//если остается пустое значение пишем 0
                textBox1.Text = "0";
        }
    }
    
}
