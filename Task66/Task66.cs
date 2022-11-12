// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int M = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int N = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");
if (N < M) Console.WriteLine("Ошибка ввода, N < M!");
else
{
    Console.Write($"M = {M}; N = {N} -> {GetSum(M, N)}");
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

int GetSum(int start, int end)
{
    int sum = 0;
    sum = sum + start;

    if (start == end)
    {
        return sum;
    }

    return (sum = sum + GetSum(start + 1, end));
}

string PrintNaturals(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + ", " + PrintNaturals(start - 1, end));
}
