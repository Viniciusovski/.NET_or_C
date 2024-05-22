using System;

class Veiculo{ // Base
    public int velAtual;
    private int velMax;
    protected bool ligado; // Posso acessar pela classe e pelas derivadas mas não dos objetos

    public Veiculo(int velMax){
        velAtual=0;
        this.velMax;
        ligado = false;
    }

    public bool getLigado(){
        return ligado;
    }

    public int getVelMax(){
        return velMax;
    }
}

class Carro:Veiculo{
    public string nome;

    public Carro(string nome, int vm):base(vm){// O segundo parametro esta sendo usado no construtor da classe base
        this.nome=nome;
        ligado=true; // protected
    }


}

class Aula36{
    
    static void Main(){

        Carro carro = new Carro("Bonitão",120);
        Console.WriteLine("Nome: {0}", carro.nome);
        Console.WriteLine("Vel.Maxima: {0}", carro.getVelMax());
        Console.WriteLine("Ligado?: {0}", carro.getLigado());


    }

}