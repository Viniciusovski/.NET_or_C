using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
}

class Aula44{
    
    static void Main(){
        
        Carro c1;
        c1.marca="VW";
        c1.modelo="Golf";
        c1.cor="Branco";

        Console.WriteLine("Marca: {0}", c1.marca);
        Console.WriteLine("Modelo: {0}", c1.modelo);
        Console.WriteLine("Cor: {0}", c1.cor);

        Carro c2 = new Carro("Honda", "HRV", "Prata");
        Console.WriteLine("Marca: {0}", c2.marca);
        Console.WriteLine("Modelo: {0}", c2.modelo);
        Console.WriteLine("Cor: {0}", c2.cor);

        

    }

}