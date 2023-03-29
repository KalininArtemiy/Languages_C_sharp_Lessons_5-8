﻿int[,] NewMass(int row, int column, int from, int to)
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

int[,] new_mass = NewMass(10, 10, 0, 10);
Print (new_mass);

void FirstChangeLast(int[,] array)
{
  int row = array.GetLength(0);
  int column = array.GetLength(1);
  for (int j = 0; j<column; j++)
  {
    (array[0,j], array[row - 1,j]) = (array[row - 1,j],array[0,j]);
  }
}

FirstChangeLast(new_mass);
Print (new_mass);