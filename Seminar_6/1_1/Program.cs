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
  Console.WriteLine();
}

int[,] new_mass = NewMass(10, 9, 0, 10);
Print (new_mass);

void Replace_columns_rows(int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);
  if(row != column) 
  {
    Console.WriteLine("error");
    return;
  }
  for (int i = 0; i<row; i++)
  {
    for (int j = 0; j<i; j++)
    {
      (arr[i,j], arr[j,i]) = (arr[j,i], arr[i,j]);
    }
  }
}
Replace_columns_rows(new_mass);
Print (new_mass);