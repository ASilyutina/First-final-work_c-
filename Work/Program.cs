// Написать программу, которая из массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнений алгоритма.


Console.WriteLine("Cozdadim massiv is neskolkix znachenii \n kakoe kolichestvo znachenii  budem vyvodit?");
int countArrayValue = int.Parse(Console.ReadLine());

string [] startArray = new string [countArrayValue];
 
 string [] FillArray (string [] array)
 {
	for (int i = 0; i < countArrayValue; i++)
	{
		Console.WriteLine($"Vvedite {i}  znachenie:");
		array[i] = Console.ReadLine();
	}
	return array;
}

string [] SortArray (string [] array)
{
	int countNecessaryValue = 0;
	string arrayValue = string.Empty;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3) countNecessaryValue++;
	}

	string [] endArray = new string [countNecessaryValue];
	int index = 0;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3)
		{
			endArray[index] = array[i];
			index++;
		}
	}
	return endArray;
}

void PrintArray (string [] array)
{
	if (array.Length == 0) Console.WriteLine("Massiv ne imeet znachenii!");
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"  [{array[i]}]");
		}
}

FillArray(startArray);

string [] endArray = SortArray(startArray);

Console.WriteLine("\n Pervonachalnyi massiv:");
PrintArray(startArray);

Console.WriteLine("\n  Massiv znachenii c dlinoi (<) libo = (3) simvola:");
PrintArray(endArray);