using System;

class Aula19{

    static void Main(){
        
        for(int num=0;num<10;num++){
            Console.WriteLine("Valor de num: {0}", num);
            Console.WriteLine("Vinicius");

        }

        int[] numVetor = new int[10];

        for(int i=0; i<10;i++){
            numVetor[i] = 0;
            Console.WriteLine(numVetor[i]);
        }

        for(int i=0; i<numVetor.Length;i++){
            numVetor[i] = i;
            Console.WriteLine(numVetor[i]);
        }

    }
}