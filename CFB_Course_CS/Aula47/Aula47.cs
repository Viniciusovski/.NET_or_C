using System;

class Calc{
    public int soma(int n1, int n2){
        return n1+n2;
    }

    public double soma(double n1, double n2){
        return n1+n2;
    }

}
class Aula47{
    
    static void Main(){       

        Calc calc = new Calc();

        var res=calc.soma(10,5,4);

        Console.WriteLine(res);

        
    }       


}