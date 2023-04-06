// Entrada

Console.WriteLine($"Qual é o seu nome de usúario");
string user = Console.ReadLine();

Console.WriteLine($"Qual é a sua senha");
string pass = Console.ReadLine();
while(user == pass)
{
    Console.WriteLine($"Usuário e a senha não podem ser iguais. Digite uma senha ou usúario válido");
    
    Console.WriteLine($"Digite o usuário");
    user = Console.ReadLine();
    
    Console.WriteLine($"Digite a senha ");
    pass = Console.ReadLine();    
}

Console.WriteLine($"Tela de login montada");

Console.WriteLine($"Novamente, cofirme nos o seu username");
string userR1 =Console.ReadLine();

Console.WriteLine($"Agora sua senha");
string passR1 = Console.ReadLine();

while(user != userR1 || pass != passR1)
{
    if( user != userR1 && pass != passR1)
    {
        Console.WriteLine($"Nome e senha inválido, digite novamente");

        Console.WriteLine($"Nome");
        userR1 = Console.ReadLine();

        Console.WriteLine($"Senha");
        passR1 = Console.ReadLine();        
    }

    else if (user != userR1 || pass != passR1)
    {
        Console.WriteLine($"Nome ou senha inválido, digite novamente");

        Console.WriteLine($"Nome");
        userR1 = Console.ReadLine();

        Console.WriteLine($"Senha");
        passR1 = Console.ReadLine(); 
    }
}

Console.WriteLine($"Sua conta foi logada, bem vindo {userR1}");






