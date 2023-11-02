using Pet_Shop.Classes;
using Pet_Shop.Classes.Factory;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        animals.Add(CatFactory.Create("Cat","Кошка", "Мурка", 3));
        animals.Add(DogFactory.Create("Dog", "Собака", "Бобик", 4));
        animals.Add(HamsterFactory.Create("Hamster", "Хомяк", "Хома", 1));
        animals.Add(ParrotFactory.Create("Parrot", "Попугай", "Кеша", 6));
        animals.Add(KerpeFactory.Create("Rabbit", "Ежик", "Керпе", 5));

        Console.WriteLine("Список питомцев:");
        foreach (var animal in animals)
        {
            Console.WriteLine($"Это: {animal.Model}, Имя: {animal.Name}, Возраст: {animal.Age} мес");
            animal.Sound();
            Console.WriteLine();
        }

        while (true)
        {
            Console.Write("Выберите действие (1 - сортировать, 2 - купить): ");
            int action = Convert.ToInt32(Console.ReadLine());

            if (action == 1)
            {
                while (true)
                {
                    Console.Write("Выберите сортировку (1 - по типу, 2 - по имени, 3 - по возрасту, 4 - выйти из сортировки): ");
                    int srt = Convert.ToInt32(Console.ReadLine());

                    if (srt == 1)
                    {
                        for (int i = 0; i < animals.Count - 1; i++)
                        {
                            for (int j = 0; j < animals.Count - 1; j++)
                            {
                                if (string.Compare(animals[j].Model, animals[j + 1].Model) > 0)
                                {
                                    var temp = animals[j];
                                    animals[j] = animals[j + 1];
                                    animals[j + 1] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Отсортированный список питомцев по типу:");
                        foreach (var animal in animals)
                        {
                            Console.WriteLine($"Это: {animal.Model}, Имя: {animal.Name}, Возраст: {animal.Age}");
                        }
                    }
                    else
                    {
                        if (srt == 2)
                        {
                            for (int i = 0; i < animals.Count - 1; i++)
                            {
                                for (int j = 0; j < animals.Count - 1; j++)
                                {
                                    if (string.Compare(animals[j].Name, animals[j + 1].Name) > 0)
                                    {
                                        var temp = animals[j];
                                        animals[j] = animals[j + 1];
                                        animals[j + 1] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("Отсортированный список питомцев по имени:");
                            foreach (var animal in animals)
                            {
                                Console.WriteLine($"Это: {animal.Model}, Имя: {animal.Name}, Возраст: {animal.Age}");
                            }
                        }
                        else
                        {
                            if (srt == 3)
                            {
                                for (int i = 0; i < animals.Count - 1; i++)
                                {
                                    for (int j = 0; j < animals.Count - 1; j++)
                                    {
                                        if (animals[j].Age > animals[j + 1].Age)
                                        {
                                            var temp = animals[j];
                                            animals[j] = animals[j + 1];
                                            animals[j + 1] = temp;
                                        }
                                    }
                                }
                                Console.WriteLine("Отсортированный список питомцев по возрасту:");
                                foreach (var animal in animals)
                                {
                                    Console.WriteLine($"Это: {animal.Model}, Имя: {animal.Name}, Возраст: {animal.Age}");
                                }
                            }
                            else
                            {
                                if (srt == 4)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            
            }    
            else
            {
                if (action == 2)
                {
                    Console.Write("Выберите питомца (1 - кошка, 2 - собака, 3 - хомяк, 4 - попугай, 5 - ежик): ");
                    int buy = Convert.ToInt32(Console.ReadLine());
                    if (buy == 1)
                    {
                        Console.WriteLine("Поздравляем! Теперь Мурка ваш новый питомец!");
                        break;
                    }
                    else
                    {
                        if (buy == 2)
                        {
                            Console.WriteLine("Поздравляем! Теперь Бобик ваш новый питомец!");
                            break;
                        }
                        else
                        {
                            if (buy == 3)
                            {
                                Console.WriteLine("Поздравляем! Теперь Хома ваш новый питомец!");
                                break;
                            }
                            else
                            {
                                if (buy == 4)
                                {
                                    Console.WriteLine("Поздравляем! Теперь Кеша ваш новый питомец!");
                                    break;
                                }
                                else
                                {
                                    if (buy == 5)
                                    {
                                        Console.WriteLine("Поздравляем! Теперь Керпе ваш новый питомец!");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}