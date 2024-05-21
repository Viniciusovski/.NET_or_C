using System;

class Aula25{

    // Passagem por referencia

    static void Main(){
        int num=10;
        dobrar(ref num);
        Console.WriteLine(num);
        // Por causa do 'ref' a variavel num vai ser alterada no console
    }

    static void dobrar(ref int valor){
        valor*=2;
    }
}