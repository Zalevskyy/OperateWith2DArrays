using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Oper2DArray
{
    /// <summary>
    /// Customer Ecxeption  to operations with 2DArrays
    /// for wrong arrays dimention or parameters
    /// </summary>
    class Array2DException: ApplicationException
    {
        public Array2DException (string msg):base(msg)
        {
            Console.WriteLine("Error! Wrong operation parameter! " + base.Message);
        }
    }
}
