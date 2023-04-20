namespace JogodaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];
            int num = 1;
            string periodos = "X";
            int tentativas = 1;
            bool jogarnovamente = true;
            List<string> numtentativas = new List<string>();

            Console.WriteLine("********************");
            Console.WriteLine("    Jogo da Velha   ");
            Console.WriteLine("********************");
            Console.WriteLine();

            //Estrutura da matriz



            while (jogarnovamente)

            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matriz[i, j] = num.ToString();
                        Console.Write($"[{matriz[i, j]}]    ");
                        numtentativas.Add(num.ToString());
                        num++;
                    }
                    Console.WriteLine();

                }




                Console.WriteLine();
                Console.WriteLine($"Inicie o jogo clicando em um numero para iniciar com [{periodos}]");
                string jogadas = Console.ReadLine();
                Console.Clear();

                while (tentativas < 9)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine("    Jogo da Velha   ");
                    Console.WriteLine("********************");
                    Console.WriteLine();

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (matriz[i, j] == jogadas && numtentativas.Contains(jogadas))

                            {
                                matriz[i, j] = periodos;
                                numtentativas.Remove(jogadas);
                            }

                        }

                    }





                    for (int i = 0; i < 3; i++)

                    {
                        for (int j = 0; j < 3; j++)

                        {
                            Console.Write($"[{matriz[i, j]}]  ");

                        }

                        Console.WriteLine();
                    }
                    // Condição de vitoria
                    if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] || matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])

                    {

                        Console.WriteLine();
                        Console.WriteLine("     VITÓRIA!!!      ");
                        Console.WriteLine($" Parabens o {periodos} é o vencedor do jogo!");
                        break;
                    }


                    if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] || matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                         matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])

                    {

                        Console.WriteLine();
                        Console.WriteLine("    VITÓRIA!!!      ");
                        Console.WriteLine($" Parabens o {periodos} é o vencedor do jogo!");
                        break;
                    }


                    if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] || matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                         matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])

                    {

                        Console.WriteLine();
                        Console.WriteLine("     VITÓRIA!!!      ");
                        Console.WriteLine($" Parabens o {periodos} é o vencedor do jogo!");
                        break;
                    }






                    // Troca de jogador

                    if (periodos == "X")

                    {

                        periodos = "O";

                    }

                    else

                    {
                        periodos = "X";

                    }

                    Console.WriteLine($"Proxima jogada com [{periodos}]");
                    jogadas = Console.ReadLine();


                    // Numero digitado repetido
                    while (!numtentativas.Contains(jogadas))

                    {
                        Console.WriteLine("Valor não aceito. Jogue novamente:");
                        jogadas = Console.ReadLine();


                    }

                    tentativas++;


                    Console.Clear();




                }


                if (tentativas == 9)

                {

                    Console.WriteLine("    EMPATE!!!      ");

                }







                Console.WriteLine($"Deseja jogar novamente: s ou n ?");
                string resposta = Console.ReadLine();






                if (resposta == "n")
                {
                    jogarnovamente = false;
                }

                else

                {
                    Console.Clear();
                    tentativas = 1;

                }

            }
        }
    }
 }