/*
Implemente uma classe Pessoa em C# que armazena os seguintes atributos.

             Nome: do tipo texto e armazena o nome completo da pessoa,
             Endereço: do tipo texto e armazena o endereço completo da pessoa,
             Telefone: do tipo texto e armazena o DDD e o número do telefone da pessoa,

E o seguinte método:
          primeiroNome( ): retorna elemento do tipo texto

Este método retorna o primeiro nome da pessoa. Por enquanto não se preocupe com a ocorrência de nomes compostos.

Por enquanto, os atributos devem ser acessíveis diretamente, sem a necessidade de métodos de acesso.

Implemente um construtor default e um construtor com parâmetros que inicialize os três atributos com valores fornecidos pelo usuário.

Finalmente, implemente uma classe MainClass para mostrar o funcionamento da sua classe Pessoa.
*/
using System;

class Pessoa
{
	public string nome;
	public string endereco;
	public string telefone;

	public Pessoa(String nome, String endereco, String telefone)
	{
		if (nome.Length >= 6)
			this.nome = nome;
		if (endereco.Length >= 6)
			this.endereco = endereco;
		if (telefone.Length >= 6)
			this.telefone = telefone;
	}

	public Pessoa()
	{
		this.nome = "Sem nome";
		this.endereco = "Sem endereço";
		this.telefone = "Sem telefone";
	}


	public string primeiroNome()
	{
		if (string.IsNullOrWhiteSpace(nome))
		{
			return "";
		}

		string[] nomeSeparado = nome.Split(" ");
		return nomeSeparado[0];
	}
}

class MainClass
{
	public static void Main(string[] args)
	{
		Pessoa pessoa = new Pessoa();
		pessoa.nome = "Hiro Protagonist";
		pessoa.endereco = "Baker Street 221B - London (UK)";
		pessoa.telefone = "555 567 5309";

		Console.Write($"{pessoa.nome} mora em {pessoa.endereco} e seu # é {pessoa.telefone}.");

		Console.Write($"\nSeu primeiro nome é: {(pessoa.primeiroNome())}");
	}
}