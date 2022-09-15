string[] array = new string[7] { "Neo", "9999", "Hob33", "123", "GB", "Green", "77" };
int variable = 0;
int size = 0;
int sizearray = SizeNewArray(array);
string[] newarray = new string[sizearray];
int SizeNewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            size++;
    }
    return size;
}
void SourceArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[variable] = array[i];
            variable++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ,");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}
SourceArray(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(newarray);