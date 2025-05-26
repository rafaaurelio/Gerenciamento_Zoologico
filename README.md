# Gerenciamento_Zoologico
Sistema de Gerenciamento de Zoológico para fins didáticos (AP2) 

Objetivo:
Desenvolver uma aplicação em .NET 8, utilizando o paradigma de Programação Orientada a Objetos (POO). O projeto deve demonstrar claramente o domínio dos conceitos fundamentais da POO, incluindo encapsulamento, herança, polimorfismo, abstração, propriedades, métodos, construtores, sobrecarga, interfaces, classes abstratas e métodos abstratos.

Descrição Detalhada:
Você deverá criar uma aplicação do tipo Console Application em C# (.NET 8) que implemente o seguinte cenário:

"Sistema de Gerenciamento para um Zoológico"
O sistema deve permitir:

Cadastrar diferentes tipos de animais (mamíferos, aves e répteis).

Cada animal terá características específicas e comuns, como nome, idade, peso e espécie.

Gerenciar funcionários (Veterinários e Zeladores), cada um com funcionalidades específicas e gerais.

Cada tipo de funcionário deve interagir com os animais de forma distinta:
Veterinários realizam consultas e tratamentos.
Zeladores cuidam da alimentação e manutenção dos habitats.

Estrutura detalhada de Classes, Interfaces, Propriedades e Métodos:

Classes abstratas:
Animal:
Propriedades: Nome (string), Idade (int), Peso (double), Especie (string)
Métodos abstratos: EmitirSom(), Movimentar()
Construtor: Animal(string nome, int idade, double peso, string especie)

Funcionario:
Propriedades: Nome (string), Idade (int), Cargo (string)
Métodos abstratos: Trabalhar()
Construtor: Funcionario(string nome, int idade, string cargo)

Classes Concretas:
Mamifero (derivada de Animal):
Método adicional: Amamentar()

Ave (derivada de Animal):
Método adicional: Voar()

Reptil (derivada de Animal):
Método adicional: Rastejar()

Veterinario (derivada de Funcionario, implementa ITratamentoAnimal):
Método adicional: ConsultarAnimal(Animal animal)

Zelador (derivada de Funcionario, implementa ICuidador):
Método adicional: AlimentarAnimal(Animal animal)

Interfaces:
ITratamentoAnimal:
Método: RealizarTratamento(Animal animal)

ICuidador:
Método: CuidarHabitat(Animal animal)

Fluxo do Programa:
Inicialização do sistema:
Exibir menu principal com opções: Cadastro de Animais, Cadastro de Funcionários, Interação Animal-Funcionário, Sair.

Cadastro de Animais:
Solicitar tipo de animal (Mamífero, Ave, Réptil).
Solicitar dados comuns: nome, idade, peso, espécie.
Confirmar cadastro com mensagem exibindo detalhes do animal cadastrado.

Cadastro de Funcionários:
Solicitar tipo de funcionário (Veterinário, Zelador).
Solicitar dados comuns: nome, idade.
Confirmar cadastro com mensagem exibindo detalhes do funcionário cadastrado.

Interação Animal-Funcionário:
Listar animais e funcionários cadastrados.
Selecionar um animal e um funcionário.
Executar interação apropriada (consultar, tratar, alimentar, cuidar habitat).
Exibir mensagem detalhando o resultado da interação.

Exemplos de Saídas Esperadas:
"Animal cadastrado com sucesso: Nome: Simba, Idade: 5, Peso: 120kg, Espécie: Leão."
"Funcionário cadastrado com sucesso: Nome: João, Idade: 32, Cargo: Veterinário."
"Veterinário João consultou o animal Simba com sucesso."
"Zelador Marcos alimentou o animal Simba com sucesso."

Requisitos Técnicos Obrigatórios:
Utilize encapsulamento apropriado através de propriedades e métodos com níveis adequados de acesso.
Implemente construtores adequadamente para inicializar objetos de forma consistente.
Utilize sobrecarga de métodos para oferecer flexibilidade ao sistema em diferentes contextos.
Utilize coleções para armazenar e manipular objetos do sistema (ex: List).
