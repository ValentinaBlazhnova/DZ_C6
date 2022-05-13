/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Решение:
y = k1 * x + b1 
y = k2 * x + b2;

k1 * x + b1 = k2 * x + b2;
k1 * x - k2 * x = b2 - b1;
x * (k1 - k2) = b2 - b1;
x = (b2 - b1)/ (k1 - k2);
y = k1 * ((b2 - b1)/ (k1 - k2)) + b1;*/ 



double InputNumber(string data)
{
    Console.Write($"Введите значение {data} ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double b1 = InputNumber("b1");
double k1 = InputNumber("k1");
double b2 = InputNumber("b2");
double k2 = InputNumber("k2");

double x = 0;
double y = 0;

x = (b2 - b1)/ (k1 - k2);
y = k1 * x + b1;
Console.WriteLine($"Координаты точки перечения 2-ух прямых ({x}; {y})");





