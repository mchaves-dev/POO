namespace ex003.Models;

public sealed class Gato : Animal
{
    public Gato(string nome) : base(nome) { }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} faz: Miau!");
    }

    public override void Mover()
    {
        Console.WriteLine($"{Nome} está andando sorrateiramente!");
    }
}