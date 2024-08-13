using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R; /* Variavel INT = Inteiro */

            Console.WriteLine("entre o 1o valor: ");

            A = int.Parse(Console.ReadLine()); /*  são usados para converter uma string em um valor de um tipo primitivo  */

            Console.WriteLine("Entre o 2o. valor "); /*  O console no C# é uma interface que permite a interação entre o usuário e o programa através de texto */
            B = int.Parse(Console.ReadLine()); /* Ele ira converte Texto em Números inteiros */

            R = A = B; /* Atribuição em Cadeia */ 

            Console.WriteLine();
            Console.WriteLine("resultado = " + R); 
            
            Console.WriteLine();
            Console.Write("Tecla <Enter> para continuar... "); /* O Console.Write é usado para escrever texto no console sem pular para a próxima linha */

            Console.ReadLine(); /* O Console.ReadLine() é uma maneira de ler o que o usuário digita no console */

        }
    }
}
