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

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
int[,] mass = NewMass(num_row, num_column, from, to);
Print(mass);

void FindNumber(int[,] array, int find_in_row, int find_in_column)
{
  int i = find_in_row - 1;
  int j = find_in_column - 1;
  if (i < 0 || j < 0) Console.WriteLine("Out of range");
  else if (i > array.GetLength(0) || i > array.GetLength(1))
  {
    Console.WriteLine("Out of range");
  }
  else Console.WriteLine(array[i,j]); 
}
FindNumber(mass, 
int.Parse(Console.ReadLine()!), 
int.Parse(Console.ReadLine()!));