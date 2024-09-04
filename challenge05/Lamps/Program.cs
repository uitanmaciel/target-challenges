/*Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes.
 Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. 
 Seu objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, 
 usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada? */

using Lamps.Enums;
using Lamps.Models;

// Criando as lâmpadas
var lampA = new Lamp("Lâmpada A", false, TemperatureState.Cold);
var lampB = new Lamp("Lâmpada B", false, TemperatureState.Cold);
var lampC = new Lamp("Lâmpada C", false, TemperatureState.Cold);

// Criando os interruptores
var switchA = new Switch("Interruptor A", lampA);
var switchB = new Switch("Interruptor B", lampB);
var switchC = new Switch("Interruptor C", lampC);

// Ligando a lâmpada A por um tempo
switchA.On();
System.Threading.Thread.Sleep(1000); // Simulando o tempo de aquecimento da lâmpada

// Desligando a lâmpada A e ligando a lâmpada B
switchA.Off();
switchB.On();

// Entrando na sala das lâmpadas
Console.WriteLine("\nIndo para a sala das lâmpadas...");

// Verificando o estado das lâmpadas
lampA.Display();
lampB.Display();
lampC.Display();

// Saída
Console.WriteLine("\n Resultados:");
Console.WriteLine($"O interruptor A controla a lâmpada {lampA.Name}");
Console.WriteLine($"O interruptor B controla a lâmpada {lampB.Name}");
Console.WriteLine($"O interruptor C controla a lâmpada {lampC.Name}");