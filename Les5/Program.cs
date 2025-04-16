// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public interface Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }

    public abstract void Eat();
    public abstract void MakeSound();

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}   