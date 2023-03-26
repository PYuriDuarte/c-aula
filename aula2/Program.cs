// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//C# padrão .NET
using System;

namespace Aula2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Aula 2!");
      if(args.GetLength(0)>0){
        Console.Write(args.GetValue(0));
      }
    }
  }
}