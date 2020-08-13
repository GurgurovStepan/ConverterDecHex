using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterDecHex
{
    class DataСonversion
    {
        #region Fields
        private string dataInput;
        private string dataConvertible;
        #endregion

        #region Properties
        /// <summary>
        /// Входные данные
        /// </summary>
        public string DataInput
        {
            set
            {
                if (value == null || value.Length > 10) 
                    Console.WriteLine("Error! DataInput length exceeds 10 characters or NULL.");
                else 
                    dataInput = value;
            }
        }
        /// <summary>
        ///  Преобразованные данные
        /// </summary>>
        public string DataConvertible
        {
            get
            {
                return dataConvertible;
            }
        }
        #endregion

        #region Constructors
        public DataСonversion() {}
        public DataСonversion(string dI) : this(dI, "") {} 
        public DataСonversion(string dI, string dC)
        {
            DataInput = dI;
            dataConvertible = dC;
        }
        #endregion
    }
}
