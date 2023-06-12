// Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int Summ(int M, int N)
{
  if (N < M) return 0;
  return Summ(M, N-1) + N;
}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(Summ(num1, num2));
