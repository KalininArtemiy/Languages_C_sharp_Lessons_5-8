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

int[] NumbersCount(int[,] arr)
{
  int[] array = new int[10];
  foreach (int a in arr) array[a] ++;
  return array;
}



void Print_2(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine($"{i} - {array[i]}");
  }
}

int[,] new_mass = NewMass(10, 9, 0, 10);
Print (new_mass);
int[] count = NumbersCount(new_mass);
Console.WriteLine("HELLO");
Print_2(count);