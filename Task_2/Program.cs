// Программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

Console.Clear();
int x1 = EnterData("Введите координаты x1: ");
int y1 = EnterData("Введите координаты y1: ");
int z1 = EnterData("Введите координаты z1: ");
int x2 = EnterData("Введите координаты x2: ");
int y2 = EnterData("Введите координаты y2: ");
int z2 = EnterData("Введите координаты z2: ");

double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));

Console.WriteLine(distance);