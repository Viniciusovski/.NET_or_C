using System;

class Aula24{

    static void Main(){

       ola();
       soma(10,5);
       int r =  soma(78,3);
       Console.WriteLine(r);
    }

    static void ola(){
        Console.WriteLine("Olá, Vinícius");
        Console.WriteLine("Curso de C#");
        Console.WriteLine("youtube.com/cfbcursos");
    }

    static void somaVoid(int n1, int n2){
        int res = n1+n2;
        Console.WriteLine("A soma de {0} e {1} é {2}", n1, n2, res);
    }

    static int soma(int n1, int n2){
        int res = n1+n2;
        return res;
    }
}