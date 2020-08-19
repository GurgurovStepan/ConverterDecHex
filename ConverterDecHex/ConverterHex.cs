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
            }
            
            if (number < 16) numbersHex.Add((byte)number);
            
            numbersHex.Reverse();
            return numbersHex;
        }

        /// <summary>
        /// Перевод разрядов 16-го числа в 16-у форму отображение 
        /// </summary>
        /// <param name="Lb"></param>
        /// <returns></returns>
        private List<char> Translate(List<byte> lb)
        {
            numbersHexCh.Clear();

            foreach (var item in lb)
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
    
        /// <summary>
        /// Переводит строку в число (целое)
        /// </summary>
        /// <param name="number">Введенная строка</param>
        /// <returns>Числовое значение строки</returns>
        private UInt32 ConversionString(string number)
        {
            UInt32 temp = 0;
            try
            {
                temp = Convert.ToUInt32(number);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of the Int32 type.", number);
            }
            catch (FormatException) 
            {
                Console.WriteLine("The {0} value '{1}' is not in a recognizable format.", number.GetType().Name, number);
            }
            return temp;
        }  

        public string TranslateData(string data)
        {
            var number = ConversionString(data);
            var lb = Translate(number);
            string result = "";
            foreach (var item in lb)
	        {
                result+=item.ToString();
        	} 
            return result;
        }

        public string TranslateDataCodeANSII(string data)
        {
            var lc = Translate(Translate(ConversionString(data)));

            string result = "";
            foreach (var item in lc)
            {
                result += item.ToString();
            }
            return result;
        }
    }
}
