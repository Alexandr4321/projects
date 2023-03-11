void CountNumbers(string [] array1, string[] array2)
{
    int count=0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length<=3)
        {
            array2[count]=array1[i];
            count++;

        }
    }
}
 void ShowArray( string [] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
 }

string [] array1 = new string[7] {"1234","hello","23","res","world","1","mom"};
string [] array2 = new string[array1.Length];

CountNumbers(array1 , array2);
ShowArray(array2);
