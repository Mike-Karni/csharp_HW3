//Задача21:Напишите программу,кот принимает на вход координаты двух (.) и находит расстояние между ними в 3D простр.

/*Console.Write("Введите координату x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());*/
// distance = sq.root((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1)
/*int a = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1)+ (z2-z1)*(z2-z1);
double d = Math.Round(Math.Sqrt(a),2);
Console.WriteLine("Расстояние между двумя точками равно " + d);*/

int xA = InputCoordinate("x", "A");
int yA = InputCoordinate("y", "A");
int zA = InputCoordinate("z", "A");
int xB = InputCoordinate("x", "B");
int yB = InputCoordinate("y", "B");
int zB = InputCoordinate("z", "B");
// Вкорячили функцию на ввод
int InputCoordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int a = (xB-xA)*(xB-xA) + (yB-yA)*(yB-yA)+ (zB-zA)*(zB-zA);
double d = Math.Round(Math.Sqrt(a),2);
Console.WriteLine("Расстояние между двумя точками равно " + d);