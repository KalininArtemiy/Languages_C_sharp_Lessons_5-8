//func for filling first array
string[] Fill_array1(string[] array1)
{
  for (int i = 0; i < array1.Length; i++)
  {
    Console.WriteLine($"Enter {i+1} massive element");
    array1[i] = Console.ReadLine();
  }
  return array1;
}
//func for printing  array
  void PrintMass(string[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

int Make_array2(string[] array1)
{
  int count = 0;
  for (int i = 0; i<array1.Length; i++)
  {
    if (array1[i].Length <= 3)
    {
      count = count + 1;
    }
  }
  return count;
}

string[] Fill_array2(string[] array1, string[] array2)
{
  int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= 3)
    {
      array2[count] = array1[i];
      count = count + 1;
    }
  }
  return array2;
}




Console.WriteLine("Enter the lenth of the massive");
// entering the length of  the first array 
int first_array_length = int.Parse((Console.ReadLine()));
// making first array
string[] first_array = new string[first_array_length];
//filling first array
Fill_array1(first_array);
//Printing first array
Console.WriteLine();
Console.WriteLine("Your array: ");
PrintMass(first_array);
Console.WriteLine();
//making 2 array
string[] second_array = new string[Make_array2(first_array)];
//filling second array
Fill_array2(first_array, second_array);
Console.WriteLine();
Console.WriteLine("Remade array: ");
PrintMass(second_array);