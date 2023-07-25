start:

Console.Write("Multiplication Table\n");
Console.Write("What's the number you want to put in table? ");
int n1 = Convert.ToInt16(Console.ReadLine());

for(int i = 0;i <= 10; i++)
{
    Console.WriteLine($"{n1} X {i} = {n1*i}");
}
Console.ReadKey();
Console.Clear();
goto start;