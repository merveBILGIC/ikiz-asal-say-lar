using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İKİZ_ASAL_SAYILAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int kontrol = 1;
       public  int  asal (int nesne)
        {
            
            switch (nesne)
            {
                case int a when a<=0:
                    {
                        MessageBox.Show("pozitif ve sıfırdan büyük bir sayı girin!!!");
                        kontrol = 0;
                        break;
                    }
                case int b when b == 2:
                    {
                        kontrol = 1;
                        break;
                    }
                case int c when c <= 2:
                    {
                        for(int i=2;i<c/2;i++)
                        {
                            if (c % i == 0)
                                kontrol = 0;
                            else
                                kontrol = 1;
                        }
                        break;
                    }
                    
            }

            return kontrol;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int nesne;
            int sayı1, sayı2;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            if(sayı1<sayı2)
            {
                MessageBox.Show("sayı1 sayı2 den büyük olmalıdır!!!");
            }
            asal(sayı1);
            asal(sayı2);
            nesne = kontrol;
            if (nesne == 0) 
            {
                MessageBox.Show("sayılar asal degildir ikizlikleri kontrol edilemez!!!!");
             
            }
            if(nesne==1)
            {
                if (sayı1 - sayı2 == 2)
                {
                    MessageBox.Show("sayılar ikiz asal sayılardır");
                }
                else
                    MessageBox.Show("sayılar ikiz asal sayı değildir!!!");
            }
        }
    }
}
