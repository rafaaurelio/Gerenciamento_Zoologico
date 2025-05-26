public class Veterinario : Funcionario, ITratamentoAnimal
{

    public Veterinario(string? nome, int idade, string? cargo) : base(nome, idade, cargo)
    {

    }

    public override void Trabalhar()
    {
        Console.WriteLine($"\n{Nome} Está trabalhando.");
    }

    public void ConsultarAnimal(Animal animal)
    {
        Console.WriteLine($"{Nome} está consultando o {animal.Nome} ({animal.Especie}).");
    }

    public void RealizarTratamento(Animal animal)
    {
        Console.WriteLine($"{Nome} está realizando o tratamento no {animal.Nome} ({animal.Especie}).");
    }

}