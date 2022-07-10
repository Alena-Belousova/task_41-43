// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("задача 41");
Console.WriteLine("введите несколько чисел: ");
string numbers = Console.ReadLine();
string[] array = numbers.Split(' ');
string a= string.Join(" ", array);
Console.WriteLine("["+a+"]");
int count =0;
for(int i=0; i<array.Length; i++)
{int b = Convert.ToInt32(array[i]);
    if(b>0)
    {count++;
    }
}
Console.WriteLine("кол-во положительных: "+count);
