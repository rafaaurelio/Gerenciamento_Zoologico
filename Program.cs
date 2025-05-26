using System.Diagnostics;

List<Animal> animais = new List<Animal>();
List<Funcionario> funcionarios = new List<Funcionario>();
animais.Add(ave1);
animais.Add(ave2);
funcionarios.Add(vet);
funcionarios.Add(vet2);

bool running = true;

while (running)
{   Console.WriteLine("\n--- Gerenciamento de Zoológico ---");
    Console.WriteLine(" 1) Cadastro de Animais \n 2) Cadastro de Funcionários \n 3) Interação Animal-Funcionário \n 4) Sair");
    Console.WriteLine("Escolha uma opção: ");
    string? opcao = Console.ReadLine();
    

    switch (opcao)
    {
        case "1":
            CadastrarAnimal();
            break;
        case "2":
            CadastrarFuncionario();
            break;
        case "3":
            InteracaoAnimalFuncionario();
            break;
        case "4":
            Console.WriteLine("Saindo do programa...");
            running = false;
            break;
        default:
            Console.WriteLine("Por favor, insira uma opção válida!");
            break;
    }
}

void CadastrarAnimal()
{

    Console.WriteLine("\n--- Cadastro de Animais ---");
    Console.WriteLine(" Mamífero");
    Console.WriteLine(" Ave");
    Console.WriteLine(" Réptil");
    Console.WriteLine("Escolha qual especie deseja cadastrar: ");

    string? especie = Console.ReadLine();

    if (especie != "Mamifero" && especie != "Ave" && especie != "Reptil")
    {
        Console.WriteLine("Por favor, digite uma opção válida!");
        return;
    }

    Console.WriteLine("\nNome:");
    string? nome = Console.ReadLine();

    Console.WriteLine("\nIdade:");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPeso:");
    double peso = Convert.ToDouble(Console.ReadLine());

    switch (especie)
    {
        case "Mamifero":
            Mamifero mamifero = new Mamifero(nome, idade, peso, especie);
            animais.Add(mamifero);
            Console.WriteLine($"O Mamífero {nome} com {idade} anos pesando {peso} kg foi criado!");
            break;
        case "Ave":
            Ave ave = new Ave(nome, idade, peso, especie);
            animais.Add(ave);
            Console.WriteLine($"A Ave {nome} com {idade} anos pesando {peso} kg foi criada!");
            break;
        case "Reptil":
            Reptil reptil = new Reptil(nome, idade, peso, especie);
            animais.Add(reptil);
            Console.WriteLine($"O Réptil {nome} com {idade} anos pesando {peso} kg foi criado!");
            break;
    }        
}

void CadastrarFuncionario()
{
    Console.WriteLine("\n--- Cadastro de Funcionários ---");
    Console.WriteLine(" Veterinário");
    Console.WriteLine(" Zelador");
    Console.WriteLine("Escolha qual funcionário deseja cadastrar: ");

    string? cargo = Console.ReadLine();

    if (cargo != "Veterinario" && cargo != "Zelador")
    {
        Console.WriteLine("Por favor, digite uma opção válida!");
        return;
    }

    Console.WriteLine("\nNome:");
    string? nome = Console.ReadLine();

    Console.WriteLine("\nIdade:");
    int idade = Convert.ToInt32(Console.ReadLine());

    switch (cargo)
    {
        case "Veterinário" or "Veterinario":
            Veterinario veterinario = new Veterinario(nome, idade, cargo);
            funcionarios.Add(veterinario);
            Console.WriteLine($"O Veterinário {nome} com {idade} anos foi cadastrado!");
            break;
        case "Zelador":
            Zelador zelador = new Zelador(nome, idade, cargo);
            funcionarios.Add(zelador);
            Console.WriteLine($"O Zelador {nome} com {idade} anos foi cadastrado!");
            break;
    }
}

void InteracaoAnimalFuncionario()
{
    if (animais.Count == 0 || funcionarios.Count == 0)
    {
        Console.WriteLine("É necessário cadastrar no mínimo um funcionário e um animal antes!");
        return;
    }

    Console.WriteLine("\n--- Interação Animal-Funcionário ---");
    Console.WriteLine(" Lista de  Animais");
    for (int i = 0; i < animais.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {animais[i].Nome} - {animais[i].Idade} anos - {animais[i].Peso} kg - {animais[i].Especie}");
    }

    Console.WriteLine("Escolha o índice do Animal desejado: ");
    int iAnimal = Convert.ToInt32(Console.ReadLine());
    Animal animal = animais[iAnimal - 1];

    Console.WriteLine("\nLista de Funcionários");
    for (int i = 0; i < funcionarios.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {funcionarios[i].Nome} - {funcionarios[i].Idade} - {funcionarios[i].Cargo}");
    }

    Console.WriteLine("Escolha o índice do Funcionário desejado: ");
    int iFuncionario = Convert.ToInt32(Console.ReadLine());
    Funcionario funcionario = funcionarios[iFuncionario - 1];

    funcionario.Trabalhar();
    switch (funcionario)
    {
        case Veterinario veterinario:
            veterinario.ConsultarAnimal(animal);
            veterinario.RealizarTratamento(animal);
            break;
        case Zelador zelador:
            zelador.AlimentarAnimal(animal);
            zelador.CuidarHabitat(animal);
            break;
    }
}


