using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Bloom MyBloom = new Bloom();
            string data = "Hello Bloom Filter";
            MyBloom.AddData(data);

            string data2 = "Hello Bloom Filter";
            Console.WriteLine(MyBloom.LookUp(data2).ToString());
            Console.ReadLine();
        }
    }
}
