Console.WriteLine("asigna un valor para saber si es par o impar");
int num = int.Parse(Console.ReadLine());


if ((num % 2) == 0)
{
    Console.WriteLine("Es par ");
    Console.ReadKey();
}
else
    Console.WriteLine("Es impar ");

Console.ReadKey();
