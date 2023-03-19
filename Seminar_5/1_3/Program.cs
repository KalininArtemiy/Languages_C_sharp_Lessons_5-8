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
      Console.Write($" {array[i, j]}");
    }
    Console.WriteLine();
  }
}

int summ(int[,] array)
{
  int sum = 0;
  for (int i = 0; i < array.GetLength(0); i ++)
  {
    for (int j = 0; j < array.GetLength(1); j ++)
    {
      if(i == j) sum = sum + array[i,j];
    }
  }
  return sum;
}

int[,] new_mass = NewMass(4, 4, 0, 10);
Print (new_mass);
int sum = summ(new_mass);
Console.WriteLine(sum);