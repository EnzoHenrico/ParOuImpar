int number;

Console.Write("Digite um numero: ");
number = int.Parse(Console.ReadLine());

if ((number % 2) == 0)
{
    Console.WriteLine("O número é par");
}
else
{
    Console.WriteLine("O número é impar");
}