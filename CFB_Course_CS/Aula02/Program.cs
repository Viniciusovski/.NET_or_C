using System;

namespace Aula02{
     class Program{
        static void Main(string[] args){
        // dotnet new console cria projeto .net
        // dotnet build faz a compilação
        // dotnet run faz a execução
        // csc [nome do arquivo.cs] compila e executa
        Console.WriteLine("Hello, World!");
        if(args.GetLength(0)>0){
            Console.Write(args.GetValue(0));
        }
        }
                
    }
}
