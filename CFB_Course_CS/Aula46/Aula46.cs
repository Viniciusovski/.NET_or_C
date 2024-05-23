using System;
class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha=nomeGalinha;
        numOvo=0;
    }

    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
}

class Ovo{
    public Ovo(){
        Console.WriteLine("Ovo criado");
    }
}
class Aula46{
    
    static void Main(){
        Galinha g1=new Galinha("Bene");
        Galinha g2=new Galinha("Feliz");
        Galinha g3=new Galinha("Maris");

        g1.botar();
        g1.botar();
        g1.botar();
        g2.botar();
        g3.botar();        


}

}