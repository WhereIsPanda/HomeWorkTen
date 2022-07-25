// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N, кратные трём.

void Zadacha64()
{
    Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n");
    int n = Convert.ToInt32(Console.ReadLine());
    AllNumber(m, n);
    
}

void AllNumber(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 3 == 0)
    {
        Console.WriteLine(m + "\t");
    }
    m++;
    AllNumber(m, n);
}
//Zadacha64();
//Zadacha66();


// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

void Zadacha66()
{
    Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n");
    int n = Convert.ToInt32(Console.ReadLine());
    Sum(m, n);
    
    
}

void Sum(int m, int n, int sum=0)
{
    if (m > n)
    {
        Console.WriteLine(sum);
        return;
    }
    sum = sum + m;
    m++;
    Sum(m, n, sum);

}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(AkkermanFunc(m, n));


int AkkermanFunc(int m, int n)
{
   if (m == 0)
   {
       return n + 1;
   }
   else if (n == 0)
   {
       return AkkermanFunc(m - 1,1);
   }
   else 
   {
       return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
   }
}
