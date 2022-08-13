// Задача: написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3.

string[] StringMass = {"Friend", "22", "Sun", "Friday", "Fairy", "Program", "Git", "Summer"};
for (int i = 0; i < StringMass.Length; i++)
{
Console.WriteLine("SM[{0}] = {1}", i, StringMass[i]);
Console.ReadKey();
}

/*
for (int i = 0; i < StringMass.Length; i++)
{
    if (StringMass[i].Length <= 3)
    {
        Console.WriteLine("SM[{0}] = {1}", i, StringMass[i]);
        Console.ReadKey();
    }

}
*/

var list = new List<int>();
for (int i = 0; i < StringMass.Length; i++)
{
    if (StringMass[i].Length <= 3)
    {   
        list.Add(i);
        Console.WriteLine(list[i]);
    }

}

///////////////////////////////////////
/*
for (int i = 0; i < StringMass.Length; i++)
{
    if (StringMass[i].Length <= 3)
    {   list.Add(i);
        Console.WriteLine("SM[{0}] = {1}", i, StringMass[i]);
        Console.ReadKey();
    }

}

///////////////////////////////////////////////////////
*/