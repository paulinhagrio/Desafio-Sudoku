using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduko
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[9, 9];

            for (int i = 0; i < 9; i++)                         //  Define que os valores das linhas não podem ser acima de 9;
            {
                for (int j = 0; j < 9; j++)                     //  Define que os valores das colunas não podem ser acima de 9;
                {
                    matriz[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }




            int checkLinhas, (int matriz[9][9]);
                
                int i, j, k, x = 1;

            for (i = 0; i < 9 && x; i++)      // Percorre as linhas da matriz;
            {
                for (j = 0; j < 9 && x; j++)     // Comparam valores que ocupam a mesma linha;
                {
                    for (k = 0; k < 9 && x; k++)
                    {
                        if ((j != k) && (matriz[i][j] == matriz[i][k]))
                        {
                            return x;               // Se retornar x = 0, a regra do Soduko foi quebrada 
                        }
                    }

                }
            }
        }
            


            int checkColunas(int matriz[9][9]){

                int i, j, k, x = 1;

                for (j = 0; j < 9 && x; j++)      // Percorre as colunas da matriz;
                {
                    for (i = 0; i < 9 && x; i++)     // Comparam valores que ocupam a mesma coluna;
                    {
                        for (k = 0; k < 9 && x; k++)
                        {
                            if ((i != k) && (matriz[i][j] == matriz[k][j]))
                            {
                                return x;               // Se retornar x = 0, a regra do Soduko foi quebrada 
                            }
                        }
                    }
                }
            }



            int checkMenor(int mini[3][3]){        // Vai checar uma parte menor da matriz (3x3) para verificar se há numeros repetidos

                int i, j, num, existe = 0;


                for (num = 1; num <= 9; num++)     // Aqui percorre por toda a matriz;
                {
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (mini[i][j] == num) existe++;
                            {
                                if (existe > 1) return 0;     //  Se a variavel existe for maior que 1 (se algum numero "num" se repete na linha/coluna 3x3, retorna inválido)
                                existe = 0;
                            }
                            return 1;
                        }

                    }
                }


                int matriz[9][9];                            // Após a criaçao da matriz, é feito o check se a matriz é ou não um sudoku.
                criaMatriz(matriz);

                if (checkLinhas(matriz) && checkColunas(matriz) && checkMenor(matriz))
                {
                    Console.WriteLine("A matriz criada forma um sudoku. Parabéns");
                }
                else
                {
                    Console.WriteLine("A matriz criada não forma um sudoku");
                }


            }
        }
    }
}
