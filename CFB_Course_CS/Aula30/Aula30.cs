using System;

public class Jogador{ // sem modifacador a classe é public
    public int energia;
    public bool vivo;

    public string nome;

    public Jogador(){
        energia=100;
        vivo=true;
        nome="Jogador";
    }

    public Jogador(string n){
        energia=100;
        vivo=true;
        nome=n;
    }

    public Jogador(string n, int e){
        energia=e;
        vivo=true;
        nome=n;
    }

    public Jogador(string n, int e, bool v){
        energia=e;
        vivo=v;
        nome=n;
    }

    public void info(){
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energia);
        Console.WriteLine("Estado jogador: {0}\n", true);
    }

}

class Aula30{
    
    static void Main(){
        string nome;
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Wesley");
        Jogador j3 = new Jogador("Endrick",100);
        Jogador j4 = new Jogador("Zidane",30,true);
        Jogador j5 = new Jogador("Pelé",0,false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
        j5.info();


    }

}