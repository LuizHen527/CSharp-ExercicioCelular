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
            Console.WriteLine($"Ligando para fulano...");
            Console.WriteLine($@"Ligação em andamento.
            Precione qualquer tecla para terminar chamada.");
            Console.ReadLine();
        }

        public void mensagem()
        {
            Console.WriteLine($"Enviar mensagem");
            Console.WriteLine($@"Precione qualquer tecla para terminar enviar a mensagem.");
            Console.ReadLine();
        }
    }
}