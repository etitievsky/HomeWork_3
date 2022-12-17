// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

string EnterData(string text)
{
    Console.Write(text);
    string number = Console.ReadLine();
    return number;
}
void CheckPalindrom(string number)
{
    if (number[0]==number[4] & number[1]==number[3]) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

Console.Clear();
string number = EnterData("Введите пятизначное число: ");
CheckPalindrom(number);