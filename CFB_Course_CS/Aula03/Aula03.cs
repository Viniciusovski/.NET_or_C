using System;

class Aula03{
    static void Main(){
        byte n1 = 10 // 0 a 255
        int num = -10;
        char letra = 'c'
        float valor = 5.3f;
        string nome = "Vinicius";
        bool = true;

        var aux = 10; // O tipo é determinado na atribuição e declaração

        // Ler variavel
        Console.WriteLine(aux);
        Console.WriteLine("Valor da variavel: " + aux + "...");
        // Declaração de multiplas variaveis
        int num1, num2, res;

        num1 = 10;
        num2 = 2;
        res = num1 + num2;
        Console.WriteLine("A soma de " + num1 + " mais " + num2 + " é igual a: " + res);
        Console.WriteLine("A soma de " + num1 + " mais " + num2 + " é igual a: " + num1 + num2);
        
    }
}