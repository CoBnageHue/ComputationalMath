using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chislMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double Function(double x)
        {
            return (1 / Math.Pow(x, 2)) * Math.Sin(1 / x);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            double eps = .0;
            try
            {
                eps = double.Parse(acuValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Нужно запятую, eps = 0,01");
                eps = 0.01;
            }
            
            double start = 1;
            double end = 2.5;
            Trap(eps, start, end);
            Simp(eps, start, end);
            Newton(eps, start, end);


        }

        private void Newton(double eps, double start, double end)
        {
            double n = 3;
            double h = (end - start) / n;
            int count_h = 0;
            double R, I_h, I_h2;
            Stopwatch time = new();
            time.Start();
            while (true)
            {
                I_h = .0;
                I_h2 = .0;
                for (double i = start; i < end; i += 3 * h)
                {
                    I_h += 3 * h * (Function(i) / 8.0 + 0.375 * (Function(i + h) + Function(i + 2 * h)) + Function(i + 3 * h) / 8.0);
                }
                for (double i = start; i < end; i += 3 * h)
                {
                    I_h2 += 1.5 * h * (Function(i) / 8.0 + 0.375 * (Function(i + 0.5 * h) + Function(i + h)) + Function(i + 1.5 * h) / 8.0) +
                            1.5 * h * (Function(i + 1.5 * h) / 8.0 + 0.375 * (Function(i + 2 * h) + Function(i + 2.5 * h)) + Function(i + 3 * h) / 8.0);
                }

                R = Math.Abs((I_h2 - I_h) / 15);

                if (R > eps)
                {
                    count_h++;
                    h /= 2.0;
                }
                else
                    break;
            }
            time.Stop();
            ansNew.Text = I_h2.ToString();
            timeNew.Text = time.Elapsed.TotalMilliseconds.ToString() + " МС";
            acuNew.Text = R.ToString();
            razbNew.Text = count_h.ToString();
        }

        private void Trap(double eps, double start, double end)
        {
            double n = 2;
            double h = (end - start) / n;
            int count_h = 0;
            double R, I_h, I_h2;
            Stopwatch time = new();
            time.Start();
            while (true)
            {
                I_h = .0;
                I_h2 = .0;
                for (double i = start + h; i < end + h / 2; i += h) {
                    I_h += h * (Function(i - h) + Function(i)) / 2;
                }
                for (double i = start + h; i < end + h / 2; i += h) {
                    I_h2 += h * (Function(i - h) + Function(i - (h / 2))) / 4 + h * (Function(i - (h / 2)) + Function(i)) / 4;
                }
                R = Math.Abs((I_h2 - I_h) / 3);

                if (R > eps){
                    count_h++;
                    h /= 2.0;
                }
                else
                    break;

            }
            time.Stop();

            timeTrap.Text = time.Elapsed.TotalMilliseconds.ToString() + " МС";
            razbTrap.Text = count_h.ToString();
            acuTrap.Text = R.ToString();
            ansTrap.Text = I_h2.ToString();
        }

        private void Simp(double eps, double start, double end)
        {
            double n = 2;
            double h = (end - start) / n;
            int count_h = 0;
            double R, I_h, I_h2;
            Stopwatch time = new();
            time.Start();
            while (true)
            {
                I_h = .0;
                I_h2 = .0;
                for (double i = start + 2 * h; i < end + h / 2; i += 2 * h){
                    I_h += h * 2 * ((1.0 / 6.0) * Function(i - 2 * h) + 2.0 / 3.0 * Function(i - h) + (1.0 / 6.0) * Function(i));
                    
                }
                for (double i = start + 2 * h; i < end + h / 2; i += 2 * h){
                    I_h2 += h * ((1.0 / 6.0) * Function(i - 2 * h) + 2.0 / 3.0 * Function(i - 1.5 * h) + (1.0 / 6.0) * Function(i - h)) +
                            h * ((1.0 / 6.0) * Function(i - h) + 2.0 / 3.0 * Function(i - h / 2.0) + (1.0 / 6.0) * Function(i));
                }

                R = Math.Abs((I_h2 - I_h) / 15);

                if (R > eps) {
                    count_h++;
                    h /= 2.0;
                }
                else
                    break;
            }
            time.Stop();

            timeSimp.Text = time.Elapsed.TotalMilliseconds.ToString() + " МС";
            razbSimp.Text = count_h.ToString();
            acuSimp.Text = R.ToString();
            ansSimp.Text = I_h2.ToString();
        }
    }
}
