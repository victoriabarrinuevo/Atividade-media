Console.WriteLine("---Cálculo média escolar---");

Console.WriteLine("Digite a primeira nota da média:");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua segunda nota da média:");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua terceira nota da média:");
double nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua quarta nota da média:");
double nota4 = Convert.ToDouble(Console.ReadLine());


if  (nota1 < 0 || nota2 < 0 || nota3 < 0 || nota4 < 0 || nota1 > 10 || nota2 > 10 || nota3 > 10 || nota4 > 10) 
{
    Console.WriteLine("Notas inválidas, digite-as notamente");

}

else 
{
    double media = (nota1 + nota2 + nota3 + nota4) / 4;
    Console.WriteLine($"Sua média é {media:N1}");

if (media >= 7)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Parabéns, você está aprovado");

if (media == 10)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Parabéns, aprovado com nota máxima!");
}
}

else
{
 if (media >= 5)
{

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Você está de recuperação.");
}

else

{

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Infelizmente, você foi reprovado");

}
}
}

Console.ResetColor();
Console.WriteLine("Obrigada por testar nosso programa!");
