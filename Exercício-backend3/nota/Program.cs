// Entrada
Console.WriteLine($"Qual foi sua nota. Lembrando digite uma nota de 0 a 10");
int nota = int.Parse(Console.ReadLine());

while(nota < 0 || nota > 10)
{
    Console.WriteLine($"Nota inválida, digita uma nota válida");
    nota = int.Parse(Console.ReadLine());
        
}

switch(nota)
{
case 0:
    Console.WriteLine($" Terrível,melhore!");
    break;
case 1:
    Console.WriteLine($" Terrível,melhore!");
    break;
case 2:
    Console.WriteLine($" Terrível,melhore!");
    break;
case 3:
    Console.WriteLine($" Terrível,melhore!");
    break;
case 4:
    Console.WriteLine($" Terrível,melhore!");
    break;
case 5:
    Console.WriteLine($" Você pode melhorar!");
    break;
case 6:
    Console.WriteLine($" Voce pode melhorar!");
    break;
case 7:
    Console.WriteLine($" Parabéns, mas você ainda pode melhorar!");
    break;
case 8:
    Console.WriteLine($" Parabéns, mas você ainda pode melhorar!");
    break;
case 9:
    Console.WriteLine($" Muito bem!!!");
    break;
case 10:
    Console.WriteLine($" MUITO BEMMMM, PArabéns, nota máxima para vc ;)");
    break;
}
