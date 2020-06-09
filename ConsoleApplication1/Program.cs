using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Circular Rotation
            //int[] myArr = new int[] { 1, 2, 3, 4 };
            //Console.WriteLine("Circular Rotation: ");
            //PrintArray(CircularRotation(myArr));
            #endregion

            //#region Find Missing Number within Range 0-100000
            //int[] myArr = new int[] { 0, 2, 3, 4, 6, -1, 2 };
            //Console.WriteLine("Smallest missing number :" + MissingNum(myArr));

            //#endregion


            #region CityMap
            // CityMap.Get_City_Map_Solution();
            //CityMapTamil.Get_City_Map_Solution();
            Permutation.GetPermutation();
            #endregion
            Console.ReadKey();


        }

        private static int MissingNum(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            
            var range = Enumerable.Range(0, 100000);
            var result = range.Except(A).Where(x => x > 0).Distinct().OrderBy(x => x).FirstOrDefault();

            return result;
        }

        private static int[] CircularRotation(int[] myArr)
        {
            int[] result = new int[myArr.Length];
            int arrCount = myArr.Length;
            foreach (int a in myArr)
            {
                result[arrCount] = a;
                arrCount--;
            }
            return result;
        }

        private static void PrintArray(int[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.Write( i);
            }
        }
    }
}
