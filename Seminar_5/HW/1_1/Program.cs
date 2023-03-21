double[,] NewMass(int row, int column, int from, int to)
{
  double[,] arr = new double[row, column];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      arr[i,j] = Math.Round(new Random().NextDouble() * (to - from) + from, 4);
    }
  }
  return arr;
}

void Print(double[,] array)
{
  int row = array.GetLength(0);
  int column = array.GetLength(1);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      Console.Write($" {array[i, j]}");
    }
    Console.WriteLine();
  }
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
double[,] mass = NewMass(num_row, num_column, from, to);
Print(mass);