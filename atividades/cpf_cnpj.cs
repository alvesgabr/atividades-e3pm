/*Implemente uma classe Pessoa em C# que armazena os seguintes atributos:

    Nome: do tipo texto e armazena o nome da pessoa,
    Endereço: do tipo texto e armazena o endereço completo da pessoa,
    Telefone: do tipo texto e armazena o DDD e o número do telefone da pessoa,

Encapsule os atributos e implemente as propriedades:

    Nome: leitura/escrita para o atributo primeiroNome.
    Endereco: leitura/escrita para o atributo endereco.
    Telefone: leitura/escrita para o atributo telefone.

Implemente agora duas subclasses de Pessoa: PessoaFisica e PessoaJuridica.

A classe PessoaFisica deve ter a propriedade Cpf.

A classe PessoaJuridica deve ter a propriedade Cnpj.

Finalmente, implemente uma classe MainClass para mostrar o funcionamento das classes PessoaFisica e PessoaJuridica.
*/
using System;

class Pessoa
{
	protected string _primeiroNome;
	protected string _sobrenome;
	protected string _endereco;
	protected string _telefone;
	protected string _nomeCompleto;

	private static int contador;
	public static int Contador { get => Pessoa.contador; }

	public Pessoa(string primeiroNome, string sobrenome)
	{
		this._primeiroNome = primeiroNome;
		this._sobrenome = sobrenome;
		this._nomeCompleto = $"{this._primeiroNome} {this._sobrenome}";
		++Pessoa.contador;
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

class PessoaFisica : Pessoa
{
	private string _cpf;

	public PessoaFisica(string primeiroNome, string sobrenome, string cpf) : base(primeiroNome, sobrenome)
	{
		this.Cpf = cpf;
	}

	public string Cpf
	{
		get => this._cpf;
		set { if (value.Length == 11) this._cpf = value; }
	}
}

class PessoaJuridica : Pessoa
{
	private string _cnpj;

	public PessoaJuridica(string primeiroNome, string sobrenome, string cnpj) : base(primeiroNome, sobrenome)
	{
		this.Cnpj = cnpj;
	}

	public string Cnpj
	{
		get => this._cnpj;
		set { if (value.Length == 14) this._cnpj = value; }
	}
}


class Program
{
	static void ExibeInformacoes(Pessoa pessoa)
	{
		Console.WriteLine($"Nome: {pessoa.NomeCompleto}");
		Console.WriteLine($"Endereço: {pessoa.Endereco}");
		if (pessoa is PessoaFisica)
		{
			PessoaFisica pessoaFisica = pessoa as PessoaFisica;
			Console.WriteLine($"CPF: {pessoaFisica.Cpf}");
		}
		else
		{
			PessoaJuridica pessoaJuridica = pessoa as PessoaJuridica;
			Console.WriteLine($"CNPJ: {pessoaJuridica.Cnpj}");
		}
		Console.WriteLine($"Telefone: {pessoa.Telefone}");
		Console.WriteLine($"Número de Pessoas: {Pessoa.Contador}\n");
	}

	static void Main(string[] args)
	{
		PessoaFisica empregado = new PessoaFisica("Hiro", "Protagonist", "12345678901");
		empregado.Endereco = "TMWAH - Los Angeles";
		empregado.Telefone = "555 123 45678";

		ExibeInformacoes(empregado);

		PessoaJuridica patrao = new PessoaJuridica("Uncle", "Enzo", "12345678901234");
		patrao.Endereco = "Unknown";
		patrao.Telefone = "000 000 00001";

		ExibeInformacoes(patrao);
	}
}