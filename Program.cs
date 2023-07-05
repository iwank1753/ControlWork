Console.WriteLine("Введите количество элементов массива: ");
int size  = int.Parse(Console.ReadLine());

string[] stringarr = new string[size];

for (int i = 0; i < size; i++)
{
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
	stringarr[i] = result;  
}
Console.WriteLine();
Console.Write($"Введенный массив: ");
Console.Write(string.Join(",", stringarr));
Console.Write(" ");

int count = 0;
int maxSymbols = 3;

for (int i = 0; i < stringarr.Length; i++)
{
	if(stringarr[i].Length <= maxSymbols)
    {
		count++;
	}   
}
Console.WriteLine();
Console.Write("Полученный массив: ");
string[] stringarray = new string[count];
int j = 0;
for (int i = 0; i < stringarr.Length; i++)
{
    if(stringarr[i].Length <= maxSymbols)
    {
        stringarray[j] = stringarr[i];
        Console.Write(stringarray[j] + ",");
        j++;
    }
}
Console.Write(" ");