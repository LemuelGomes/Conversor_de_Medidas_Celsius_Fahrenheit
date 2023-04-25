int opcao;
double celsius;
double fahrenheit;
double conversao1;
double conversao2;

Console.WriteLine("Olá! Bem vindo ao aplicativo de conversão de temperatura");
Console.WriteLine("Para começar digite: ");
Console.WriteLine("1 para conversão CELSIUS -> FAHRENHEIT");
Console.WriteLine("2 para conversão FAHRENHEIT -> CELSIUS");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Conversão CELSIUS -> FAHRENHEIT foi escolhida");
        Console.WriteLine("Insira a temperatura em CELSIUS (°C");
        celsius = double.Parse(Console.ReadLine());

        conversao1 = (celsius * 9) / 5 + 32;

        Console.WriteLine(celsius + " em FAHRENHEIT é: " + conversao1);

        break;

    case 2:
        Console.WriteLine("Conversão FAHRENHEIT -> CELSIUS foi escolhida");
        Console.WriteLine("Insira a temperatura em FAHRENHEIT (°F)");
        fahrenheit = double.Parse(Console.ReadLine());

        conversao2 = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine(fahrenheit + " em CELSIUS é: " + conversao2);
        break;

    default:
        Console.WriteLine("Opção não existe.");
        break;
}