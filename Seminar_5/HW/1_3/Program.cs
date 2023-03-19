int[,] NewMass(int row, int column, int from, int to)
{
  int[,] arr = new int[row, column];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      arr[i,j] = new Random().Next(from, to);
    }
  }
  return arr;
}

void Print(int[,] array)
{
  int row = array.GetLength(0);
  int column = array.GetLength(1);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
} 

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
int[,] mass = NewMass(num_row, num_column, from, to);
Print(mass);

void arithmetic_mean(int[,] array)
{
  double sum = 0;
  for(int j = 0; j<array.GetLength(1); j++)
  {
    for(int i = 0; i<array.GetLength(0); i++)
    {
      sum = sum + array[i,j];
    }
    Console.Write($"{sum/array.GetLength(0)}  ");
    sum = 0;
  }
}

arithmetic_mean(mass);