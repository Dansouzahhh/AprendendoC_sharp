using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL; /* HT= Horas trabalhadas / VH= Valor da Horas / PD= Percentual Desconto / SL= Salario Liquido */

            Console.Write("Horas trabalhas...........: "); /* Comando que você usa para exibir texto na tela, mas sem pular para a próxima linha após o texto */

            HT = float.Parse(Console.ReadLine()); 

            Console.Write("Valor da hora.............: ");

            VH = float.Parse(Console.ReadLine());

            Console.Write("Valor do percentual de desconto .: ");

            PD = float.Parse(Console.ReadLine());

            SB = HT * VH;
            TD = (PD / 100) * SB;
            SL = SB - TD;

            Console.WriteLine();
            Console.WriteLine("Salario liquido ...........: ");
            Console.WriteLine(SL.ToString("##,##0,00"));

            Console.WriteLine();
            Console.WriteLine("tecla <Enter> para encerrar... ");
            Console.ReadLine();
         

        }
    }
}
