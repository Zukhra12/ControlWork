string [] CreateRandomArray(int size)
{
    string [] newArray = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input element:");
        Console.Write($"Input {i+1} element of {size}: ");
        newArray [i] = Console.ReadLine();
    } return newArray;
}

void ShowArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(" " + array [i] + " ");
    Console.WriteLine();
}

void MethodArray (string [] array)
{
     string[] newarr = new string[array.Length];
     for (int i=0; i<array.Length; i++)
     {      
        if(array[i].Length<=3)
        {
           newarr[i]=array[i];
           Console.Write(" " + newarr[i] + " "); 
        }
        else Console.Write("there is no such element");
     }
        Console.WriteLine(); 
}

Console.Write("Input size our array: ");
int x = Convert.ToInt32(Console.ReadLine());
string [] Array = CreateRandomArray(x);
Console.Write("Our array: ");
ShowArray(Array); 
Console.Write("Array with elements of 3 symbol: ");    
MethodArray(Array);