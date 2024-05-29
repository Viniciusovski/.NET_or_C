using System;
class Aula49{
    class Mat{
    public static double pi = 3.14;

    public static int dobro(int n){
        return n*2;
    }

    }

    
    static void Main(){

        double vpi = Mat.pi;
        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(10));

    } 


}