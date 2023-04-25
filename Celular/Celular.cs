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
        }

        public void mensagem()
        {
            Console.WriteLine($"Enviando mensagem");
        }
    }
}