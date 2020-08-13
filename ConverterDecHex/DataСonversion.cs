using System;
using System.Collections.Generic;
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

        #endregion
    }
}
