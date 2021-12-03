using SingletonPattern.Classes;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance = Singleton.GetInstance();
            Console.WriteLine(instance.Data);

            Singleton secondInstance = Singleton.GetInstance();
            secondInstance.Data = "new data";

            Console.WriteLine(secondInstance.Data);
            Console.WriteLine(instance.Data);
        }
    }
}
