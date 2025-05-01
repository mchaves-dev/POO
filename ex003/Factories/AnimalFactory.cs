using ex003.Enums;
using ex003.Models;

namespace ex003.Factories;

public static class AnimalFactory
{
    private static readonly Dictionary<ETipoAnimal, Func<string, Animal>> _instancias = new()
    {
        { ETipoAnimal.Cachorro, nome => new Cachorro(nome) },
        { ETipoAnimal.Gato, nome => new Gato(nome) },
        { ETipoAnimal.Pato, nome => new Pato(nome) },
        { ETipoAnimal.Passarinho, nome => new Passarinho(nome) }
    };

    public static Animal Criar(ETipoAnimal tipoAnimal, string nome)
    {
        if (_instancias.TryGetValue(tipoAnimal, out var factory))
            return factory(nome);

        throw new NotSupportedException($"Tipo '{tipoAnimal}' não é suportado.");
    }
}