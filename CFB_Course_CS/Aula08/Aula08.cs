using System;

class Aula08{
    
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        // Ler valor do teclado
        nome=Console.ReadLine();
        Console.WriteLine("Nome digitado: {0}",nome);
        // Os valores lidos retornam como string nesse caso é preciso converter
        Console.Write("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine());
        soma = v1+v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1,v2,soma);
    }
}