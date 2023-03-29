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

int[] Find_sum (int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  int[] new_arr = new int[rows];
  for(int i = 0; i<rows; i++)
  {
    int sum = 0;
    for(int j = 0; j<columns; j++)
    {
      sum = sum + array[i,j];
    }
    new_arr[i] = sum;
    Console.WriteLine($"The {i+1} row sum = {sum} ");
  }
  return new_arr;
}

void TheLowestSum(int[] array)
{
  int lowest_sum = array[0];
  int lowest_index = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if (array[i] < lowest_sum)
    {
      lowest_sum = array[i];
      lowest_index = i;
    }
  }
  Console.WriteLine($"The lowest sum is in {lowest_index+1} row and it's amount - {lowest_sum}");
}
int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
int[,] mass = NewMass(num_row, num_column, from, to);
Console.WriteLine();
Print(mass);
Console.WriteLine();
TheLowestSum(Find_sum(mass));