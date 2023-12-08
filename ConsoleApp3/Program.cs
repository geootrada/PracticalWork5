using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Ввведите ваше имя: ");
            name = Console.ReadLine();
            int age;
            Console.Write("Укажите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            string zodiacSign;
            Console.Write("Кто вы по знаку зодиака: ");
            zodiacSign = Console.ReadLine();
            string work;
            Console.Write("Где вы работаете: ");
            work = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, вам {age} год, вы {zodiacSign} и работаете {work}.");
        }
    }
}
