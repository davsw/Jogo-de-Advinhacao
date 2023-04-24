using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvinhacaoConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            int totalDeTentativas = 0;
            double pontuacao = 1000;
            int quantidadeChutes;
            // menu

            Console.WriteLine("*****************************************");
            Console.WriteLine("* Bem-vindo(a) ao Jogo da Adivinhação *");
            Console.WriteLine("*****************************************");

            Console.WriteLine("Escolha o nível de dificuldade: Fácil (1) Médio (2) Difícil (3)");
            int nivelDificuldade = Convert.ToInt32(Console.ReadLine());

           switch (nivelDificuldade)
            {
                case 1: totalDeTentativas = 15; 
                    break;
                case 2: totalDeTentativas = 10; 
                    break;
                case 3: totalDeTentativas = 5;
                    break;
            }
          

            // gerar número aleatório
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 21);

            for (quantidadeChutes = 1; quantidadeChutes <= totalDeTentativas; quantidadeChutes++)
            {
                Console.Clear();

                Console.WriteLine("Advinhe um número entra 1 e 20!");

                Console.WriteLine($"Tentativa {quantidadeChutes} de {totalDeTentativas}");

                // input 

                Console.WriteLine("Qual seu chute?");
                string chute = Console.ReadLine();

                int numeroChute = Convert.ToInt32(chute);

                // verificar se acertou ou não

                bool chuteCerto = numeroChute == numeroAleatorio;
                bool chuteMenor = numeroChute < numeroAleatorio;

                if (chuteCerto)
                {

                    Console.WriteLine("Parabéns! Você acertou.");
                    Console.WriteLine($"Você fez {pontuacao} pontos!");
                    break;

                }
                else if (numeroChute < numeroAleatorio)
                {

                    Console.WriteLine("Seu chute foi menor que o número aleatório.");
                }
                else
                {

                    Console.WriteLine("Seu chute foi maior que o número aleatório.");

                }

                // calcular pontos
                double pontosPerdidos = Math.Abs(numeroChute - numeroAleatorio) / 2;

                pontuacao = pontuacao - pontosPerdidos;

                Console.WriteLine($"Você fez um total de {pontuacao} pontos em no máximo {totalDeTentativas} tentativas!");
            }         
            Console.ReadLine();
           
        }
    } 
}