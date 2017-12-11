using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Epam_Oper2DArray
{
    /// <summary>
    /// Static class for operations with 2D arrays
    /// </summary>
    static class Oper2DArray 
    {
        /// <summary>
        /// Method adds two arrays
        /// </summary>
        /// <param name="arr1">first array</param>
        /// <param name="arr2">second array</param>
        /// <returns></returns>
        public static double[,] AddArray(double [,] arr1, double [,] arr2)
        {
            try
            {
                if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1))
                {
                    double[,] arr = new double[arr1.GetLength(0), arr1.GetLength(1)];
                    for (int i = 0; i < arr1.GetLength(0); i++)
                        for (int j = 0; j < arr1.GetLength(1); j++)
                        {
                            arr[i, j] = arr1[i, j] + arr2[i, j];
                        }
                    return arr;
                }
                throw new Array2DException("AddArray says: Arrays have different dimentions!");
            }
            catch (Array2DException)
            {
                return null;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error in method AddArray()! Hasn`t passed array or peremeter to Display");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Method substracts two arrays
        /// </summary>
        /// <param name="arr1">first array</param>
        /// <param name="arr2">second array</param>
        /// <returns></returns>
        public static double[,] SubstrArray(double[,] arr1, double[,] arr2)
        {
            try
            {
                if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1))
                {
                    double[,] arr = new double[arr1.GetLength(0), arr1.GetLength(1)];
                    for (int i = 0; i < arr1.GetLength(0); i++)
                        for (int j = 0; j < arr1.GetLength(0); j++)
                        {
                            arr[i, j] = arr1[i, j] - arr2[i, j];
                        }
                    return arr;
                }
                throw new Array2DException("SubstrArray says: Arrays have different dimentions!");
            }
            catch (Array2DException)
            {
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Method multiplies two arrays
        /// </summary>
        /// <param name="arr1">first array</param>
        /// <param name="arr2">second array</param>
        /// <returns></returns>
        public static double[,] MultArray(double[,] arr1, double[,] arr2)
        {
            try
            {
                if (arr1.GetLength(1) == arr2.GetLength(0))
                {
                    double[,] arr = new double[arr1.GetLength(0), arr2.GetLength(1)];
                    for (int i = 0; i < arr1.GetLength(0); i++)
                        for (int j = 0; j < arr2.GetLength(1); j++)
                        {
                            arr[i, j] = 0;
                            for (int k = 0; k < arr1.GetLength(1); k++)
                                arr[i, j] += arr1[i, k] * arr2[k, j];
                        }
                    return arr;
                }
                throw new Array2DException("MultArray says: Arrays have not allowed dimentions!");
            }
            catch (Array2DException)
            {
                return null;
            }
        }
        /// <summary>
        /// Method multiplies array by number
        /// </summary>
        /// <param name="arr1">array</param>
        /// <param name="a">number</param>
        /// <returns></returns>
        public static double[,] MultNumArray(double[,] arr1, double a)
        {
            try
            {
                double[,] arr = new double[arr1.GetLength(0), arr1.GetLength(1)];
                for (int i = 0; i < arr1.GetLength(0); i++)
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        arr[i, j] = arr1[i, j] * a;
                    }
                return arr;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error in method MultNumArray()! Hasn`t passed array or peremeter to Display");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Method transponants array
        /// </summary>
        /// <param name="arr">array</param>
        /// <returns></returns>
        public static double [,] TranspArray(double[,] arr)
        {
            try
            {
                double[,] arrNew = new double[arr.GetLength(1), arr.GetLength(0)];
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arrNew[j, i] = arr[i, j];
                    }
                return arrNew;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error in method TranspArray()! Hasn`t passed any array to transponent");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Method returns subarray from passed one
        /// start and end index positions passed as parameters
        /// </summary>
        /// <param name="arr">array</param>
        /// <param name="n">first length subarray</param>
        /// <param name="m">second length subarray</param>
        /// <param name="startN">first start position</param>
        /// <param name="startM">second start position</param>
        /// <returns></returns>
        public static double[,] GetSubArray(double[,] arr, int n, int m, int startN = 0, int startM = 0)
        {
            try
            {
                if (arr.GetLength(0) < (n + startN) || arr.GetLength(1) < (m + startM) || (n + startN) < 0 || (m + startM) < 0 || n <= 0 || m <= 0) 
                {
                    throw new Array2DException("Method GetSubArray: array parameters have not allowed value!");
                }
                double[,] arrNew = new double[n, m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        arrNew[i, j] = arr[i + startN, j + startM];
                    }
                return arrNew;
            }
            catch (Array2DException)
            {
                return null;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error in metho GetSubArray()! Hasn`t passed array or parameters");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }      
        }
        /// <summary>
        /// Method compares two arrays
        /// </summary>
        /// <param name="arr1">array</param>
        /// <param name="arr2">array</param>
        /// <returns></returns>
        public static bool isEqual2DArray (double[,] arr1, double[,] arr2)
        {
            try
            {
                if (arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1))
                    return false;
                for (int i = 0; i < arr1.GetLength(0); i++)
                    for (int j = 0; j < arr1.GetLength(0); j++)
                    {
                        if (arr1[i, j] != arr2[i, j])
                            return false;
                    }
                return true;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error in method isEqual2DArray()! Hasn`t passed array");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Method displays array
        /// </summary>
        /// <param name="arr">array</param>
        public static void Display (double [,] arr)
        {
            try
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", arr[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error in metho Display()! Hasn`t passed any array to Display");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Method converts array to string
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string ToString(double[,] arr)
        {
            try
            {
                string str = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                str += "\n";
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    str += arr[i, j]+"\t";
                }
            }
            return str;           
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error in method ToString()! Hasn`t passed any array");
                return "Oops\n";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Oops\n";
            }
        }
    }
}
