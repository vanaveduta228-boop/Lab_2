using System;

class Program {
    static void Main() {
        Console.WriteLine("Введіть висоту трикутника:");
        int height = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= height; i++) {
            // Пробелы для выравнивания по центру (как в примере)
            for (int s = 0; s < height - i; s++) {
                Console.Write(" ");
            }
            // Вывод цифр с пробелом
            for (int j = 0; j < i; j++) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
