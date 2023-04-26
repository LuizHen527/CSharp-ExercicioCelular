using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioCelular.Celular
{
    public class Celular
    {
        string cor;
        string modelo;
        string tamanho;

        public bool ligar()
        {
            Console.WriteLine($"Ligando...");
            return true;
        }

        public void desligar()
        {
            Console.WriteLine($"O celular foi desligado");
        }

        public void ligação()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Ligando para fulano");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");

            Console.ResetColor();

            Console.WriteLine($"");
            Thread.Sleep(3000);
            Console.WriteLine($@"Ligação em andamento.
Precione qualquer tecla para terminar chamada.");
            Console.ReadLine();
        }

        public void mensagem()
        {
            
            
            Console.WriteLine($@"Precione qualquer tecla para enviar mensagem para fulano.");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Enviando mensagem");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");

            Console.ResetColor();

            Console.WriteLine($"");
            Thread.Sleep(3000);
        }
    }
}