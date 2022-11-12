// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int m = GetNumberFromUser("Введите положительное число m: ", "Ошибка ввода!");
if (m < 0) Console.WriteLine("ERROR!!! Введено отрицательное число");
else
{
    int n = GetNumberFromUser("Введите положительное число n: ", "Ошибка ввода!");
    if (n < 0) Console.WriteLine("ERROR!!! Введено отрицательное число");
    else
    {
        int result = FuncAckermann(m, n);
        Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {result}");
    }
}

//////////////////////// Methods///////////////////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int FuncAckermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return FuncAckermann(m - 1, 1);
    else
        return FuncAckermann(m - 1, FuncAckermann(m, n - 1));
}