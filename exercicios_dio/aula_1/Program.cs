using System;

namespace aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio I
        int[] contador = new int[3];
        // Array ->  responsavel por armazenar o valor digitado pelo usuario 
        int resposta_usuario = 0;

            do
            // estrutura de repetição 
            {
                
                resposta_usuario  = Convert.ToInt32(Console.ReadLine());
                // o convert toInt32 converte os dados do console de string para inteiro  *_* 
                // outro conversor: tipo.Parse (ex: int.Parse)
                switch (resposta_usuario)  // VARIAVEL -> A PARTI DO VALOR DA VARIAVEL UM DOS CASES SERÁ EXECUTADO 
                {
                    case 1:
                    contador[0]++;
                    break;
                     
                    case 2:
                    contador[1]++;
                    break;
                      
                    case 3:
                    contador[2]++;
                    break;
                        
                    case 4:
                   
                    break;
                    default:                    
                        continue;
                }
            }
       
        while (resposta_usuario != 4 );
        // condição de verificação 
        // quando a resposta do usuario for  == 4, os WriteLines serão executados!
         
        System.Console.WriteLine("MUITO OBRIGADO");

        System.Console.WriteLine("Alcool: " + contador[0]);
        // o contador vai informar quantas vezes o usuario digitou determinada variavel
        // usamos o nome do array + a posiçao do elemento desejado 

        System.Console.WriteLine("Gasolina: " + contador[1]);

        System.Console.WriteLine("Diesel: " + contador[2]);

   }
        }
        
    }

