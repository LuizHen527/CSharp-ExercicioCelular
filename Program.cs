// Criar classe Celular
// 	- Propriedades: cor, modelo, tamanho, ligado(booleano).
// 	- Metodos: ligar, desligar, fazer ligação, enviar mensagem.

// ---------------------------------------------------------

// No program

// Pedir para ligar

// Exibir menu com as funcoes do celular dentro de um do while

// Finalizar se ele usar a funcao desligar

using ExercicioCelular.Celular;

//OBJETOS

Celular phone1 = new Celular();

//VARIAVEIS

bool ligaDesliga;
bool loop = true;

//CODIGO

Console.WriteLine($"Precione qualquer tecla para ligar...");
Console.ReadLine();

ligaDesliga = phone1.ligar();

do
{
    Console.WriteLine($@"---------CELULAR----------
Digite '1' para fazer ligação;
       '2' para enviar mensagem;
       '0' para desligar");

string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    phone1.ligação();
    loop = true;
    break;

    case "2":
    phone1.mensagem();
    loop = true;
    break;

    case "0":
    phone1.desligar();
    loop = false;
    break;

    default:
    Console.WriteLine($"Digite uma opcao valida");
    loop = true;
    break;
}
} while (loop);