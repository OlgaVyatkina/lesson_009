// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int n = inputNumber("Введите натуральное число n: ");
int m = inputNumber("Введите натуральное число m: ");
PrintSequence($"Функция Аккермана: A({m},{n}) = ");

int  A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
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
      Console.WriteLine($"{text} {A(m, n)}");
} 