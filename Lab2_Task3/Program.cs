using System;

class Program {
    static void Main() {
        string[] questions = {
            "Питання 1, які кольори у прапору України?",
            "Питання 2, в якому місті знаходиться ДТЕУ?",
            "Питання 3, скільки біт у типі даних byte?",
            "Питання 4, який оператор відповідає за логічне І (AND) в C#?",
            "Питання 5, який індекс має перший елемент масиву в C#?"
        };

        string[,] options = {
            { "1.жовтий і блакитний", "2.червоний і зелений", "3.чорний і жовтий", "4.зелений і фіолетовий" },
            { "1.Вінниця", "2.Київ", "3.Львів", "4.Одеса" },
            { "1.4", "2.8", "3.16", "4.32" },
            { "1.||", "2.!", "3.&&", "4.^" },
            { "1.0", "2.1", "3.-1", "4.2" }
        };

        int[] correctAnswers = { 1, 2, 2, 3, 1 };
        int score = 0;

        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine(questions[i]);

            for (int j = 0; j < 4; j++) {
                Console.WriteLine("   " + options[i, j]);
            }

            int answer = int.Parse(Console.ReadLine()!);

            if (answer == correctAnswers[i]) {
                Console.WriteLine("Correct answer\n");
                score += 100;
            } else {
                Console.WriteLine("Wrong Answer");
                Console.WriteLine("кінець програми.");
                return; // Сразу завершаем программу при ошибке
            }
        }

        // Если дошли до конца и ответили на все
        Console.WriteLine($"Current User Score: {score}");
        Console.WriteLine("кінець програми.");
    }
}
