using System;

namespace testesmatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int[,] matriz = new int[3, 3];
            string texto="";
            for (int linha = 0; linha < 3;linha++){
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("Informe um valor para a Linha {0} e coluna {1}: ", linha, coluna);
                    matriz[linha,coluna] = Convert.ToInt32(Console.ReadLine());
                    if(matriz[linha,coluna]> maior){
                        maior = matriz[linha, coluna];
                        texto = "O maior numero eh " + maior + " e esta na Linha " + linha + " e Coluna " + coluna;
                    }
                }
                Console.WriteLine("na linha " + linha +": "+ texto);
            }
            Console.WriteLine(texto);
        }
    }
}
