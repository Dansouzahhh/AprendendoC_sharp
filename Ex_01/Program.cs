using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01 /* Nome do Projeto "Espaço" */
{
    internal class Program /* Classe interna */
    {
        static void Main(string[] args)  /* Ponto de entrada */
        {
            string NOME; /* String seria um Literal  */

            Console.WriteLine("entre seu nome: "); 
            NOME = Console.ReadLine(); 
            Console.WriteLine("Ola, " + NOME); /* Ele escrevera sem quebarar a linha e Mostrara o OLa com o Nome digitado  */

            Console.WriteLine(); /* Escrever Sem Quebrar Linha */
            Console.WriteLine("Tecle <Enter> para encerrar... ");
            Console.ReadLine();  /* O Console.ReadLine() é uma maneira de ler o que o usuário digita no console */

        }
    }
}
