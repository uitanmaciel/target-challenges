using Lamps.Enums;

namespace Lamps.Models;

public sealed class Lamp()
{
    public string Name { get; set; } = null!;
    public bool IsOn { get; set; }
    public TemperatureState Temperature { get; set; }

    public Lamp(string name, bool isOn, TemperatureState temperature) : this()
    {
        Name = name;
        IsOn = isOn;
        Temperature = temperature;
    }
    
    public void Display()
    {
        var state = IsOn 
            ? "Ligada" 
            : Temperature is TemperatureState.Hot or TemperatureState.StillHot
                ? "Quente" 
                : "Fria";
        
        Console.WriteLine($"{Name} está {state}");
    }
}