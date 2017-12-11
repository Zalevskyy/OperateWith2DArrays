using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Oper2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] array1 = new double[,] { { 1, 2, 3 }, { 2, -1, 2 } };
            double[,] array11 = new double[,] { { 3, 3, 3 }, { -1, 2, -4 } };
            double[,] array2 = new double[,] { { 3, 2, 1 }, { 1, 3, -2 }, { 2, 4, 2 } };
            #region Transponante
            Console.WriteLine("Array:");
            Oper2DArray.Display(array1);
            Console.WriteLine("transponanted array:");
            double[,] array3 = Oper2DArray.TranspArray(array1);
            Oper2DArray.Display(array3);
            Console.WriteLine();
            #endregion
            #region Addition
            Console.WriteLine("Addition arrays: {0} \n+ {1}", Oper2DArray.ToString(array1), Oper2DArray.ToString(array11));
            array3 = Oper2DArray.AddArray(array1, array11);
            Console.WriteLine("= {0}", Oper2DArray.ToString(array3));
            Console.WriteLine();
            #endregion
            #region Substraction
            Console.WriteLine("Substraction arrays:{0}\n- {1} \n= {2}", Oper2DArray.ToString(array1), Oper2DArray.ToString(array3), Oper2DArray.ToString(Oper2DArray.SubstrArray(array1, array3)));
            Console.WriteLine();
            #endregion
            #region Multiply
            Console.WriteLine("Multiplication arrays:{0}\n* {1} \n= {2}", Oper2DArray.ToString(array1), Oper2DArray.ToString(array2), Oper2DArray.ToString(Oper2DArray.MultArray(array1, array2)));
            Console.WriteLine();
            #endregion
            #region Multiply with exception
            Console.WriteLine("Multiplication arrays:{0}\n* {1} \n= {2}", Oper2DArray.ToString(array1), Oper2DArray.ToString(array11), Oper2DArray.ToString(Oper2DArray.MultArray(array1, array11)));
            Console.WriteLine();
            #endregion
            #region SubArray
            double[,] array4;
            int n = 2;
            int m = 2;
            int startN = 1;
            int startM = 1;
            array3 = Oper2DArray.GetSubArray(array2, n, m);
            Console.WriteLine("Sub array is made from {0}\nand has dimention [{1},{2}]: {3}\n", Oper2DArray.ToString(array2), n, m, Oper2DArray.ToString(array3));
            #endregion
            #region SubArray with start position
            array4 = Oper2DArray.GetSubArray(array2, n, m, startN,startM);
            Console.WriteLine("Subs array is made from {0}\n start with position [{1},{2}] and has dimention [{3},{4}]: {5}\n", Oper2DArray.ToString(array2),startN, startM, n, m, Oper2DArray.ToString(array4));
            Console.WriteLine();
            #endregion
            #region Multiply array by number
            Console.WriteLine("Multiplying array {0} \nby {1} is:  {2}", Oper2DArray.ToString(array1), n, Oper2DArray.ToString(Oper2DArray.MultNumArray(array1, n)));
            #endregion
        }
    }
}
