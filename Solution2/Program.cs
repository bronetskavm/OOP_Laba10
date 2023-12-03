using SimpleClassLibrary;

class Program
{
    static void Main()
    {
        // 1. Створення об’єкта класу-колеції
        Dictionary<string, Worker> workersDictionary = new Dictionary<string, Worker>();

        // 2. Додавання елементів в колекцію
        Worker worker1 = new Worker("John", 2010, 5, 1000, new string[] { "CompanyA", "Developer", "5000" });
        Worker worker2 = new Worker("Alice", 2015, 8, 1200, new string[] { "CompanyB", "Manager", "6000" });
        Worker worker3 = new Worker("Bob", 2012, 3, 800, new string[] { "CompanyC", "Tester", "4500" });

        workersDictionary.Add(worker1.Name, worker1);
        workersDictionary.Add(worker2.Name, worker2);
        workersDictionary.Add(worker3.Name, worker3);

        // Виведення елементів колекції
        Console.WriteLine("Елементи колекції:");
        PrintCollection(workersDictionary);

        // 3. Пошук елементів в колекції
        Console.WriteLine("\nПошук елементів в колекції:");
        SearchAndPrint(workersDictionary, "John");
        SearchAndPrint(workersDictionary, "Alice");
        SearchAndPrint(workersDictionary, "Bob");
        SearchAndPrint(workersDictionary, "Charlie");

        // 4. Визначення кількості елементів у колекції
        Console.WriteLine($"\nКількість елементів у колекції: {workersDictionary.Count}");

        // 5. Вилучення елементів з колекції
        workersDictionary.Remove("Alice");
        Console.WriteLine("\nЕлементи колекції після вилучення:");
        PrintCollection(workersDictionary);

        // 6. Очищення колекції
        workersDictionary.Clear();
        Console.WriteLine("\nКолекція після очищення:");
        PrintCollection(workersDictionary);
    }

    static void PrintCollection(Dictionary<string, Worker> dictionary)
    {
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value.Name}, Position: {entry.Value.WorkPlace.Position}, Salary: {entry.Value.WorkPlace.Salary}");
        }
    }

    static void SearchAndPrint(Dictionary<string, Worker> dictionary, string key)
    {
        if (dictionary.ContainsKey(key))
        {
            Console.WriteLine($"Знайдено працівника з ім'ям '{key}': {dictionary[key].Name}, Position: {dictionary[key].WorkPlace.Position}, Salary: {dictionary[key].WorkPlace.Salary}");
        }
        else
        {
            Console.WriteLine($"Працівник з ім'ям '{key}' не знайдено.");
        }
    }
}