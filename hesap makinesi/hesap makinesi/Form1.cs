using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;
        string işlem;
        double a, b, c;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                switch (işlem)
                {
                    case "+": b = Convert.ToDouble(textBox1.Text);
                        c = a + b;
                        textBox1.Text = c.ToString();
                        break;

                    case "-": b = Convert.ToDouble(textBox1.Text);
                        c = a - b;
                        textBox1.Text = c.ToString();
                        break;

                    case "*": b = Convert.ToDouble(textBox1.Text);
                        c = a * b;
                        textBox1.Text = c.ToString();
                        break;

                    case "/": b = Convert.ToDouble(textBox1.Text);
                        c = a / b;
                        textBox1.Text = c.ToString();
                        break;
                    case "^": b = Convert.ToDouble(textBox1.Text);
                        c = Math.Pow(a, b);
                        textBox1.Text = c.ToString();
                        break;
                    case "mod": b = Convert.ToDouble(textBox1.Text);
                        c = a % b;
                        textBox1.Text = c.ToString();
                        break;
                    case "%": b = Convert.ToDouble(textBox1.Text);
                        c = (a*b)/100;
                        textBox1.Text = c.ToString();
                        break;
                       
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    işlem = "-";
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    işlem = "*";
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    işlem = "+";
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    işlem = "/";
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    c = a * a;
                    textBox1.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }



        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    c = a * a * a;
                    textBox1.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    c = Math.Sqrt(a);
                    textBox1.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    işlem = "^";
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    c = 1 / a;
                    textBox1.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }


        }
        private long faktoriyelhesapla(long no)
        {

            long i;
            long fac = 1;

            for (i = no; i > 0; i--)
            {
                fac = fac * i;
            }

            return fac;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    long no = Convert.ToInt64(textBox1.Text);
                    if (no < 64)
                        no = faktoriyelhesapla(no);
                    else
                        MessageBox.Show("Faktoriyel hesaplanamadı", "İşlem Hatası");
                    textBox1.Text = no.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    c = Math.Sin(a);
                    textBox1.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    c = Math.Cos(a);
                    textBox1.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    c = Math.Cos(a);
                    textBox1.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    işlem = "%";
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    işlem = "mod";
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "hesap makinası";
            timer1.Enabled = true;
            timer1.Interval = 50;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            this.Text = " "+this.Text;
            if (sayac == 45)
            {
                this.Text = "hesap makinesi";
                sayac = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                 
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    c = Math.Log10(a);
                    textBox1.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası");
            }

        }

    }
}
    


        
        
        
        
         
            
        
        
        
        
    


       
        
        
    

