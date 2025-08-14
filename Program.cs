using System;
class Program
{
    static void Main(string[] arge)
    {
        decimal salarioAtual = 1500m;
        decimal percentualDeAumento = 10m;
        decimal novoSalario = salarioAtual + (salarioAtual * percentualDeAumento / 100);

        Console.WriteLine("O novo salário é de R$" + novoSalario.ToString("F2")); 


    }
}