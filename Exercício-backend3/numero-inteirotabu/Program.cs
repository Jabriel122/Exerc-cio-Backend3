// Entrada

Console.WriteLine($"Digite um número inteiro");
int n1 = int.Parse(Console.ReadLine());
int resultado;

for (int i = 1; i <= 10 ; i++)
{
    resultado = n1*i;
    Console.WriteLine($"{n1} X {i} = {resultado}");
}

