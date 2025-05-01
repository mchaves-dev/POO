namespace ex003.Models;

public sealed class Passarinho : Animal
{
    public Passarinho(string nome) : base(nome) { }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} faz: Piu Piu!");
    }

    public override void Mover()
    {
        Console.WriteLine($"{Nome} está voando!");
    }
}