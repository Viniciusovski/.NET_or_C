using System;

class Aula10{
    enum DiasSemana{Domingo, Segunda, Terça, Qaurta, Quinta, Sexta, Sábado};

    static void Main(){
        DiasSemana ds = DiasSemana.Domingo;

        Console.WriteLine(ds);

        // Casting para pegar a posição a partir do index, pois não faz direto por int
        ds = (DiasSemana)3;

        // Não é possivel converter enumerador para int
        int dsInt =(int)DiasSemana.Sexta;
    }
}