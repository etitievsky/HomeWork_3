// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов

// Методы
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void WriteTable(int n)
{
    int i = 1;
    double resalt = 0;
    while(i <= n)
    {
        resalt = Math.Pow(i, 3);
        Console.Write(resalt+", ");
        i = i + 1;
    }
}

Console.Clear();
// Запросим число N
int n = EnterData("Введите число N: ");
// Вывод информации
WriteTable(n);