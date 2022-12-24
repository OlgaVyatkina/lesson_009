// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int N = inputNumber("Введите натуральное число N: ");
PrintSequence($"Натуральные числа в промежутке от {N} до 1:");


string NumberRec(int N)
{
    string result;
    if (N >= 1) return result = $" {N} " + NumberRec(N - 1);
    else return String.Empty;
}


int inputNumber(string textOutput)
{
    int number;

    while (true)
    {
        Console.Write(textOutput);
        string? textInput = Console.ReadLine();
        if ((int.TryParse(textInput, out number)) && (number > 0))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

void PrintSequence(string text)
{
    Console.WriteLine($"{text} {NumberRec(N)}");
}
