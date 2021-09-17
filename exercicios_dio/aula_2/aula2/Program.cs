using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] s = Console.ReadLine().Split(' ');
        // split -> vai separar os elementos digitado pelos espaços em branco que tiver entre eles 
        
 
        double[] lados = Array.ConvertAll(s, Double.Parse);
        // ConvertAll irá converter o array de string para double
 
        Array.Sort(lados);
        //irá ordenar o arrey lados
                            
        // Para pegar os elementos de em ordem decrescente, iremos pega-lós de trás para frente
        double a = lados[2];
        double b = lados[1];
        double c = lados[0];
 
        //continue a solucao
        if (a >= b + c)
            Console.WriteLine("NAO FORMA TRIANGULO");
        else if (a * a == b * b + c * c)
            Console.WriteLine("TRIANGULO RETANGULO");
        else if (a * a > b * b + c * c)
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        else if (a * a < b * b + c * c)
            Console.WriteLine("TRIANGULO ACUTANGULO");
        if (a == b && b == c)
            Console.WriteLine("TRIANGULO EQUILATERO");
        if ((a == b && a != c && b != c) ||
        (c == b && c != a && b != a) ||
        (b == c && b != a && a != c))
            Console.WriteLine("TRIANGULO ISOSCELES");
 
        Console.ReadLine();
    }
}
        }
