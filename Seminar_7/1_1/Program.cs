void ValuesSet(int N, int M)
{
  if (N < M) return;
  ValuesSet(N - 1, M);
  Console.Write ($"{N} ");
}
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValuesSet(num1, num2);