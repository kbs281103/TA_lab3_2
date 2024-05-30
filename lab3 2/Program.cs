using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        // Встановіть кодування консолі на UTF-8
        Console.OutputEncoding = Encoding.UTF8;

        // Шлях до текстового файлу
        string filePath = "textfile.txt";

        // Словник для підрахунку кількості входжень українських голосних букв
        Dictionary<char, int> vowelCount = new Dictionary<char, int>
        {
            { 'а', 0 },
            { 'е', 0 },
            { 'и', 0 },
            { 'і', 0 },
            { 'о', 0 },
            { 'у', 0 },
            { 'є', 0 },
            { 'ї', 0 },
            { 'ю', 0 },
            { 'я', 0 },
            { 'А', 0 },
            { 'Е', 0 },
            { 'И', 0 },
            { 'І', 0 },
            { 'О', 0 },
            { 'У', 0 },
            { 'Є', 0 },
            { 'Ї', 0 },
            { 'Ю', 0 },
            { 'Я', 0 }
        };

        // Читаємо вміст файлу з кодуванням UTF-8
        try
        {
            string text = File.ReadAllText(filePath, Encoding.UTF8);

            // Підраховуємо кількість входжень кожної з українських голосних букв
            foreach (char c in text)
            {
                if (vowelCount.ContainsKey(c))
                {
                    vowelCount[c]++;
                }
            }

            // Виводимо результати
            Console.WriteLine("Кількість входжень українських голосних букв:");
            foreach (var kvp in vowelCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка при читанні файлу: " + ex.Message);
        }

        // Додайте команду, щоб затримати закриття програми
        Console.WriteLine("\nНатисніть будь-яку клавішу, щоб закрити програму...");
        Console.ReadKey();
    }
}
