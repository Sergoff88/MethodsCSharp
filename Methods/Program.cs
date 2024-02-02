namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            int age, numberOfAnimals;

            Console.WriteLine("Укажите Имя");

            firstName = Console.ReadLine();

            Console.WriteLine("Укажите Фамилию");

            lastName = Console.ReadLine();

            Console.WriteLine("Укажите возраст");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Есть ли питомцы");

            if (Console.ReadLine().ToUpper() == "Да".ToUpper())
            {
                Console.WriteLine("Укажите количество питомцев");
                string[] ArrNicknameAnimals = ArrayNicknameAnimals(Convert.ToInt32(Console.ReadLine()));
            }
            else
            {
                Console.WriteLine("Нет");
            }


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
    }

}

