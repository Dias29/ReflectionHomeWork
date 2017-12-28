using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass clas = new MyClass(9, "C#", "Oleg Skidan");

            Type type = typeof(MyClass);

            var prop = type.GetProperties();

            foreach(var pr in prop)
            {
                Console.WriteLine(pr.Name +" - "+pr.GetValue(clas));
            }

            Console.ReadLine();
        }
    }
}
