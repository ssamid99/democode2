using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_
{
    class Class2
    {
        public string Name;
        public string Catagory;
        public int Area;
        public int NumberOfRooms;
        public int Price;

        public static object array { get; private set; }

        /* public void GetInfo()
         {
             Console.WriteLine($"{Name}\n" +
                 $"{Catagory}\n" +
                 $"{Area}\n" +
                 $"{NumberOfRooms}\n" +
                 $"{Price}");





         }*/
        public static string GetTwo(int x, int y, Class2[] array) => $"{array[x].Name} {array[x].Catagory} {array[x].Area} {array[x].NumberOfRooms} {array[x].Price}";










    }
}
