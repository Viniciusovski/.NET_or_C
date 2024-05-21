using System;

class Aula20{

    static void Main(){

        int[] numVetor = new int[10];

        int i = 0;
        while(i<10){
            Console.WriteLine("Vinicius");
            i++;
        }
        Console.WriteLine("Fim do loop");

        while(i<numVetor.Length){
            numVetor[i]=0;
            i++;
            Console.WriteLine(numVetor[i]);
        }
        Console.WriteLine("Fim do loop");

        int j = numVetor.Length-1 // 9 posições
        while(i>0){
            numVetor[i]=0;
            Console.WriteLine(numVetor[i]);
            i--;
        }
        Console.WriteLine("Fim do loop");

    }
}