using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class CityMap
    {

        public static void Get_City_Map_Solution()
        {
 
            var T = new int[] { 9, 1, 4, 9, 0, 4, 8, 9, 0, 1 };
            var city_count = T.Length;

            var city_map = Get_City_Map(T);
            var capital = Get_Capital_City_Index(city_map);
            var counters = new int[city_count - 1];

            

            var result = Update_city_Count(city_map, capital, counters);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }

        private static Dictionary<int, List<int>> Get_City_Map(int[] t)
        {
            var city_map = new Dictionary<int, List<int>>();

            for (int city = 0; city < t.Length; city++)
            {
                if (!city_map.Keys.Contains(t[city]))
                {
                    city_map[t[city]] = new List<int>() { city };
                }
                else
                {

                    city_map[t[city]].Add(city);
                }
            }

            return city_map;
        }

        /// <summary>
        /// Update city count
        /// </summary>
        /// <param name="city_map"></param>
        /// <param name="start_city"></param>
        /// <param name="counters"></param>
        /// <param name="counter_index"></param>
        /// <returns></returns>
        private static int[] Update_city_Count(Dictionary<int, List<int>> city_map, int start_city, int[] counters, int counter_index = 1)
        {
            var cities = city_map[start_city];
            //t={9:[0,3,7],8:[6], 1:[9,1],0:[4,8],4:[2,5]}
            foreach (var city in cities)
            {

                if (start_city == city)
                {
                    counters[0] = counters[0] + 1;
                }
                else
                {
                    if (city_map.Keys.Contains(city))
                    {
                        var connected_cities = city_map[start_city];

                        counters[counter_index] = get_connected_city_count(city_map, start_city, connected_cities);

                        Update_city_Count(city_map, city, counters, counter_index + 1);
                    }

                }
            }

            return counters;
        }

        // Get connected city Count
        private static int get_connected_city_count(Dictionary<int, List<int>> city_map, int city, List<int> connected_cities)
        {
            var city_count = 0;

            foreach (var connected_city in connected_cities)
            {
                if (city_map.Keys.Contains(connected_city) & connected_city != city)
                    city_count = city_count + city_map[connected_city].Count;
            }
            return city_count;
        }


        /// <summary>
        /// Get the capital city index
        /// </summary>
        /// <param name="city_map"></param>
        /// <returns></returns>
        private static int Get_Capital_City_Index(Dictionary<int, List<int>> city_map)
        {
            foreach (var key in city_map.Keys)
            {
                foreach (var city in city_map[key])
                {
                    if (city == key)
                        return city;
                }
            }
            return 0;
        }





    }

}

    

