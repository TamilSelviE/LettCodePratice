using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CityMapTamil
    {
        public static void Get_City_Map_Solution()
        {

            var T = new int[] { 9, 1, 4, 9, 0, 4, 8, 9, 0, 1 };
            var city_count = T.Length;
            int cityCapital;
            var cityMap = GetCityMap(T, out cityCapital);


            var result = new int[city_count - 1];

            

            result = UpdateCityCount(cityMap, cityCapital, result);

            
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }

        private static Dictionary<int, List<int>> GetCityMap(int[] T, out int capitalIndex)
        {
            var cityMap = new Dictionary<int, List<int>>();
            capitalIndex = -1;
            
            for (int i = 0; i < T.Length; i++)
            {
                if (!cityMap.ContainsKey(T[i]))
                    cityMap[T[i]] = new List<int>() { i };
                else
                    cityMap[T[i]].Add(i);

                if (T[i] == i)
                    capitalIndex = T[i];
            }
            return cityMap;
        }

        private static int[] UpdateCityCount(Dictionary<int, List<int>> cityMap, int startIndex, int[] result, int counterIndex = 1)
        {
            //t={9:[0,3,7],8:[6], 1:[9,1],0:[4,8],4:[2,5]}
            //[1,3,2,3,0,0,0,0,0]
            var cities = cityMap[startIndex];
            foreach(var city in cities)
            {
                if (startIndex == city)
                    result[0] = result[0] + 1;
                else
                    if(cityMap.ContainsKey(city))
                {
                    result[counterIndex] = 0; 
                }
            }
            
            return result;
        }
    }
}
