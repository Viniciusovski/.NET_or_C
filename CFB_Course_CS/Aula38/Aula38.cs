using System;

// Métodos virtuais são métodos que possuem o mesmo nome
// mas estão em classes diferentes que herdaram esse metodo
// Porém esse método vai executar uma ação diferente do pai

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe");
    }

    virtual public void info(){ // Esse metodo podera ser subscrito pelas classes filhas
        Console.WriteLine("Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada 1");
    }

       override public void info(){ // override indica que o metodo existe na classe base e está sendo subscrito
        Console.WriteLine("Derivada 1");
    }
    
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada 2");
    }

    override public void info(){
        Console.WriteLine("Derivada 2");
    }


}
class Aula38{
    
    static void Main(){
        Base Ref; // Ref, elemento de referencia que recebe as classes derivadas da base
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        Ref = derivada1;
        Ref.info();
    }

}