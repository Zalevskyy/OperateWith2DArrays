using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam_Log_library;

namespace Epam_Oper2DArray
{
    /// <summary>
    /// Customer Ecxeption  to operations with 2DArrays
    /// for wrong arrays dimention or parameters
    /// </summary>
    class Array2DException: ApplicationException
    {
        public ILogger loger;
        public Array2DException (string msg):base(msg)
        {
            loger = LoggerChoise.GetLogger(ConfigFromFile.GetFormatLogger());
            loger.Log("Error! Wrong operation parameter! " + base.Message,levels.error,this);
            Console.WriteLine("Error! Wrong operation parameter! " + base.Message);
        }
    }
}
