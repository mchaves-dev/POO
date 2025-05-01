namespace ex003.Models;

public sealed class Pato : Animal
{
    public Pato(string nome) : base(nome) { }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} faz: Quack!");
    }

    public override void Mover()
    {
        Console.WriteLine($"{Nome} está nadando!");
    }
}