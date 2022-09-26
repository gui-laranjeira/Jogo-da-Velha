using System;

namespace Challenge
{
    internal class Program
    {
        //TO DO:
        //arrumar o Verificador() que não conclui o jogo
        //Inserir um método de impedir que um jogador escolha uma casa que já tenha sido escolhida na partida



        static string[,] tabuleiro = 
        {
            {"1","2","3"},
            {"4","5","6"},        //array 2 dimensões para armazenar as informações de cada casa do tabuleiro
            {"7","8","9"}         //Vou usar um método embaixo para representar os dados desse tabuleiro no console, e esse método vai atualizando
        };                           
        static void Main(string[] args)
        {
            string jogador1 = "X";
            string jogador2 = "O";

            //Verificador com problema, quando alguem vence o jogo continua
            bool checker = Verificador(tabuleiro);      //vai checar se o jogo terminou, caso não tenha terminado o jogo continua
            TabuleiroDinamico();



            while (!checker)
            {
                //JOGADOR 1
                Console.WriteLine("Jogador 1 '{0}', onde quer jogar? (Insira um número de 1 a 9)", jogador1);
                string resposta1 = Console.ReadLine();
                bool convert1 = int.TryParse(resposta1, out int respostaInt1);
                if (convert1) //checar se o input do jogador é um número
                {
                    if (respostaInt1 >= 1 && respostaInt1 <= 9) //checar se é um número válido de 1 a 9
                    {
                        switch (respostaInt1)    //inserir o "X" no tabuleiro no local selecionado
                        {
                            case 1:
                                tabuleiro[0, 0] = jogador1;
                                break;
                            case 2:
                                tabuleiro[0, 1] = jogador1;
                                break;
                            case 3:
                                tabuleiro[0, 2] = jogador1;
                                break;
                            case 4:
                                tabuleiro[1, 0] = jogador1;
                                break;
                            case 5:
                                tabuleiro[1, 1] = jogador1;
                                break;
                            case 6:
                                tabuleiro[1, 2] = jogador1;
                                break;
                            case 7:
                                tabuleiro[2, 0] = jogador1;
                                break;
                            case 8:
                                tabuleiro[2, 1] = jogador1;
                                break;
                            case 9:
                                tabuleiro[2, 2] = jogador1;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira um número válido de 1 a 9!");
                    }
                    Console.Clear();
                    TabuleiroDinamico();      //Limpar o console e reinserir o tabuleiro, agora com a jogada atualizada
                } 
                else
                {
                    Console.WriteLine("Por favor, insira um número válido");
                }


                //JOGADOR 2
                Console.WriteLine("Jogador 2 '{0}', onde quer jogar? (Insira um número de 1 a 9)", jogador2);
                string resposta2 = Console.ReadLine();
                bool convert2 = int.TryParse(resposta2, out int respostaInt2);
                if (convert2)
                {
                    if (respostaInt2 >= 1 && respostaInt2 <= 9) //checar se é um número válido de 1 a 9
                    {
                        switch (respostaInt2)    //inserir o "O" no tabuleiro no local selecionado
                        {
                            case 1:
                                tabuleiro[0, 0] = jogador2;
                                break;
                            case 2:
                                tabuleiro[0, 1] = jogador2;
                                break;
                            case 3:
                                tabuleiro[0, 2] = jogador2;
                                break;
                            case 4:
                                tabuleiro[1, 0] = jogador2;
                                break;
                            case 5:
                                tabuleiro[1, 1] = jogador2;
                                break;
                            case 6:
                                tabuleiro[1, 2] = jogador2;
                                break;
                            case 7:
                                tabuleiro[2, 0] = jogador2;
                                break;
                            case 8:
                                tabuleiro[2, 1] = jogador2;
                                break;
                            case 9:
                                tabuleiro[2, 2] = jogador2;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira um número válido de 1 a 9!");
                    }
                    Console.Clear();
                    TabuleiroDinamico();
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido");
                }
            }
            Console.WriteLine("Fim de jogo!");
            
        }                

        public static void TabuleiroDinamico()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", tabuleiro[0, 0], tabuleiro[0, 1], tabuleiro[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", tabuleiro[1, 0], tabuleiro[1, 1], tabuleiro[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", tabuleiro[2, 0], tabuleiro[2, 1], tabuleiro[2, 2]);
        }


        private static bool Verificador(string[,] tabuleiro)
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                    return true;
                if (tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i])
                    return true;
            }
            if (tabuleiro[0,0] == tabuleiro[1,1] && tabuleiro[1,1] == tabuleiro[2, 2])
            {
                return true;
            }
            if (tabuleiro[2,0] == tabuleiro[1,1] && tabuleiro[1,1] == tabuleiro[0, 2])
            {
                return true;
            }
            return false;
        }
    }    
}


