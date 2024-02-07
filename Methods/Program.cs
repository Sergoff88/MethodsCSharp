using System;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Спрашиваем у пользователя данные
            var tuple = GetTuple();

            ShowTuple(tuple);

        }
        static string[] ArrayNicknameAnimals(int numberOfAnimals)
        {
            string[] array = new string[numberOfAnimals];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Укажите имя {0}-ого питомца", i + 1);
                array[i] = Console.ReadLine();
            }
            return array;

        }

        static string[] FavoriteColors(int numberOfColors)
        {
            string[] array = new string[numberOfColors];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Укажите имя {0}-ого питомца", i + 1);
                array[i] = Console.ReadLine();

            }
            return array;

        }

        static string[] GetArrayFromConsole(int numberOfColors, string whatToAsk)
        {
            string[] array = new string[numberOfColors];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(whatToAsk, i + 1);
                array[i] = Console.ReadLine();

            }
            return array;

        }

        static int CheckNumber(string number)
        {
            bool check = int.TryParse(number, out int result);
            if (check == false || result <= 0)
            {
                Console.WriteLine("Это не похоже на число, которое больше 0. повторите ввод данных снова");
                result = CheckNumber(Console.ReadLine());
            }
            return result;
        }
        static void ShowTuple((string, string, int, int, int, string[], string[]) tuple)
        {
            Console.WriteLine("Имя: {0}", tuple.Item1);
            Console.WriteLine("фамилия: {0}", tuple.Item2);
            Console.WriteLine("возраст: {0}", tuple.Item3);
            Console.WriteLine("Количество питомцев: {0}", tuple.Item4);
            Console.WriteLine("их клички:");
            foreach (var p in tuple.Item6)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Количество любимых цветов: {0}", tuple.Item5);
            foreach (var p in tuple.Item7)
            {
                Console.WriteLine(p);
            }
        }

        static (string, string, int, int, int, string[], string[]) GetTuple()
        {
            (string firstName, string lastName, int age, int numberOfAnimals, int numberOfColors, string[] arrNicknameAnimals, string[] arrFavoriteColors) data;

            //Имя
            Console.WriteLine("Укажите Имя");
            data.firstName = Console.ReadLine();

            //Фамилия
            Console.WriteLine("Укажите Фамилию");
            data.lastName = Console.ReadLine();

            //Возраст 
            Console.WriteLine("Укажите возраст");
            data.age = CheckNumber(Console.ReadLine());

            //Питомцы
            Console.WriteLine("Есть ли питомцы. Ответ да/нет");
            if (Console.ReadLine().ToUpper() == "Да".ToUpper())
            {
                Console.WriteLine("Укажите количество питомцев");
                data.numberOfAnimals = Convert.ToInt32(CheckNumber(Console.ReadLine()));
                data.arrNicknameAnimals = GetArrayFromConsole(data.numberOfAnimals, "Укажите имя {0}-ого питомца");
            }
            else
            {
                data.numberOfAnimals = 0;
                data.arrNicknameAnimals = new string[0];
            }

            //Цвета
            Console.WriteLine("Сколько у вас любимых цветов?");
            data.numberOfColors = Convert.ToInt32(CheckNumber(Console.ReadLine()));
            data.arrFavoriteColors = GetArrayFromConsole(data.numberOfColors, "Укажите {0}-й любимый цвет");

            return (data.firstName, data.lastName, data.age, data.numberOfAnimals, data.numberOfColors, data.arrNicknameAnimals, data.arrFavoriteColors);
        }



    }
}   // ВОПРОСЫ!
    // Как лучше поступать при передачи аргументов в методы? 
    // Сначала их загонять в переменные, или же лучше, при возможности, использовать метод, который возвратит этот аргумент?
    // А если для получения аргумента необходимо будет несколько вложенных методов?
    // Как правильнее?


