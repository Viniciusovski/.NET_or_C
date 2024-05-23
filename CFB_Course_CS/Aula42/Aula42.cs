using System;

//Indexador permitea classe ser usada como um array
class Carro{
    private int[] velMax = new int[5]{80,120,160,240,300};
    private int velMax;
    public Carro(){
        
    }

   public int this[int i]{
    get{
        return velMax[i];
    }
    set{
        if(value < 0){
            velMax[i]=0;
        }else if(value>300){
            velMax[i]=300;
        }else{
            velMax[i]=value;
        }
    }
   }
}

class Aula42{
    
    static void Main(){
        Carro c1 = new Carro();
        
        c1[4]=200;
        Console.WriteLine("Velocidade:{0}", c1[4]);

    }

}