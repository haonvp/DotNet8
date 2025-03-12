Console.OutputEncoding = System.Text.Encoding.UTF8;
int[] number = new int[5];
number[0] = 1;
number[1] = 2;
number[2] = 3;

//foreach (var num in number)
//{
//    Console.WriteLine(num);
//}

//for(int i= 0; i< number.Length; i++)
//{
//    Console.WriteLine(number[i]);
//}

string[] fruit = { "apple", "banana", "orange" };

int[] numb = { 2, 3, 4, 5, 1, 6 };
Console.Write("Các số chẵn: ");
foreach(int n in numb)
{
    if(n % 2 == 0)
    {
        Console.Write(n + " ");
    }
}
Console.ReadKey();