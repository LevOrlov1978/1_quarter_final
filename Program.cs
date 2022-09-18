Console.Write("Введите количество элементов текстовых массивов: ");
int  N = Convert.ToInt32(Console.ReadLine());

string [] array1 = new string[N];//исходный массив
string [] array2 = new string[N];//новый массив
int count=0;
for (int i = 0; i < N; i++)
{
Console.WriteLine($"Введите текстовую строку № {i+1}");
        array1[i] = Console.ReadLine(); 
   if (array1[i].Length<=3)
   {
   array2[count] = array1[i];
    count=count+1;  
    } 
}
Console.WriteLine("Элементы не больше 3 символов:");
for (int i = 0; i < count; i++)
{
    Console.Write ($"{array2[i]}| ");
}

Console.WriteLine();