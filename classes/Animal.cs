public abstract class Animal
{
    public string? Nome;
    public int Idade;
    public double Peso;
    public string? Especie;

    public string? nome { get; set; }
    public int idade { get; set; }
    public double peso { get; set; }
    public string? especie { get; set; }

    public Animal(string? nome, int idade, double peso, string? especie)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Peso = peso;
        this.Especie = especie;
    }


    public abstract void EmitirSom();
    public abstract void Movimentar();

}