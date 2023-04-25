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

//CODIGO

Console.WriteLine($"Precione qualquer tecla para ligar...");
string opcao = Console.ReadLine();

phone1.ligar();

Console.WriteLine($"");
