using ex003.Enums;
using ex003.Factories;
using ex003.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var animais = new List<Animal>()
        {
            AnimalFactory.Criar(ETipoAnimal.Cachorro, "Rex"),
            AnimalFactory.Criar(ETipoAnimal.Gato, "Mimi" ),
            AnimalFactory.Criar(ETipoAnimal.Pato, "Donald" ),
            AnimalFactory.Criar(ETipoAnimal.Passarinho, "Pipi" )
        };

        foreach (var animal in animais)
        {
            animal.ExibirDescricao();
            animal.EmitirSom();
            animal.Mover();
            Console.WriteLine(new string('-', 40));
        }
    }
}