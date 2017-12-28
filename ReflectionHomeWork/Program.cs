using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Console);
            int count = 1;

            var methods = type.GetMethods();
            int length = type.GetMethods().Length;
            Console.WriteLine("Methods of Console class:");

            foreach (var method in methods)
            {
                Console.SetCursorPosition(10, count++);
                Console.WriteLine("Mетод: {0}", method.Name);
            }    
            
            Console.ReadLine();
            Console.Clear();
        }
    }
}
