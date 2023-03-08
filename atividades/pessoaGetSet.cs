/*
Implemente uma classe Pessoa em C# que armazena os seguintes atributos:

    Primeiro Nome: do tipo texto e armazena o primeiro nome da pessoa,
    Sobrenome: do tipo texto e armazena o sobrenome da pessoa,
    Endereço: do tipo texto e armazena o endereço completo da pessoa, 
    Telefone: do tipo texto e armazena o DDD e o número do telefone da pessoa,

Encapsule os atributos e implemente as propriedades:

    PrimeiroNome: leitura/escrita para o atributo primeiroNome.
    Sobrenome: leitura/escrita para o atributo sobrenome.
    NomeCompleo: somente-leitura que retorna a concatenação do primeiro nome com o sobrenome.
    Endereco: leitura/escrita para o atributo endereco.
    Telefone: leitura/escrita para o atributo telefone.

Finalmente, implemente uma classe MainClass para mostrar o funcionamento da sua classe Pessoa.
*/

using System;

class Pessoa
{
	private string _primeiroNome;
	private string _sobrenome;
	private string _endereco;
	private string _telefone;
	private string _nomeCompleto;

	public Pessoa(string primeiroNome, string sobrenome)
	{
		this._primeiroNome = primeiroNome;
		this._sobrenome = sobrenome;
		this._nomeCompleto = $"{this._primeiroNome} {this._sobrenome}";
	}

	public string PrimeiroNome
	{
		get => this._primeiroNome;
		set { if (value.Length >= 3) this._primeiroNome = value; }
	}

	public string Sobrenome
	{
		get => this._sobrenome;
		set { if (value.Length >= 3) this._sobrenome = value; }
	}

	public string NomeCompleto { get => this._nomeCompleto; }

	public string Endereco
	{
		get => this._endereco;
		set { if (value.Length > 3) this._endereco = value; }
	}

	public string Telefone
	{
		get => this._telefone;
		set { if (value.Length > 6 && value.Length < 16) this._telefone = value; }
	}

}

class Program
{
	static void Main()
	{
		Pessoa pessoaExemplo = new Pessoa("Hiro", "Protagonist");
		pessoaExemplo.Endereco = "Suburbclave St";
		pessoaExemplo.Telefone = "(555) 123 4567";

		Console.WriteLine($"Nome: {pessoaExemplo.NomeCompleto}");
		Console.WriteLine($"Endereço: {pessoaExemplo.Endereco}");
		Console.WriteLine($"Telefone: {pessoaExemplo.Telefone}");
	}
}
