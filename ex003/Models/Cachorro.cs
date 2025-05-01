namespace ex003.Models;

public sealed class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} faz: Au Au!");
    }

    public override void Mover()
    {
        Console.WriteLine($"{Nome} está correndo!");
    }
}
