using System;

struct Carro{
    public string modelo;
    public string cor;

   public void info(){    
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor: {0}", this.cor);
        Console.WriteLine("--------------------------");
   }
}

class Aula45{
    
    static void Main(){

        int[] numeros = new int[10];

        Carro[] carros = new Carro[4];

        carros[0].modelo="HRV";
        carros[0].cor="Prata";

        carros[1].modelo="GOlf";
        carros[1].modelo="Azul";

        carros[2].modelo="Jetta";
        carros[2].modelo="Branco";

        carros[3].modelo="Argo";
        carros[3].modelo="Preto";

        for(int i = 0; i< carros.Length;i++){
            carros[i].info();
        }

        

    }

}