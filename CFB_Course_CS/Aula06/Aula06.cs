using System;

class Aula06{
    
    static void Main(){
      int 1,n2,n3
      n1 = 10, n2 = 20, n3 = 30;

      Console.Write("n1={0}, n2={1}, n3={2}", n1,n2,n3); // indexação
      Console.Write("n1={0},\n n2={1},\n n3={2}\n", n1,n2,n3); // \n = Enter
      Console.Write("n1=\t{0},\n n2=\t{1},\n n3=\t{2}\n", n1,n2,n3); // \t = Tabulação

      double valorCompra=5.50;
      double valorVenda;
      double lucro=0.1;
      string produto = "Pastel";

      valorVenda=valorCompra+(valorCompra*lucro);

      Console.WriteLine("Pruduto.........:{0,15}", produto); // O 0 é o indice e o 15 o espaçamento
      Console.WriteLine("Val.Compra.......{0,15:c}", valorCompra); // :c valor monetário
      Console.WriteLine("Lucro...........:{0,15:p}", lucro) // :p porcentagem
      Console.WriteLine("Val.Venda.........:{0,15:p}", valorVenda)

    }
}