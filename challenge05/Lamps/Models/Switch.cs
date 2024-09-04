using Lamps.Enums;

namespace Lamps.Models;

public sealed class Switch()
{
    public string Name { get; set; } = null!;
    public Lamp Lamp { get; set; } = null!;

    public Switch(string name, Lamp lamp) : this()
    {
        Name = name;
        Lamp = lamp;
    }

    public void On()
    {
        Lamp.IsOn = true;
        Lamp.Temperature = TemperatureState.Hot;
        Console.WriteLine($"{Name} ligado. {Lamp.Name} está ligada.");
    }

    public void Off()
    {
        Lamp.IsOn = false;
        Lamp.Temperature = TemperatureState.StillHot;
        Console.WriteLine($"{Name} desligado. {Lamp.Name} está desligada e ainda quente.");
    }
}