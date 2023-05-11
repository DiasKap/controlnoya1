string[] arrayStart = new string[14] {"Hello", "world", "!", "My", "name", "is", "Dias", "!", "And", "I", "have", "done", "it", ":)"};
string[] arrayFinal = new string[arrayStart.Length];
void ShortArray(string[] arrayStart, string[] arrayFinal)
{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
    if(arrayStart[i].Length <= 3)
        {
        arrayFinal[count] = arrayStart[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ShortArray(arrayStart, arrayFinal);
PrintArray(arrayFinal);