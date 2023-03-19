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

void POW(int[,] array)
{
  int row = array.GetLength(0);
  int column = array.GetLength(1);
  for (int i = 1; i < row; i = i +2)
  {
    for (int j = 1; j < column; j = j + 2)
    {
      array[i,j] = array[i,j] * array[i,j];
    }
  }
}

int[,] new_mass = NewMass(4, 4, 0, 10);
Print (new_mass);
POW (new_mass);
Console.WriteLine();
Print (new_mass);