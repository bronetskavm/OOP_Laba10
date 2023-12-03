using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // 1. Створення об’єкта класу-колеції
        SortedList mySortedList = new SortedList();

        // 2. Додавання елементів в колекцію
        mySortedList.Add("keyString", "Hello, String!");
        mySortedList.Add("keyDouble", 3.14);
        mySortedList.Add("keyInt", 42);

        // Виведення елементів колекції
        Console.WriteLine("Елементи колекції:");
        PrintCollection(mySortedList);

        // 3. Пошук елементів в колекції
        Console.WriteLine("\nПошук елементів в колекції:");
        SearchAndPrint(mySortedList, "keyString");
        SearchAndPrint(mySortedList, "keyDouble");
        SearchAndPrint(mySortedList, "keyInt");
        SearchAndPrint(mySortedList, "nonexistentKey");

        // 4. Визначення кількості елементів в колекції
        Console.WriteLine($"\nКількість елементів у колекції: {mySortedList.Count}");

        // 5. Вилучення елементів з колекції
        mySortedList.Remove("keyDouble");
        Console.WriteLine("\nЕлементи колекції після вилучення:");
        PrintCollection(mySortedList);

        // 6. Очищення колекції
        mySortedList.Clear();
        Console.WriteLine("\nКолекція після очищення:");
        PrintCollection(mySortedList);
    }

    static void PrintCollection(SortedList sortedList)
    {
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }

    static void SearchAndPrint(SortedList sortedList, string key)
    {
        if (sortedList.ContainsKey(key))
        {
            Console.WriteLine($"Знайдено елемент з ключем '{key}': {sortedList[key]}");
        }
        else
        {
            Console.WriteLine($"Елемент з ключем '{key}' не знайдено.");
        }
    }
}