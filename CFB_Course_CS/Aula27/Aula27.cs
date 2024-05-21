using System;

class Aula27{
    // Parametros multiplos
    static void Main(){
        soma(52,45,1);

    }

    static void soma(params int[]n){
        int res=0;

        if(n.Length < 1){
            Console.WriteLine("Não existem valores a serem somados");
        }else if(n.Length <2){
            Console.WriteLine("Valores insuficientes para soma: {0}",n[0]);
        }else{
            for(int i =0; i<n.Length;i++){
                res+=n[i];
            }
            Console.WriteLine("A dos valores é: {0}",res);
        }

        
    }




}