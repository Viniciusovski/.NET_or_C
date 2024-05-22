using System;

static class Jogador{ // classe static não pode ter construtor todas as propriedade devem ser static
    static public int energia;
    static public bool vivo;

    static public string nome;


    static public void iniciar(string n){
        energia=100;
        vivo=true;
        nome=n;
    }

    static public void info(){
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energia);
        Console.WriteLine("Estado jogador: {0}\n", true);
    }

}

class Inimigo{
    static public bool alerta;
    public string nome;

    public Inimigo(string n){
        alerta=false;
        nome=n;
    }

    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("--------------------");
    }
}

class Aula31{
    
    static void Main(){
        // Classe static não permite instanciações
        Jogador.iniciar("Bruno");
        Jogador.info;

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta=true; // Fez todos os objetos mudar o alerta para true

        i1.info();
        i2.info();
        i3.info();


    }

}