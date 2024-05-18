using System;

class Aula17{

    static void Main(){

        int[] n = new int[5]; // Uma das formas de declarar array
        int[] num = new int[3]{55,77,99}; // Declarar e já popular com valores
        int[] num2 = {55, 77, 99}; // Declarar e popular sem o new
        // Tem que respeitar o tamanho do array quando declarado

        n[0]=11;
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;

        Console.WriteLine(n[0]);

    }
}