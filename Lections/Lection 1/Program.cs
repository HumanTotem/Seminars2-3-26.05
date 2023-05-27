// string text = "Капитально Соль сова Совок Кукловод соКрат краСный";

// string Replace(string text, char oldvalue, char newvalue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldvalue) result = result + $"{newvalue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '_');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'К', 'к');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();

int[] arr = {1, 7, 9, 5, 4, 3, 7, 5, 9, 8, 2};

void PrintArray(int[] array)
{
    int count = Array.MaxLength;
    for (int i =  0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);