using System;

class Veiculo{ // Classe Base
    public int velMax;
    private bool ligado;
    public int rodas;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }

    public string getLigado(){
        return (ligado?"sim":"não"); // Uso do operador ternario

    }

    public int getRodas(){
        return rodas;
    }

    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas=0;
        }else if(rodas >40){
            this.rodas = 40;
        }else{
            this.rodas = rodas;
        }
        
    }
}

class Carro:Veiculo{ // Classe Derivada
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4){ // Construtor da classe base ':base()'
    desligar();
    rodas=4;
    velMax=120; 
    this.nome = nome;
    this.cor = cor;
}

}

// Cadeia de herança
class CarroCombate:Carro{
    public int municao;
    public CarroCombate():base("Carro de Combate", "Verde"){
        municao=100;
        setRodas(6);
    }
}

class Aula35{
    
    static void Main(){

        Carro c1 = new Carro("Katchau", "Vermelho");
        CarroCombate cc1 = new CarroCombate();

        c1.ligar();

        Console.WriteLine("Cor:{0}", c1.cor);
        Console.WriteLine("Nome:{0}", c1.nome);
        Console.WriteLine("Rodas:{0}", c1.getRodas());
        Console.WriteLine("VelMaxima:{0}", c1.velMax);
        Console.WriteLine("Ligado:{0}", c1.getLigado());

        Console.WriteLine("----------------");

        
        Console.WriteLine("Cor:{0}", cc1.cor);
        Console.WriteLine("Nome:{0}", cc1.nome);
        Console.WriteLine("Rodas:{0}", cc1.getRodas());
        Console.WriteLine("VelMaxima:{0}", cc1.velMax);
        Console.WriteLine("Ligado:{0}", cc1.getLigado());
        Console.WriteLine("Munção:{0}", cc1.municao);

    }

}