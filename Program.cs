/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Введите первое число ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    Console.Write("Первое число больше второго");
}
else if (secondNum > firstNum)
{
    Console.Write("Второе число больше первого");
}
else
{
    Console.Write("Числа равны");
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

//Михаил, я здесь не понтуюсь, просто решил попрактиковать инфу и из лекции тоже и создать и использовать метод))


/*
int Max(int a, int b, int c) //создаем (определяем?) метод, который позволит найти максимум из трех целых чисел
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;

    return max;
}

Console.Write("Введите первое число ");
int numOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int numTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число ");
int numThree = Convert.ToInt32(Console.ReadLine());

int generalMax = Max(numOne, numTwo, numThree);

Console.Write("Максимальное число равно " + generalMax);
*/


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно 
на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Введите число ");
int singleNum = Convert.ToInt32(Console.ReadLine());

if (singleNum % 2 == 0)
{
    Console.Write("Число чётное, чётненькое, чётнюсенькое ага");
}
else
{
    Console.Write("Число вообще ни разу не четное.");
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // введем N
int index = 2;

if (index > number)
{
    Console.Write("Так не пойдет, введите число покрупнее");
}
else Console.WriteLine("А вот и все четные числа до указанного (включительно): ");

while (index <= number)
{
    Console.Write(index + " ");
    index += 2;
}
