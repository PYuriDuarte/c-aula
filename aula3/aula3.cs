using System;

class Aula3{
  static void Main(){
    // variavel primitiva depois nome e depois uma atribuição    
    int num = 0; // int pode receber valores negativos ou positivos  tem 32bits de dados
    byte n1 = 10; // byte vai de 0 a 255
    char letra = 'c'; // char representa um único caractere (letras ou numeros) Unicode
    bool verd = true; // bool representa valores booleanos verdadeiro ou falso
    float valor = 5.3f; // float representa números com ponto flutuante de precisão simples

    string nome = "teste";

    int num1, num2, num3;

    num1 = 10;
    num2 = 5;
    num3 = num1 * num2;

    var aux = "teste";

    Console.WriteLine("valor de num3 é:" + num3 + "!");
    Console.WriteLine("valor de num1 é {num1}, de num2 é {num2} e a multiplicação deles é {num3}.");
  }
}