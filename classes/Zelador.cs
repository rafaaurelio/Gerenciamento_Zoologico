public class Zelador : Funcionario, ICuidador
{
    public Zelador(string? nome, int idade, string? cargo) : base(nome, idade, cargo)
    {

    }

    public override void Trabalhar()
    {
        Console.WriteLine($"\n{Nome} Está trabalhando.");
    }

    public void AlimentarAnimal(Animal animal)
    {
        Console.WriteLine($"{Nome} está alimentando {animal.Nome} ({animal.Especie})");
    }

    public void CuidarHabitat(Animal animal)
    {
        Console.WriteLine($"{Nome} está cuidando do habitat de {animal.Nome} ({animal.Especie})");
    }


}