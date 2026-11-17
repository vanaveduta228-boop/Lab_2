using System;

class Program {
    static void Main() {
        Console.WriteLine("Введіть вираз (через пробіл, наприклад: 5 + 5 * 10 + 4 / 2 - 3):");
        string input = Console.ReadLine()!;
        string[] parts = input.Split(' ');

        int count = (parts.Length + 1) / 2;
        float[] numbers = new float[count];
        string[] ops = new string[count - 1];

        // Распределяем числа и знаки по разным массивам
        int numIndex = 0, opIndex = 0;
        for (int i = 0; i < parts.Length; i++) {
            if (i % 2 == 0) {
                numbers[numIndex++] = float.Parse(parts[i]);
            } else {
                ops[opIndex++] = parts[i];
            }
        }

        // Шаг 1. Выполняем только умножение и деление
        for (int i = 0; i < ops.Length; i++) {
            if (ops[i] == "*" || ops[i] == "/") {
                if (ops[i] == "*") {
                    numbers[i + 1] = numbers[i] * numbers[i + 1];
                } else {
                    numbers[i + 1] = numbers[i] / numbers[i + 1];
                }
                numbers[i] = 0; 
                
                // Переносим знак минус, если он стоял перед умножением
                ops[i] = (i > 0 && ops[i - 1] == "-") ? "-" : "+";
            }
        }

        // Шаг 2. Выполняем сложение и вычитание слева направо
        float result = numbers[0];
        for (int i = 0; i < ops.Length; i++) {
            if (ops[i] == "+") {
                result += numbers[i + 1];
            } else if (ops[i] == "-") {
                result -= numbers[i + 1];
            }
        }

        Console.WriteLine($"Відповідь програми: {result}");
    }
}
