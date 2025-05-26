public abstract class Funcionario
{

    public string? Nome;
    public int Idade;
    public string? Cargo;

    public string? nome { get; set; }
    public int idade { get; set; }
    public string? cargo { get; set; }


    public Funcionario(string? nome, int idade, string? cargo)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Cargo = cargo;

    }

    public abstract void Trabalhar();

}