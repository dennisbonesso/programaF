using System;

namespace programaF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que escreve a letra F //
            int linha = 1;//inicializa linha com 1
            int coluna = 1;//inicializa coluna com 1

            while (coluna <= 6)//tamanho maximo da primeira coluna
            {

                if (coluna == 1)//entra na primeira linha 
                {
                    while (linha < 6)//escreve * 5 na linha
                    {
                        Console.Write("*");
                        linha++;
                    }

                }
                if (coluna == 4)//entra na 4 linha
                {
                    linha = 1;//reseta a linha
                    while (linha < 4)//escreve 4 * na linha
                    {
                        Console.Write("*");
                        linha++;
                    }


                }
                Console.WriteLine("");
                Console.Write("*");
                coluna++;//incrementa 

            }

        }
    }
}
