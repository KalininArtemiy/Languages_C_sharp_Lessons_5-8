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

int[] Find_min (int[,] array)
{
  int min_num = array [0,0];
  Console.WriteLine($"Start is {min_num}"); 
  int x = 0;
  int y = 0;
  for (int i = 0; i<array.GetLength(0); i++)
  {
    for (int j = 0; j<array.GetLength(1); j++)
    {
      if (array[i,j] < min_num)
      {
        min_num = array[i,j]; 
        x = i;
        y = j;
      }
    }
  }
  Console.WriteLine($"The minimal is {min_num}");
  int[] arr = new int[2] {x, y};
  Console.WriteLine($"The minimum index is ({x},{y})");
  Console.WriteLine($"The minimum position is ({x+1},{y+1})");
  return arr;
}

void Delete_min(int[,] array, int[] another_array)
{
  int row = array.GetLength(0);
  int column = array.GetLength(1);
  for (int i = 0; i < row; i++)
    {if(i == another_array[0])
    {
      continue;
    }
    for (int j = 0; j < column; j++)
    {
      if(j == another_array[1])
      {
        continue;
      }
      else
      {
        Console.Write($" {array[i, j]}");
      }
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
Console.WriteLine();
Delete_min(mass, Find_min(mass));
