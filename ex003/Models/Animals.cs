namespace ex003.Models;

public abstract class Animal
{
    public Animal(string nome)
    {
        this.Nome = nome;
    }

    public string Nome { get; private set; }

    public abstract void EmitirSom();

    public abstract void Mover();

    public virtual void ExibirDescricao()
    {
        Console.WriteLine($"{GetType().Name} chamado {Nome}");
    }
}