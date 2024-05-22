using System;

public class Jogador{ // sem modifacador a classe é public
    public int energia;
    public bool vivo;

    public string nome;

    // Método construtor
    public Jogador(string n){
        energia=100;
        vivo=true;
        nome=n;
    }

    // Método Destrutor
    ~Jogador(){
        Console.WriteLine("Jogador foi destruido");
    }

}

class Aula29{
    
    static void Main(){
        string nome;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome = Console.ReadLine();
        Jogador j1 = new Jogador("Messi");
        Jogador j2 = new Jogador("Wesley");
        Jogador j3 = new Jogador("Endrick");
        Jogador j4 = new Jogador(nome);


        Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
        Console.WriteLine("Nome do jogador 2: {0}", j4.nome);
    }

}