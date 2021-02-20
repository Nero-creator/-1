using Lib_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Вычислить разницу целых случайных чисел," +
                " распределенных в диапазоне от 2 до 10, пока эта разница не станет меньше некоторого числа K" +
                " (K<0). Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел." +
                "Князев Максим");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 instance = new Class1();
            int limitNumber = int.Parse(tb_CUM.Text);
            List<int> numbers = instance.CalculateTask(limitNumber, out int razn);
            if (limitNumber < 0)
            {
                tb_summ.Text = razn.ToString();
                tb_Chislo.Clear();
                foreach (int number in numbers)
                {
                    tb_Chislo.Text += number.ToString() + " ";
                }
                tb_Kol_vo.Text = numbers.Count.ToString();
            }
            else MessageBox.Show("Введено неверное значение");
        }
    }
        //  сгенирируем
        // выведем через пробел
        // суммируем новое число с всеми числами.
        // нарастаем количество этих чисел
    
}

