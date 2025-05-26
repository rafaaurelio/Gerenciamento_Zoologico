public class Reptil : Animal
{
    public Reptil(string? nome, int idade, double peso, string? especie) : base(nome, idade, peso, especie) {

    }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está emitindo som de de Reptil.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} está se movimentando.");
    }

    public void Rastejar() {
        Console.WriteLine($"{Nome} está rastejando.");
    }


}