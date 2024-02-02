namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            int age, numberOfAnimals, numberOfColors;
            //Имя
            Console.WriteLine("Укажите Имя");
            firstName = Console.ReadLine();
            //Фамилия
            Console.WriteLine("Укажите Фамилию");
            lastName = Console.ReadLine();
            //Возраст
            Console.WriteLine("Укажите возраст");
            age = Convert.ToInt32(Console.ReadLine());
            //Питомцы
            Console.WriteLine("Есть ли питомцы");
            if (Console.ReadLine().ToUpper() == "Да".ToUpper())
            {
                Console.WriteLine("Укажите количество питомцев");
                string[] ArrNicknameAnimals = GetArrayFromConsole(Convert.ToInt32(Console.ReadLine()), "Укажите имя {0}-ого питомца");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            //Цвета
            Console.WriteLine("Сколько у вас любимых цветов?");
            numberOfColors = Convert.ToInt32(Console.ReadLine());
            string[] arrFavoriteColors = GetArrayFromConsole(numberOfColors, "Укажите {0}-й любимый цвет");

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

    }

}

