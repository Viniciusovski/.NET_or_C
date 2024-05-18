using System;

class Aula11{

    static void Main(){
        int n1 = 10;
        float n2=n1;
        Console.Write(n2); // Sem problemas, converte implicitamente

        float n3=10.5f;
        int n4 = n3;
        Console.Write(n4); // Não é possivel converter float em int

        float n5=10.5f;
        int n6 = (int)n5; // Type Cast
        Console.Write(n6);

    }
}