// Задача: написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3.

string[] StringMass = {"Friend", "22", "Sun", "Friday", "Fairy", "Program", "Git", "Summer"};
for (int i = 0; i < StringMass.Length; i++)
{
Console.WriteLine("SM[{0}] = {1}", i, StringMass[i]);
Console.ReadKey();
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
          if (StringMass[i].Length <= 3)
    {
        Console.Write($"{array[i]} ");
    }
   
}
}
PrintArray(StringMass);