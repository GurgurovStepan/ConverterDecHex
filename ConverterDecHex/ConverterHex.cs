using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterDecHex
{
    class ConverterHex
    {
        private List<byte> numbersHex = new List<byte> { };
        private List<char> numbersHexCh = new List<char> { };

        /// <summary>
        /// Перевод целого положительного числа в 16-ую систему исчисления 
        /// </summary>
        /// <param name="number">введенное число</param>
        /// <returns>разряды 16-ого числа</returns>
        private List<byte> Translate(UInt32 number)
        {
            numbersHex.Clear();

            while (number > 16)
            {
                var temp = (byte)(number % 16);
                numbersHex.Add(temp);
                number /= 16;
                if (number < 16) numbersHex.Add((byte)number);
            }

            numbersHex.Reverse();
            return numbersHex;
        }

        /// <summary>
        /// Перевод разрядов 16-го числа в 16-у форму отображение 
        /// </summary>
        /// <param name="Lb"></param>
        /// <returns></returns>
        private List<char> Translate(List<byte> Lb)
        {
            foreach (var item in Lb)
            {
                if (item >= 0 && item <= 9)
                {
                    numbersHexCh.Add(Convert.ToChar(item + 48));
                }
                else
                {
                    numbersHexCh.Add(Convert.ToChar(item + 55));
                }
            }

            return numbersHexCh;
        }
    }
}
