using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nP, nB, nPih, awrSpeed, awrGold, awrMeat, awrFeed, awrWine;
            double a = 100;
          
            //Palad paladin;
           // Beer bear;
           // Pihota pihota;

            try
            {
                nP = Convert.ToInt32(textBox4.Text);
                nB = Convert.ToInt32(textBox5.Text);
                nPih = Convert.ToInt32(textBox6.Text);

                var paladin = new Palad(nP);
                var bear = new Beer(nB);
                var pihota = new Pihota(nPih);

                awrSpeed = paladin.SpeedPerDay();
               if (awrSpeed > bear.SpeedPerDay())
                    awrSpeed = bear.SpeedPerDay();
                if (awrSpeed > pihota.SpeedPerDay())
                    awrSpeed = pihota.SpeedPerDay();
                awrSpeed *= 24;

                Lsp.Text = awrSpeed.ToString();

                
                Lg.Text =(paladin.GoldPerDay() + pihota.GoldPerDay()).ToString();
                Lm.Text = bear.MeatPerDay().ToString();
                Lf.Text = paladin.FeedPerDay().ToString();
                Lw.Text = (paladin.WinePerDay() + pihota.WinePerDay()).ToString();

            }

            catch
            {
                MessageBox.Show("Помилкові дані");
            };

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
