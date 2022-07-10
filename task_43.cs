// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("задача 43");
Console.Write("задайте b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());
//х=(b2-b1)/(k1-k2)
if(k1-k2==0){
    Console.WriteLine("ошибка: на 0 делить нельзя");
}
else{
    int x = (b2-b1)/(k1-k2);
int y= k1*x+b1;
Console.WriteLine("каординаты ("+ x+";"+y+")");}
