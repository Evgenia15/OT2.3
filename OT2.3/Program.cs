using System;
using System.Linq;

namespace OT2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] films = { "Форрест Гамп", "Список Шиндлера", "Начало" };
            string[] series = { "Черное зеркало", "Чернобыль", "Клиника" };

            var result = films.Intersect(series); // Пересечение результатов

            Console.WriteLine("Персечение множеств");
            foreach (string a in result)
                Console.WriteLine(a);

            var result1 = films.Union(series); // Объединение результатов
            Console.WriteLine("Объединение множеств");
            foreach (string b in result1)
                Console.WriteLine(b);

            var result2 = films.Except(series); // Разность  результатов
            Console.WriteLine("Разность множеств");
            foreach (string s in result2)
                Console.WriteLine(s);
        }
    }
    
}
