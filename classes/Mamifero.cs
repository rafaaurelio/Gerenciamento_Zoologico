public class Mamifero : Animal
{

    public Mamifero(string? nome, int idade, double peso, string? especie) : base(nome, idade, peso, especie)
    {
        
    }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está emitindo som de mamífero.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} está se movimentando.");
    }   

    public void Amamentar()
    {
        Console.WriteLine($"{Nome} está amamentando um mamífero.");
    }

}