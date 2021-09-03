using System;
/* PROGRAMADOR: FABIANA CORDEIRO ROCHA
 * MATRÍCULA: 19209807
 * INSTITUIÇÃO: FATEC-SP
 */

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two-dimensional array ou matriz 3x3.
            string[,] array2D = new string[3, 3] { { " ", " ", " "}, { " ", " ", " "}, { " ", " ", " "} };

            // Accessando os elementos do array.
            System.Console.WriteLine("     0    1    2  ");
            System.Console.WriteLine("        ||    ||    ");
            System.Console.WriteLine(" 0   " + array2D[0, 0] + "  || " + array2D[0, 1] + "  || " + array2D[0, 2] + " ");
            System.Console.WriteLine("    ====||====||====");
            System.Console.WriteLine("        ||    ||    ");
            System.Console.WriteLine(" 1   " + array2D[1, 0] + "  || " + array2D[1, 1] + "  || " + array2D[1, 2] + " ");
            System.Console.WriteLine("    ====||====||====");
            System.Console.WriteLine("        ||    ||    ");
            System.Console.WriteLine(" 2   " + array2D[2, 0] + "  || " + array2D[2, 1] + "  || " + array2D[2, 2] + " ");

            //while 
            int n = 9;
            int i = 1;
            int jogador = 2;
            while (i <= n)
            {
                //Verificando se teve ganhador.
                if (array2D[0, 0] == "X" && array2D[0, 1] == "X" && array2D[0, 2] == "X")
                {
                    Console.WriteLine("JOGADOR 1 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[1, 0] == "X" && array2D[1, 1] == "X" && array2D[1, 2] == "X")
                {
                    Console.WriteLine("JOGADOR 1 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[2, 0] == "X" && array2D[2, 1] == "X" && array2D[2, 2] == "X")
                {
                    Console.WriteLine("JOGADOR 1 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 0] == "X" && array2D[1, 1] == "X" && array2D[2, 2] == "X")
                {
                    Console.WriteLine("JOGADOR 1 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 2] == "X" && array2D[1, 1] == "X" && array2D[2, 0] == "X")
                {
                    Console.WriteLine("JOGADOR 1 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 0] == "X" && array2D[1, 0] == "X" && array2D[2, 0] == "X")
                {
                    Console.WriteLine("JOGADOR 1 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 1] == "X" && array2D[1, 1] == "X" && array2D[2, 1] == "X")
                {
                    Console.WriteLine("JOGADOR 1 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 2] == "X" && array2D[1, 2] == "X" && array2D[2, 2] == "X")
                {
                    Console.WriteLine("JOGADOR 1 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 0] == "0" && array2D[0, 1] == "0" && array2D[0, 2] == "0")
                {
                    Console.WriteLine("JOGADOR 2 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[1, 0] == "0" && array2D[1, 1] == "0" && array2D[1, 2] == "0")
                {
                    Console.WriteLine("JOGADOR 2 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[2, 0] == "0" && array2D[2, 1] == "0" && array2D[2, 2] == "0")
                {
                    Console.WriteLine("JOGADOR 2 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 0] == "0" && array2D[1, 1] == "0" && array2D[2, 2] == "0")
                {
                    Console.WriteLine("JOGADOR 2 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 2] == "0" && array2D[1, 1] == "0" && array2D[2, 0] == "0")
                {
                    Console.WriteLine("JOGADOR 2 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 0] == "0" && array2D[1, 0] == "0" && array2D[2, 0] == "0")
                {
                    Console.WriteLine("JOGADOR 2 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 1] == "0" && array2D[1, 1] == "0" && array2D[2, 1] == "0")
                {
                    Console.WriteLine("JOGADOR 2 GANHOU!!Parabéns!"); break;
                }
                else if (array2D[0, 2] == "0" && array2D[1, 2] == "0" && array2D[2, 2] == "0")
                {
                    Console.WriteLine("JOGADOR 2 GANHOU!!Parabéns!"); break;
                }
                else
                {
                    if (jogador % 2 == 0)
                    {
                        // Jogador1 entrada de dado
                        int jog1L, jog1C;
                        do
                        {
                            Console.WriteLine("Jogador 1");
                            Console.WriteLine("Linha: ");
                            jog1L = int.Parse(Console.ReadLine());
                            Console.WriteLine("Coluna:");
                            jog1C = int.Parse(Console.ReadLine());
                        } while (jog1L < 0 || jog1L > 2 || jog1C < 0 || jog1C > 2);

                        if (array2D[jog1L, jog1C] == " ")
                        {
                            array2D[jog1L, jog1C] = "X";
                            i++;
                            // Accessando os elementos do array.
                            System.Console.WriteLine("     0    1    2  ");
                            System.Console.WriteLine("        ||    ||    ");
                            System.Console.WriteLine(" 0   " + array2D[0, 0] + "  || " + array2D[0, 1] + "  || " + array2D[0, 2] + " ");
                            System.Console.WriteLine("    ====||====||====");
                            System.Console.WriteLine("        ||    ||    ");
                            System.Console.WriteLine(" 1   " + array2D[1, 0] + "  || " + array2D[1, 1] + "  || " + array2D[1, 2] + " ");
                            System.Console.WriteLine("    ====||====||====");
                            System.Console.WriteLine("        ||    ||    ");
                            System.Console.WriteLine(" 2   " + array2D[2, 0] + "  || " + array2D[2, 1] + "  || " + array2D[2, 2] + " ");

                            jogador++;
                        }
                        else
                        {
                            Console.WriteLine("ESSA JÁ FOI!!Tente novamente.");
                            // Jogador1 entrada de dado
                            Console.WriteLine("Jogador 1");
                            Console.WriteLine("Linha: ");
                            jog1L = int.Parse(Console.ReadLine());
                            Console.WriteLine("Coluna:");
                            jog1C = int.Parse(Console.ReadLine());

                            if (array2D[jog1L, jog1C] == " ")
                            {
                                array2D[jog1L, jog1C] = "X";
                                i++;
                                // Accessando os elementos do array.
                                System.Console.WriteLine("     0    1    2  ");
                                System.Console.WriteLine("        ||    ||    ");
                                System.Console.WriteLine(" 0   " + array2D[0, 0] + "  || " + array2D[0, 1] + "  || " + array2D[0, 2] + " ");
                                System.Console.WriteLine("    ====||====||====");
                                System.Console.WriteLine("        ||    ||    ");
                                System.Console.WriteLine(" 1   " + array2D[1, 0] + "  || " + array2D[1, 1] + "  || " + array2D[1, 2] + " ");
                                System.Console.WriteLine("    ====||====||====");
                                System.Console.WriteLine("        ||    ||    ");
                                System.Console.WriteLine(" 2   " + array2D[2, 0] + "  || " + array2D[2, 1] + "  || " + array2D[2, 2] + " ");

                                jogador++;
                            }
                            else
                            {
                                Console.WriteLine("PERDEU A VEZ!");
                                jogador++;
                            }

                        }
                    }
                    else
                    {
                        int jog2L, jog2C;
                        // Jogador2 entrada de dado
                        Console.WriteLine("Jogador 2");
                        Console.WriteLine("Linha: ");
                        jog2L = int.Parse(Console.ReadLine());
                        Console.WriteLine("Coluna:");
                        jog2C = int.Parse(Console.ReadLine());

                        if (array2D[jog2L, jog2C] == " ")
                        {
                            array2D[jog2L, jog2C] = "0";
                            i++;
                            // Accessando os elementos do array.
                            System.Console.WriteLine("     0    1    2  ");
                            System.Console.WriteLine("        ||    ||    ");
                            System.Console.WriteLine(" 0   " + array2D[0, 0] + "  || " + array2D[0, 1] + "  || " + array2D[0, 2] + " ");
                            System.Console.WriteLine("    ====||====||====");
                            System.Console.WriteLine("        ||    ||    ");
                            System.Console.WriteLine(" 1   " + array2D[1, 0] + "  || " + array2D[1, 1] + "  || " + array2D[1, 2] + " ");
                            System.Console.WriteLine("    ====||====||====");
                            System.Console.WriteLine("        ||    ||    ");
                            System.Console.WriteLine(" 2   " + array2D[2, 0] + "  || " + array2D[2, 1] + "  || " + array2D[2, 2] + " ");

                            jogador++;
                        }
                        else
                        {
                            Console.WriteLine("ESSA JÁ FOI!!Tente novamente.");
                            // Jogador2 entrada de dado
                            Console.WriteLine("Jogador 2");
                            Console.WriteLine("Linha: ");
                            jog2L = int.Parse(Console.ReadLine());
                            Console.WriteLine("Coluna:");
                            jog2C = int.Parse(Console.ReadLine());

                            if (array2D[jog2L, jog2C] == " ")
                            {
                                array2D[jog2L, jog2C] = "0";
                                i++;
                                // Accessando os elementos do array.
                                System.Console.WriteLine("     0    1    2  ");
                                System.Console.WriteLine("        ||    ||    ");
                                System.Console.WriteLine(" 0   " + array2D[0, 0] + "  || " + array2D[0, 1] + "  || " + array2D[0, 2] + " ");
                                System.Console.WriteLine("    ====||====||====");
                                System.Console.WriteLine("        ||    ||    ");
                                System.Console.WriteLine(" 1   " + array2D[1, 0] + "  || " + array2D[1, 1] + "  || " + array2D[1, 2] + " ");
                                System.Console.WriteLine("    ====||====||====");
                                System.Console.WriteLine("        ||    ||    ");
                                System.Console.WriteLine(" 2   " + array2D[2, 0] + "  || " + array2D[2, 1] + "  || " + array2D[2, 2] + " ");

                                jogador++;
                            }
                            else
                            {
                                Console.WriteLine("PERDEU A VEZ!");
                                jogador++;
                            }

                        }

                    }
                }
            }

        }
    }
}