int ElementCount(string[] array, int n)
{
  int count = 0;
  foreach (string element in array)
  {
    if (element.Length <= n)
      count++;
  }
  return count;
}

string[] NewString(string[] array, int k)
{
  int n = ElementCount(array, k);
  string[] newArray = new string[n];
  int index = 0;
  foreach (string element in array)
  {
    if (element.Length <= k)
    {
      newArray[index] = element;
      index++;
    }
  }
  return newArray;
}

void InputArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToString(Console.ReadLine());
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
Console.WriteLine("Введите элементы массива: ");
InputArray(array);
int m = ElementCount(array, 3);
Console.WriteLine($"Итоговый массив: [{string.Join(" ", NewString(array, 3))}]");


