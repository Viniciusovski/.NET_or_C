using System;
// Recursividade, função chama ela mesma
class Aula47{
    
    static void Main(){

        var res = fat(5);
        Console.WriteLine(res);

    } 

// 5! = 5*4*3*2*1
    public int fat(int n){
        int res;
        if(n<=1){
            res=1;
        }else{
            res = n * fat(n-1);
        }
        return res;
    }


}