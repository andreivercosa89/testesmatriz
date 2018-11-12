using System;

namespace testesmatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, lmaior=0, cmaior=0;
            int[,] matriz = new int[3, 3];
            for (int linha = 0; linha < 3;linha++){
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("Informe um valor para a Linha {0} e coluna {1}: ", linha, coluna);
                    matriz[linha,coluna] = Convert.ToInt32(Console.ReadLine());
                    if(matriz[linha,coluna]> maior){
                        maior = matriz[linha, coluna];
                        lmaior = linha;
                        cmaior = coluna;
                    }
                }
                Console.WriteLine("Na linha {0} 0 maior numero eh {1}", linha, maior);
            }
            Console.WriteLine("O maior numero eh {0} e esta na Linha {1} e na Coluna {2} ",maior,lmaior,cmaior);
        }
    }
}
