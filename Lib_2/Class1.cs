using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_2
{
    public class Class1
    {
        //Входной параметр К
        //Выходной параметр сумма < К, случайные числа, кол-во чисел

        /// <summary>
        /// Генерирует случайные числа, находит количество и сумму, не превышающую задаваемого параметра
        /// </summary>
        /// <param name="limitNumber">Предел суммы</param>
        /// <param name="razn">Сумма случайных чисел, не превышающая задаваемого параметра</param>
        /// <returns>Список случайных чисел</returns>
        public List<int> CalculateTask(int limitNumber, out int razn)
        {
            List<int> randomNumbers = new List<int>();
            Random rnd = new Random();
            razn = 0;

            for (int i = 0; ; i++)
            {
                randomNumbers.Add(rnd.Next(2, 10));
                razn -= randomNumbers[i];

                if (razn <= limitNumber)
                {
                    razn += randomNumbers[i];
                    randomNumbers.RemoveAt(i);
                    break;
                }
            }

            return randomNumbers;
        }
    }
}