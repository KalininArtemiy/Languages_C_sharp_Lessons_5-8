int ValuesSet(int A, int B)
{
  if (B < 1) return 1;
  return ValuesSet (A, B - 1) * A ; 
}
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValuesSet(num1, num2));
