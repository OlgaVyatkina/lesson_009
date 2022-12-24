// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int N = inputNumber("Введите натуральное число N: ");
int M = inputNumber("Введите натуральное число M: ");
PrintSequence($"Cумма натуральных элементов в промежутке от {N} до {M}: ");


int NumberRec(int M, int N)
{
    int result;
    if (M <= N) return result = M + NumberRec(M + 1, N);
    else return 0;
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
    Console.WriteLine($"{text} {NumberRec(M, N)}");
}
